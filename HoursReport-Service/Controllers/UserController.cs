using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public class UserController : ControllerBase
    {
        private readonly HoursReportingContext m_context;
        public UserController(HoursReportingContext context)
        {
            m_context = context;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            { 
                return Ok(m_context.User);
               }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [Route("Login")]
        [HttpPost]

        public IActionResult Login([FromBody] string password )
        {
            try
            {

                var User = m_context.User.FirstOrDefault(u =>  u.Password == password);
                return Ok(User);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(m_context.User.FirstOrDefault(c => c.UserId == id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult>  Post([FromBody] User item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                m_context.User.Add(item);
                await m_context.SaveChangesAsync();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] User item)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                m_context.User.Update(item);
                await m_context.SaveChangesAsync();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                User User = await m_context.User.FindAsync(id);
                if (User == null)
                {
                    return NotFound();
                }

                m_context.User.Remove(User);
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
