using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        // POST: api/Projects
        [HttpPost]
        public async Task<IActionResult> CreateProject(long id)
        {
            return NoContent();
        }

        // GET: api/Projects
        [HttpGet("")]
        public async Task<IActionResult> GetProjects(int page, int pageSize)
        {
            return NoContent();
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(long id)
        {
            return NoContent();
        }

        // PUT: api/Projects/5 might need to be a patch?
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(long id)
        {
            return NoContent();
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(long id)
        {
            return NoContent();
        }
    }
}