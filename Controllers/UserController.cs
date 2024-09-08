using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using social_media_api.Data;
using social_media_api.Entities;


namespace social_media_api.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        [AllowAnonymous]
        [HttpGet]
        async public Task<ActionResult<IEnumerable<User>>> GetUsers() 
        {
            var users = await _dataContext.Users.ToListAsync();

            return users;
        }

        [Authorize]
        [HttpGet("{id}")]
        async public Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _dataContext.Users.FindAsync(id);

            return user;
        }
        
    }
}
