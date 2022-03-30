using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using TreeFriend.Models.Entity;
using TreeFriend.Models;
using TreeFriend.Models.KallinAndYolan;

namespace TreeFriend.Controllers {
    public class RegisterController : Controller {
        private readonly TreeFriendDbContext _context;

        public RegisterController(TreeFriendDbContext context) {
            _context = context;
        }


        // GET: Register
        public async Task<IActionResult> Index() {
            return View(await _context.users.ToListAsync());
        }

        // GET: Register/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var user = await _context.users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null) {
                return NotFound();
            }

            return View(user);
        }

        public bool SameEmail([FromBody] SameEmail sameEmail) {
            var check = _context.users.Where(x => x.Email == sameEmail.Email)
               .FirstOrDefault();
            if (check == null) {
                return true;
            } else {
                return false;
            }
        }

        //public IActionResult SameEmail([FromBody] SameEmail sameEmail)
        //{
        //    var check = _context.users.Where(x => x.Email == sameEmail.Email)
        //       .FirstOrDefault();
        //    if (check == null)
        //    {
        //        return Ok("註冊成功");
        //    }
        //    else
        //    {
        //        return BadRequest("帳號已被使用");
        //    }
        //}

        // GET: Register/Create
        [AllowAnonymous]
        public IActionResult Create() {
            return View();
        }

        // POST: Register/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] User user) {
            //if(user.Email!=0)
            //var register = _context.users.Where(x => x.Email != user.Email && x.Phone != user.Phone).FirstOrDefault();
            //if (register == null)
            //{
            //    _context.Add(user);
            //}
            //if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.Phone))
            //{
            //    return Content ("請輸入資料");
            //}
            //else
            //{
            if (user.Email != "" && user.Password != "") {
                var register = _context.users.Where(x => x.Email == user.Email).FirstOrDefault();
                if (register == null) {
                    if (ModelState.IsValid) {
                        _context.Add(user);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(AfterRegister));
                    }
                    return View(user);
                } else {
                    return Content("成功");
                }
            } else {
                return Content("資料有誤");
            }
        }
        //}

        public IActionResult AfterRegister() {
            return View();
        }

        [HttpPost]
        //[Authorize(Roles="admin")]
        public async Task<IActionResult> Login([FromBody] UserLoginViewModel model) {
            var check = _context.users.Where(x => x.Email == model.Email && x.Password == model.Password )
                .FirstOrDefault();
            //設定身分
            var UserLevel = check.UserLevel == true ? "Admin" : "Member";

            if (check == null) {
                return View("Create");
            } else {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Email,check.Email),
                    new Claim("UserId",check.UserId.ToString()),
                    new Claim(ClaimTypes.Role,UserLevel)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(claimsPrincipal);
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                new AuthenticationProperties {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
                });

                return Json(Url.Action("HomePage", "Home"));
            }

        }
        [HttpPost]
        public async Task<IActionResult> Logout(UserLoginViewModel model) {
            //var check = _context.users.Where(x => x.Email == model.Email && x.Password == model.Password)
            //   .FirstOrDefault();
            //if (check == null)
            //{
            //    return RedirectToAction("index", "Home");
            //}
            //else
            //{
            await HttpContext.SignOutAsync(
        CookieAuthenticationDefaults.AuthenticationScheme);

            return Json(Url.Action("Index", "Home"));
            //}
        }



        // GET: Register/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var user = await _context.users.FindAsync(id);
            if (user == null) {
                return NotFound();
            }
            return View(user);
        }

        // POST: Register/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Email,Password")] User user) {
            if (id != user.UserId) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!MembersExists(user.UserId)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Register/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var user = await _context.users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null) {
                return NotFound();
            }

            return View(user);
        }

        // POST: Register/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var user = await _context.users.FindAsync(id);
            _context.users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembersExists(int id) {
            return _context.users.Any(e => e.UserId == id);
        }



    }
}
