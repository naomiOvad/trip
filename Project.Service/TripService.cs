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
    public class TripService: ITripService
    {
        private ITripRepositories _tripRepositories;
        public TripService(ITripRepositories tripRepositories)
        {
            _tripRepositories = tripRepositories;      
        }

        public IEnumerable<Trip> GetTrip()
        {
          return _tripRepositories.GetTrip();
        }
        public Trip GetTrip(string code)
        {
            if (IsExist(code))
                return _tripRepositories.GetTrip(code);
            return null;
        }
        public Trip AddTrip(Trip trip)
        {
            if (IsExist(trip.code))
            {
                UpdateTrip(trip.code, trip);
                return trip;
            }
            _tripRepositories.AddTrip(trip);
            return trip;
        }
        public void UpdateTrip(string code, Trip trip)
        {
            if (IsExist(code))
                _tripRepositories.UpdateTrip(code, trip);
            else
                _tripRepositories.AddTrip(trip);

        }
        public bool delete(string code)
        {
            if (IsExist(code))
            {
                _tripRepositories.delete(code);  
                return true;
            }
            return false; 
        }
        public bool IsExist(string code)
        {
            var guides = _tripRepositories.GetTrip();
            var exist = guides.Any(guide => guide.code == code);
            return exist;
        }




    }
}
