using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreeFriend.Models;
using TreeFriend.Models.Entity;
using System.Linq;
using TreeFriend.Models.ViewModel;
using System;

namespace TreeFriend.Controllers.Api {
    [Route("api/[controller]")]
    [ApiController]
    public class SkillPostController : ControllerBase {
        private readonly TreeFriendDbContext _db;

        //注入DbContext
        public SkillPostController(TreeFriendDbContext db) {
            _db = db;
        }

        //新增技能貼文
        [HttpPost]
        [Route("AddSkillPost")]
        public string AddSkillPost([FromBody] SkillPostViewModel skillPost) {

            //將ViewModel資料對應至Entity中
            SkillPost post = new SkillPost() {
                UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(u => u.Type == "UserId").Value),
                Title = skillPost.Title,
                Content = skillPost.Content,
                Region = skillPost.Region,
                CategoryId = skillPost.CategoryId,
            };

            try {
                //先將資料更新貼文，才能取得當前貼文ID
                _db.skillPosts.Add(post);
                _db.SaveChanges();

                //拿到該使用者的最後一筆新增貼文的ID後
                //存入標籤細節表，對應的標籤&貼文
                //TODO: 多對多
                var PostId = _db.skillPosts.Where(p => p.UserId == post.UserId).ToList().LastOrDefault().SkillPostId;
                _db.hashtagDetails.Add(new HashtagDetail { SkillPostId = PostId, HashtagId = skillPost.HashtagId });
                _db.SaveChanges();

                return "新增成功";
            } catch (Exception) {
                return "新增失敗";
            }
        }
    }
}
