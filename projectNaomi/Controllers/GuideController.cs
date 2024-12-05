using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Core.Service;
using Project.Service;
using projectNaomi.Core.model;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectNaomi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideController : ControllerBase
    {
        private IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        // GET: api/<GuideController>
        [HttpGet]
        public IEnumerable<Guide> Get()
        {
            return _guideService.GetGuides();
        }

        // GET api/<GuideController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            Guide guide = _guideService.GetGuide(id);
            if (guide == null)
                return NotFound();
            return Ok(guide);
        }

        // POST api/<GuideController>
        [HttpPost]
        //add
        public Guide Post([FromBody] Guide guide)
        {
           return _guideService.AddGuide(guide);
       
        }

        // PUT api/<GuideController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Guide guide)
        {
            _guideService.UpdateGuide(id, guide);
        }

        // DELETE api/<GuideController>/5
        [HttpDelete("{id}")]
        public ActionResult changeStatus(string id)
        {

         if(_guideService.changeGuideStatus(id))
                return Ok(id);
         return NotFound();
        }
    }
}
