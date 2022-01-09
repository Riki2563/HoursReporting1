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
    public class HoursReportingController : ControllerBase
    {
        private readonly HoursReportingContext m_context;
        public HoursReportingController(HoursReportingContext context)
        {
            m_context = context;
        }
        // GET: api/<HoursReportingController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                var hoursReportingList = m_context.HoursReporting.Join(m_context.User, h => h.UserId, u => u.UserId, (h, u) => new { h, u })
                    .Join(m_context.Project, hu => hu.h.ProjectId, p => p.ProjectId, (hu, p) => new { hu, p }).Select(m => new {
                   m.hu.h.HoursReportingId,
                        m.hu.h.Date,
                        m.hu.h.BegingingTime,
                        m.hu.h.EndTime,
                        m.hu.u.UserName,
                        m.p.ProjectName
                        // other assignments
                    });
                return Ok(hoursReportingList);
               }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET api/<HoursReportingController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(m_context.HoursReporting.FirstOrDefault(c => c.HoursReportingId == id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // POST api/<HoursReportingController>
        [HttpPost]
        public async Task<IActionResult>  Post([FromBody] HoursReporting item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                m_context.HoursReporting.Add(item);
                await m_context.SaveChangesAsync();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // PUT api/<HoursReportingController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] HoursReporting item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                m_context.HoursReporting.Update(item);
                await m_context.SaveChangesAsync();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // DELETE api/<HoursReportingController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                HoursReporting hoursReporting = await m_context.HoursReporting.FindAsync(id);
                if (hoursReporting == null)
                {
                    return NotFound();
                }

                m_context.HoursReporting.Remove(hoursReporting);
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
