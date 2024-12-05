using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using Project.Core.Service;
using projectNaomi.Core.model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectNaomi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RegisterController : ControllerBase
    {
        IRegistersService _registersService;

        public RegisterController(IRegistersService registersService)
        {
            _registersService= registersService;
        }

        // GET: api/<RegisterController>
        [HttpGet]
        public IEnumerable<Registers> Get()
        {
            return _registersService.GetRegister();
        }

        // GET api/<RegisterController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            Registers registers = _registersService.GetRegister(id);
            if(registers == null) 
                return NotFound();
            return Ok(registers);
        }
        //add new register
        // POST api/<RegisterController>
        [HttpPost]
        public Registers Post([FromBody] Registers register)
        {
            return _registersService.AddRegisters(register);
        }

        // PUT api/<RegisterController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Registers register)
        {
           
            _registersService.UpdateRegisters(id, register);
           

        }

        // DELETE api/<RegisterController>/5
        [HttpDelete("{id}")]
        public ActionResult changeStatus(string id)
        {
            if(_registersService.changeRegistersStatus(id))    
                return Ok(id);
            return NotFound();
               
        }
    }
}
