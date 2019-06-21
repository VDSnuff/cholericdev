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
    public class PostController : ControllerBase
    {

        private readonly IPostRepository _repository;
        private readonly ILogger<PostController> _logger;

        public PostController(IPostRepository repository, ILogger<PostController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Post>> Get()
        {
            try
            {
                return Ok(_repository.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Posts: {ex}");
                return BadRequest("Failed to get Posts");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Post> Get(int id)
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