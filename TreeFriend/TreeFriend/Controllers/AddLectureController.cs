using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TreeFriend.Models;
using TreeFriend.Models.Entity;
using TreeFriend.Models.ViewModel;

namespace TreeFriend.Controllers
{
    public class AddLectureController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly TreeFriendDbContext _db;
        private readonly string _folder;

        public AddLectureController(IWebHostEnvironment environment, TreeFriendDbContext db)
        {
            _environment = environment;
            _folder = $@"{environment.WebRootPath}\LecturePicture";
            _db = db;
        }


        #region 渲染
        public List<AddLecturelistViewModel> GetAllLecture()
        {
            var result = _db.Lectures.Where(x => x.IsDelete == false).Select(x => new AddLecturelistViewModel
            {
                LectureId = x.LectureId,
                CreateDate = x.CreateDate.ToString("yyyy/MM/dd"),
                Theme = x.Theme,
                EventDate = x.EventDate.ToString("yyyy/MM/dd"),
                EventTimeStart = x.EventTimeStart.ToString("HH:mm"), //HH24小時 hh12小時
                EventTimeEnd = x.EventTimeEnd.ToString("HH:mm"),
                Venue = x.Venue,
                Speaker = x.Speaker,
                Count = x.Count,
                Price = x.Price,
                Description = x.Description,
                Content = x.Content,
                ImgPath = x.ImgPath
            }).ToList();

            return result;
        }
        #endregion

        #region 講座修改

        [HttpPost]
        public bool UpdateLecture([FromForm] UpdateLectureViewModel model)
        {
            var updateLecture = _db.Lectures.Where(x => x.LectureId == model.LectureId).FirstOrDefault();
            string pic;


            if (model.Picture == null)
            {
                pic = updateLecture.ImgPath;
            }
            else
            {
                var fileName = DateTime.Now.ToString("MMddHHmmss") + model.Picture[0].FileName;
                var path = $@"{_folder}\{fileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    model.Picture[0].CopyTo(stream);
                    pic = $@"/LecturePicture/{fileName}";
                }

            }
            if (updateLecture != null)
            {
                updateLecture.Theme = model.Theme;
                updateLecture.EventDate = model.EventDate;
                updateLecture.EventTimeStart = model.EventTimeStart;
                updateLecture.EventTimeEnd = model.EventTimeEnd;
                updateLecture.Speaker = model.Speaker;
                updateLecture.Venue = model.Venue;
                updateLecture.Price = model.Price;
                updateLecture.Count = model.Count;
                updateLecture.Description = model.Description;
                updateLecture.Content = model.Content;
                updateLecture.ImgPath = pic;
                updateLecture.UpdateTime = DateTime.Now;
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion


        #region 講座新增

        [HttpPost]
        public bool UploadFile(UploadFileViewModel model)
        {
            var UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(u => u.Type == "UserId").Value);


            string pic;

            var fileName = DateTime.Now.ToString("MMddHHmmss") + model.Picture[0].FileName;
            var path = $@"{_folder}\{fileName}";
            using (var stream = new FileStream(path, FileMode.Create))
            {
                model.Picture[0].CopyTo(stream);
                pic = $@"/Lecturepicture/{fileName}";
            }

            if (pic != null)
            {

                _db.Lectures.Add(new Lecture()
                {
                    CreateDate = DateTime.Now,
                    Theme = model.Theme,
                    EventDate = model.EventDate,
                    EventTimeStart = model.EventTimeStart,
                    EventTimeEnd = model.EventTimeEnd,
                    Venue = model.Venue,
                    Description = model.Description,
                    Content = model.Content,
                    Speaker = model.Speaker,
                    Count = model.Count,
                    Price = model.Price,
                    ImgPath = pic,
                    UserId = UserId


                });

                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 講座軟刪除
        [HttpDelete]
        public bool DeleteLecture([FromQuery] int lectureId)
        {
            try
            {
                var result = _db.Lectures.Where(x => x.LectureId == lectureId).SingleOrDefault();
                Console.WriteLine(result);
                result.IsDelete = true;
                _db.Lectures.Update(result);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}

