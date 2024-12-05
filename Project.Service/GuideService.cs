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
    public class GuideService:IGuideService
    {
        private IGuideRepositories _guideRepository;

        public GuideService(IGuideRepositories guideRepository)
        {
           _guideRepository = guideRepository;
        }

        public List<Guide> GetGuides()
        {
            return _guideRepository.GetGuides();
        }
        public Guide GetGuide(string id)
        {
          if(IsExist(id))
                return _guideRepository.GetGuide(id);
          return null;
        }
        public Guide AddGuide(Guide guide)
        {
            if (IsExist(guide.Id))
            {
                UpdateGuide(guide.Id, guide);
                return guide;
            }
            _guideRepository.AddGuide(guide);
            return guide;
           
        }
        public void UpdateGuide(string id, Guide guide)
        {
            if (IsExist(id))
                _guideRepository.UpdateGuide(id, guide);
            else
                _guideRepository.AddGuide(guide);
        }
        public bool changeGuideStatus(string id)
        {
           if(IsExist(id))
           {
              _guideRepository.changeGuideStatus(id); 
                return true;
           }
            return false;
        }
        public bool IsExist(string id)
        {
            var guides = _guideRepository.GetGuides();
            var exist = guides.Any(guide => guide.Id == id);
            return exist;
        }

    }
}
