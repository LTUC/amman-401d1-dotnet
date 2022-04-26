using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolDemo.Data;
using SchoolDemo.Models;
using SchoolDemo.Models.Interfaces;

namespace SchoolDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologiesController : ControllerBase
    {
        private readonly ITechnology _techno;

        public TechnologiesController(ITechnology techno)
        {
            _techno = techno;
        }

        // GET: api/Technologies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Technology>>> GetTechnologies()
        {
            var technologies = await _techno.GetTechnologies();

            return Ok(technologies);
        }

       
    }
}
