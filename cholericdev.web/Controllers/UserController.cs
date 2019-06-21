using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cholericdev.data;
using cholericdev.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cholericdev.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _repository;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserRepository repository, ILogger<UserController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            try
            {
                return Ok(_repository.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Users: {ex}");
                return BadRequest("Failed to get Users");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = _repository.GetById(id);
            return user;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}