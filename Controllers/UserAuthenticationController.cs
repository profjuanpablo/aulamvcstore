using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MovieStore.Models.DTO;
using MovieStore.Repositories.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MovieStore.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthenticationServices authService;

        public UserAuthenticationController(IUserAuthenticationServices authService)
        {

            this.authService = authService;
        }

        public async Task<IActionResult> Register()
        {
            var model = new RegistrationModel
            {
                Email = "admin@admin.com",
                UserName = "Admin",
                Name = "Juan",
                Password = "Admin@123",
                PasswordConfirm = "Admin@123",
                Role = "Admin"
            };
            var result = await authService.RegisterAsync(model);
            return Ok(result.Message);
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
             }
            var result = await authService.LoginAsync(model);
            if (result.StatusCode == 1)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["msg"] = "Não é possível Logar";
                return RedirectToAction(nameof(Login));
            }


        }

    }
}

