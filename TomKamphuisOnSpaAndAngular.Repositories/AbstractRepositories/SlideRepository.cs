using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomKamphuisOnSpaAndAngular.Models.Slides;
using TomKamphuisOnSpaAndAngular.Repositories.Interfaces;

namespace TomKamphuisOnSpaAndAngular.Repositories.AbstractRepositories
{
    public class SlideRepository : ISlideRepository
    {
        private IList<SlideModel> _models;

        public SlideRepository()
        {
            if(_models == null)
            {
                _models = new List<SlideModel>();

                _models.Add(new SlideModel
                {
                    PageTitle = "Slide1",
                    MenuTitle = "Slide1",
                    SlideContent = "<p>Dit is een test!</p>"
                });

                _models.Add(new SlideModel
                {
                    PageTitle = "Slide2",
                    MenuTitle = "Slide2",
                    SlideContent = "<p>Dit is een tweede test!</p>"
                });

                _models.Add(new SlideModel
                {
                    PageTitle = "Slide3",
                    MenuTitle = "Slide3",
                    SlideContent = "<p>Dit is een derde test!</p>"
                });

                _models.Add(new SlideModel
                {
                    PageTitle = "Slide4",
                    MenuTitle = "Slide4",
                    SlideContent = "<p>Dit is een vierde test!</p>"
                });
            }
        }

        public async Task<SlideModel> GetSlideByPageTitleAsync(string title)
        {
            return await Task.Run(() => _models.FirstOrDefault(s => s.PageTitle.ToLower() == title.ToLower()));
        }
    }
}