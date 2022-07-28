using Microsoft.AspNetCore.Mvc;
using webAPiINZ.Data;
using webAPiINZ.Model;

namespace webAPiINZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly InżContext _context;

        public LoginController(InżContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<Guid>> Login(User user)
        {          
            var UserInfo = _context.Users.Where(c => c.Username == user.Username && c.Password == user.Password).FirstOrDefault();
            if (UserInfo == null)
                return BadRequest();

            return Ok(UserInfo.Id);
        }

        [HttpPost]
        [Route("Register")]        
        public async Task<ActionResult<bool>> Register(User user)
        {
            var UserInfo = _context.Users.Where(c => c.Username == user.Username && c.Password == user.Password).Any();
            if(UserInfo == true)
                return BadRequest();
            User newUser = new User()
            {
                Username = user.Username,
                Password = user.Password,
            };
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();  
            return Ok(true);
        }

    }
}
