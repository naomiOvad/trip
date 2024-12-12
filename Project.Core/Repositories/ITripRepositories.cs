using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectNaomi.Core.model;

namespace Project.Core.Repositories
{
    public interface ITripRepositories
    {
        public IEnumerable<Trip> GetTrip();
        public Trip GetTrip(string code);
        public Trip AddTrip(Trip trip);
        public void UpdateTrip(string code, Trip trip);
        public void delete(string code);


    }
}
