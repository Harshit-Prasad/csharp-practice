using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using social_media_api.Data;
using social_media_api.Entities;


namespace social_media_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        [HttpGet]
        async public Task<ActionResult<IEnumerable<User>>> GetUsers() 
        {
            var users = await _dataContext.Users.ToListAsync();

            return users;
        }

        [HttpGet("{id}")]
        async public Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _dataContext.Users.FindAsync(id);

            return user;
        }



    }
}
