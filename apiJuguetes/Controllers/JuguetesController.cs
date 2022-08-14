using apiJuguetes.Context;
using apiJuguetes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiJuguetes.Controllers
{
    //[Route("api/[Juguetes]")]
    [ApiController]
    public class JuguetesController : ControllerBase
    {
        private readonly AppJuguetesContext context;
        public JuguetesController(AppJuguetesContext _context)
        {
            this.context = _context;
        }

        //GET api/<controller>
        [HttpGet]
        [Route("Juguetes/Get")]
        public ActionResult Get()
        {
            try
            {
                
                return Ok(context.juguetes.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/<controllers>/7
        [HttpGet]
        [Route("Juguetes/Get/{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var juguete = context.juguetes.FirstOrDefault(x => x.Id == id);
                return Ok(juguete);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/<controller>
        [HttpPost]
        [Route("Juguetes/Post")]
        public ActionResult Post([FromBody]Juguetes juguete)
        {
            try
            {
                context.juguetes.Add(juguete);
                context.SaveChanges();
                var last = context.juguetes.OrderByDescending(i=> i.Id).FirstOrDefault().Id;
                return Ok(last);
                //return CreatedAtRoute("Get", new { id = juguete.Id }, juguete);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<controller>/7
        [HttpPut("id")]
        [Route("Juguetes/Put/{id}")]
        public ActionResult Put(int id, [FromBody] Juguetes juguete)
        {
            try
            {
                if (juguete.Id == id)
                {
                    context.Entry(juguete).State = EntityState.Modified;
                    context.SaveChanges();
                    return Ok(id);
                    //return CreatedAtRoute("GetJuguete", new { id = juguete.Id }, juguete);
                }
                else
                {
                    return BadRequest();
                }
                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<controller>/7
        [HttpDelete("id")]
        [Route("Juguetes/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var juguete = context.juguetes.FirstOrDefault(x => x.Id == id);
                if (juguete != null)
                {
                    context.juguetes.Remove(juguete);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
       
    }
}
