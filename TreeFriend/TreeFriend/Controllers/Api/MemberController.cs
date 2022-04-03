using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreeFriend.Models;
using System.Linq;
using System;
using TreeFriend.Models.ViewModel;

namespace TreeFriend.Controllers.Api {
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase {
        private readonly TreeFriendDbContext _db;

        public MemberController(TreeFriendDbContext db) {
            _db = db;
        }

        //編輯基本資料
        [Route("EditMemberInfo")]
        [HttpPost]
        public string EditMemberInfo([FromBody] UserDetailViewModel userVM) {
            //獲取Cookies中的UserId後找尋該筆Entity資料
            int userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(u => u.Type == "UserId").Value);
            var memberInfo = _db.usersDetail.FirstOrDefault(u => u.UserId == userId);

            //將字串轉成日期格式 輸入格式: YYYY-MM-DD
            var birthDay = DateTime.Parse(userVM.Birthday);

            //將UserDetailViewModel資料對應至Entity中
            //即更新資料，完成後儲存
            try {
                memberInfo.UserName = userVM.UserName;
                memberInfo.Birthday = birthDay;
                memberInfo.Sex = userVM.Sex;
                memberInfo.HeadshotPath = userVM.HeadshotPath;
                memberInfo.SelfIntrodution = userVM.SelfIntrodution;
                _db.SaveChanges();
                return "更新成功";
            } catch (Exception) {
                return "更新失敗";
            }
        }
    }
}
