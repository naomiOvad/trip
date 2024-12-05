using Microsoft.Win32;
using Project.Core.Repositories;
using projectNaomi.Core.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repoitories
{
    public class RegisterRepositories:IRegisterRepositories
    {


        private DataContex _context;
        public RegisterRepositories(DataContex contex)
        {
            _context = contex;
        }
        public List<Registers> GetRegister()
        {
            return _context.registers.ToList();
        }
        public Registers GetRegister(string id)
        {

            var index = _context.registers.ToList().FindIndex(e => e.id.Equals(id));
            //נשלח את התז רק לאחר בדיקה בסרביס שזה לא שווה מינוס אחד
            return _context.registers.ToList()[index];


        }
        public Registers AddRegisters(Registers registers)
        {
            _context.registers.Add(registers);
            return registers;
        }
        public void UpdateRegisters(string id, Registers registers)
        {
            var index = _context.registers.ToList().FindIndex(e => e.id.Equals(id));
            _context.registers.ToList()[index].id = registers.id;
            _context.registers.ToList()[index].age = registers.age;
            _context.registers.ToList()[index].name = registers.name;
            _context.registers.ToList()[index].codeTrip = registers.codeTrip;
        }
        public void changeRegistersStatus(string id)
        {
            var index = _context.registers.ToList().FindIndex(e => e.id.Equals(id));
            _context.registers.ToList()[index].status = false;
        }










    }
}
