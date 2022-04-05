using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreeFriend.Models;
using TreeFriend.Models.Entity;
using System.Linq;
using TreeFriend.Models.ViewModel;
using System;
using Microsoft.AspNetCore.Authorization;

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
