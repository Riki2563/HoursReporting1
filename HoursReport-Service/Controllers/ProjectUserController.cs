using HoursReport_Service.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty ProjectUsers, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HoursReport_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectUserController : ControllerBase
    {
        private readonly HoursReportingContext m_context;
        public ProjectUserController(HoursReportingContext context)
        {
            m_context = context;
        }
        // GET: api/<ProjectUserController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            { 
                return Ok(m_context.ProjectUser);
               }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET api/<ProjectUserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(m_context.ProjectUser.FirstOrDefault(c => c.ProjectUserId == id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET api/<ProjectUserController>/5
     
        [Route("GetProjectsByUser/{userId}")]
        [HttpGet]
        public IActionResult GetProjectsByUser(int userId)
        {
            try
            {
                var projects = m_context.ProjectUser.Where(u=> u.UserId ==userId).Join(m_context.Project, pu => pu.ProjectId, p => p.ProjectId, (pu, p) => new { pu, p }).Select(m => new {
                    m.pu.ProjectId,
                    m.p.ProjectName
                           });
                return Ok(projects);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        // POST api/<ProjectUserController>
        [HttpPost]
        public async Task<IActionResult>  Post([FromBody] ProjectUser item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                m_context.ProjectUser.Add(item);
                await m_context.SaveChangesAsync();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // PUT api/<ProjectUserController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProjectUser item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                m_context.ProjectUser.Update(item);
                await m_context.SaveChangesAsync();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // DELETE api/<ProjectUserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                ProjectUser ProjectUser = await m_context.ProjectUser.FindAsync(id);
                if (ProjectUser == null)
                {
                    return NotFound();
                }

                m_context.ProjectUser.Remove(ProjectUser);
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
