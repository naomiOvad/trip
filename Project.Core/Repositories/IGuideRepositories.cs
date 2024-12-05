using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectNaomi.Core.model;

namespace Project.Core.Repositories
{
    public interface IGuideRepositories
    {
        public List<Guide> GetGuides();
        public Guide GetGuide(string id);
        public Guide AddGuide(Guide guide);

        public void UpdateGuide(string id, Guide guide);

        public void changeGuideStatus(string id);

    }
}
