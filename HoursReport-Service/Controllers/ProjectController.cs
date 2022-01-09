using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HoursReport_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly HoursReportingContext m_context;
        public ProjectController(HoursReportingContext context)
        {
            m_context = context;
        }
        // GET: api/<ProjectController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            { 
                return Ok(m_context.Project);
               }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(m_context.Project.FirstOrDefault(c => c.ProjectId == id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // POST api/<ProjectController>
        [HttpPost]
        public async Task<IActionResult>  Post([FromBody] Project item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                m_context.Project.Add(item);
                await m_context.SaveChangesAsync();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Project item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                m_context.Project.Update(item);
                await m_context.SaveChangesAsync();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Project Project = await m_context.Project.FindAsync(id);
                if (Project == null)
                {
                    return NotFound();
                }

                m_context.Project.Remove(Project);
                await m_context.SaveChangesAsync();

                return StatusCode(Convert.ToInt32(HttpStatusCode.NoContent));
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex);
    }
}
    }
}
