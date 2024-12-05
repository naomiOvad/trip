using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectNaomi.Core.model;

namespace Project.Core.Repositories
{
    public interface IRegisterRepositories
    {
        public List<Registers> GetRegister();
        public Registers GetRegister(string id);
        public Registers AddRegisters(Registers registers);
        public void UpdateRegisters(string id, Registers registers);
        public void changeRegistersStatus(string id);
    }
}
