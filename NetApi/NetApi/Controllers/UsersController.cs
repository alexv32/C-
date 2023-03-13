using Microsoft.AspNetCore.Mvc;
using NetApi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
      
        private readonly ApiContext _context;

        [HttpGet]
        public JsonResult GetUserDataAsync()
        {
            var result = _context.Users.ToList();

            return new JsonResult(Ok(null));
        }

        // GET api/<UsersController>/5
        [HttpGet("{reuslts}")]
        public JsonResult GetUserData()
        {
            return new JsonResult(Ok(null));
        }

        // POST api/<UsersController>
        [HttpPost]
        public JsonResult CreateNewUser()
        {
            return new JsonResult(Ok(null));
        }

        // PUT api/<UsersController>/5
        [HttpGet("{id}")]
        public JsonResult GetNewUser()
        {
            return new JsonResult(Ok(null));
        }

        // DELETE api/<UsersController>/5
        [HttpPut("{id}")]
        public JsonResult UpdateUserData(int id)
        {
            return new JsonResult(Ok(null));
        }
    }
}
