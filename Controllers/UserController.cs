
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using school.Models;

namespace school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public UserController(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpPost]
        [Route("Register")]
        //POST : api/User/Register
        public async Task<Object> PostUser(UserModel model) {
            var user = new User() {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName
            };
            try
            {
                var result = await _userManager.CreateAsync(user,model.Password);
                return Ok(result);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
