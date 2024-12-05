using Microsoft.AspNetCore.Mvc;
using Project.Core.Service;
using projectNaomi.Core.model;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectNaomi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {

        ITripService _tripService;
        public TripController(ITripService tripService)
        {
            _tripService = tripService;
        }

        // GET: api/<TripController>
        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            return _tripService.GetTrip();
        }

        // GET api/<TripController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string code)
        {
           Trip trip=_tripService.GetTrip(code);
            if (trip != null) 
                return Ok(trip);
            return Ok();
        }

        // POST api/<TripController>
        [HttpPost]
        public Trip Post([FromBody] Trip trip)
        {
           return _tripService.AddTrip(trip);
        }

        // PUT api/<TripController>/5
        [HttpPut("{id}")]
        public void Put(string code, [FromBody] Trip trip)
        {
          
           _tripService.UpdateTrip(code,trip);
        }

        // DELETE api/<TripController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string code)
        {
           if(_tripService.delete(code))    
                return Ok(code);
           return NotFound();
        }
    }
}
