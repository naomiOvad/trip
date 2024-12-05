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
    public class GuideRepositories:IGuideRepositories
    {
        private DataContex _context;
        public GuideRepositories(DataContex contex)
        {
            _context = contex;
        }

        public List<Guide> GetGuides()
        {
            return _context.guides.ToList();
        }
        public Guide GetGuide(string id) {

            var index = _context.guides.ToList().FindIndex(e => e.Id.Equals(id));
            //נשלח את התז רק לאחר בדיקה בסרביס שזה לא שווה מינוס אחד
            return _context.guides.ToList()[index];
            

        }
        public Guide AddGuide(Guide guide)
        {
            _context.guides.Add(guide);
            return guide;
        }
        public void UpdateGuide(string id,Guide guide)
        {
            var index = _context.guides.ToList().FindIndex(e => e.Id.Equals(id));
            _context.guides.ToList()[index].Id = guide.Id;
            _context.guides.ToList()[index].Name = guide.Name;
        }
        public void changeGuideStatus(string id)
        {
            var index = _context.guides.ToList().FindIndex(e => e.Id.Equals(id));
            _context.guides.ToList()[index].status = false;
           

        }
    }
}
