using Facebook.Common.DTO;
using FacebookApp.Models;
using FacebookApp.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FacebookApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserViewModel usrModel)
        {
            if (_userService.isUserExists(usrModel.Email) == true)
            {
                var user = _userService.GetUserByEmail(usrModel.Email);
                HttpContext.Session.SetString("Username", user.Name);
                HttpContext.Session.SetString("Password", user.Password);
                HttpContext.Session.SetString("Phone", user.Phone);
                HttpContext.Session.SetString("Email", user.Email);

                return Json(new { message = "Giriş Başarılı" });
            }
            else
            {
                return Json(new { message = "Hatalı parola veya kullanıcı adı" });
            }
        }

        [HttpPost]
        public IActionResult Register(UserViewModel usrModel)
        {
            if (ModelState.IsValid)
            {
                if (_userService.isUserExists(usrModel.Email) == false)
                {
                    UserDTO userDto = new UserDTO();
                    userDto.Name = usrModel.Name;
                    userDto.Surname = usrModel.Surname;
                    userDto.Password = usrModel.Password;
                    userDto.Email = usrModel.Email;
                    userDto.Phone = usrModel.Phone;
                    userDto.BirthDate = usrModel.BirthDate;
                    userDto.Gender = usrModel.Gender;
                    _userService.CreateUser(userDto);

                    return Json(new { message = "Kayıt başarılı" });
                }
                else
                {
                    return Json(new { message = "Bu kullanıcı zaten kayıtlı" });
                }
            }

            else
            {
                ModelState.AddModelError("", "Hatalı giriş");
                return Json(new { message = "Verilerde hata var." });
            }
        }
    }
}
