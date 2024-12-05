using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Repositories;
using Project.Core.Service;
using projectNaomi.Core.model;



namespace Project.Service
{
    public class RegistersService: IRegistersService
    {
        private IRegisterRepositories _registerRepositories;
        public RegistersService(IRegisterRepositories register) {
            _registerRepositories = register;
        }

        public List<Registers> GetRegister()
        {
           return _registerRepositories.GetRegister();
        }
        public Registers GetRegister(string id)
        {
            if (IsExist(id))
                return _registerRepositories.GetRegister(id);
            return null;
        }
        public Registers AddRegisters(Registers registers)
        {

            if (IsExist(registers.id))
            {
                UpdateRegisters(registers.id, registers);
                return registers;
            }
            _registerRepositories.AddRegisters(registers);
            return registers;


        }
        public void UpdateRegisters(string id, Registers registers)
        {
            if (IsExist(id))
                _registerRepositories.UpdateRegisters(id, registers);
            else
                _registerRepositories.AddRegisters(registers);
        }
        public bool changeRegistersStatus(string id)
        {
            if (IsExist(id))
            {
               _registerRepositories.changeRegistersStatus(id);
                return true;
            }
            return false;
               
        }

        public bool IsExist(string id)
        {
            var register = _registerRepositories.GetRegister();
            var exist = register.Any(guide => guide.id == id);
            return exist;
        }

    }


}
