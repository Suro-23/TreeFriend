using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreeFriend.Models;
using TreeFriend.Models.Entity;
using System.Linq;
using TreeFriend.Models.ViewModel;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace TreeFriend.Controllers.Api {
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SkillPostController : ControllerBase {
        private readonly TreeFriendDbContext _db;

        //注入DbContext
        public SkillPostController(TreeFriendDbContext db) {
            _db = db;
        }

        #region 技能貼文
        //新增技能貼文
        [HttpPost]
        [Route("AddSkillPost")]
        public string AddSkillPost([FromBody] SkillPostViewModel skillPost) {
            //將ViewModel資料對應至Entity中
            SkillPost post = new() {
                UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(u => u.Type == "UserId").Value),
                Title = skillPost.Title,
                Content = skillPost.Content,
                Region = skillPost.Region,
                CategoryId = skillPost.CategoryId
            };

            try {
                //先將資料更新貼文，才能取得當前貼文ID
                _db.skillPosts.Add(post);
                _db.SaveChanges();
            } catch (Exception) {
                return "新增失敗";
            }

            //拿到該使用者的最後一筆新增貼文的ID後
            //存入標籤細節表，對應的標籤&貼文
            var PostId = _db.skillPosts.Where(p => p.UserId == post.UserId).ToList().LastOrDefault().SkillPostId;

            try {
                //將標籤陣列依序新增到標籤細節資料庫
                foreach (var item in skillPost.HashtagId) {
                    _db.hashtagDetails.Add(new HashtagDetail { SkillPostId = PostId, HashtagId = item });
                }
                _db.SaveChanges();

                return "新增成功";
            } catch (Exception) {
                return "新增失敗";
            }
        }

        [HttpGet]
        [Route("GetAllSkillPost")]
        public List<SkillPostViewModel> GetAllSkillPost() {
            int userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(u => u.Type == "UserId").Value);

            //拿到該使用者的所有貼文
            var skillPostList = _db.skillPosts.Where(p => p.UserId == userId && p.Status == true).OrderByDescending(e => e.SkillPostId);

            //將skillPostList join hashtagDetail 拿到所有文章的所有標籤
            //存成新物件備用
            var skillPostJoin = _db.hashtagDetails.Join(skillPostList,
                h => h.SkillPostId,
                p => p.SkillPostId,
                (h, p) => new {
                    SkillPostId = p.SkillPostId,
                    Title = p.Title,
                    CategoryId = p.CategoryId,
                    Content = p.Content,
                    Region = p.Region,
                    HashtagId = h.HashtagId
                }).ToList();

            //參考資料: https://docs.microsoft.com/zh-tw/dotnet/csharp/linq/group-query-results
            //將文章分組備用
            //分完後的樣子會變成
            //postID_1:
            //      sqlRow1,sqlRow2,sqlRow3
            //postID_2:
            //      sqlRow1,sqlRow2
            var groupList = from skPost in skillPostJoin
                            group skPost by skPost.SkillPostId into newGroup
                            orderby newGroup.Key
                            select newGroup;
            //創建一個集合備用
            List<SkillPostViewModel> ressultList = new();

            //將分組資料依序塞入陣列中
            //這裡的遍歷是根據
            foreach (var group in groupList) {
                ressultList.Add(
                    new SkillPostViewModel {
                        Title = group.Select(x => x.Title).FirstOrDefault(),
                        CategoryId = group.Select(x => x.CategoryId).FirstOrDefault(),
                        Content = group.Select(x => x.Content).FirstOrDefault(),
                        Region = group.Select(x => x.Region).FirstOrDefault(),
                        HashtagId = group.Select(x => x.HashtagId).ToArray()
                    });
            }

            return ressultList;
        }
        #endregion

        #region 留言

        //加入留言
        [HttpPost]
        [Route("SkPostMessage")]
        public void LiveSkillPostMessage([FromBody] SkillPostMessageViewModel skMessage) {
            //拿到當前使用者資訊後將留言寫入技能留言資料表中
            SkillPostMessage post = new SkillPostMessage() {
                UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(u => u.Type == "UserId").Value),
                Content = skMessage.Content,
                SkillPostId = skMessage.SkillPostId
            };
            _db.skillPostMessages.Add(post);
            _db.SaveChanges();
        }

        #endregion

    }
}
