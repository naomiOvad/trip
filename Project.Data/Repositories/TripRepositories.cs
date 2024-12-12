using Microsoft.EntityFrameworkCore;
using Project.Core.Repositories;
using projectNaomi.Core.model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repoitories
{
    public class TripRepositories:ITripRepositories
    {



        private DataContex _context;
        public TripRepositories(DataContex contex)
        {
            _context = contex;
        }
        public IEnumerable<Trip> GetTrip()
        {
            return _context.trips.Include(g=>g.guide).Include(r=>r.registers);
        }
        public Trip GetTrip(string code)
        {

            var index = _context.trips.Include(g => g.guide).Include(r=>r.registers).ToList().FindIndex(e => e.code.Equals(code));
            //נשלח את התז רק לאחר בדיקה בסרביס שזה לא שווה מינוס אחד
            return _context.trips.ToList()[index];


        }
        public Trip AddTrip(Trip trip)
        {
            _context.trips.Add(trip);
            _context.SaveChanges();
            return trip;
        }
        public void UpdateTrip(string code, Trip trip)
        {
            var index = _context.trips.ToList().FindIndex(e => e.code.Equals(code));
            _context.trips.ToList()[index].code = trip.code;
            _context.trips.ToList()[index].date = trip.date;
            _context.trips.ToList()[index].location = trip.location;
            _context.trips.ToList()[index].numRegisters = trip.numRegisters;
            _context.trips.ToList()[index].idGuide = trip.idGuide;
            _context.SaveChanges();

        }
        public void delete(string code)
        {
            var index = _context.trips.ToList().FindIndex(e => e.code.Equals(code));
            _context.trips.ToList().RemoveAt(index);
            _context.SaveChanges();
        }









    }
}
