using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomKamphuisOnSpaAndAngular.Models.Slides;
using TomKamphuisOnSpaAndAngular.Repositories.Interfaces;

namespace TomKamphuisOnSpaAndAngular.Repositories.AbstractRepositories
{
    public class SlideRepository : ISlideRepository
    {
        private SlideModel _model;

        public SlideRepository()
        {
            if(_model == null)
            {
                _model.Slides = new List<Slide>();

                _model.Slides.Add(new Slide
                {
                    PageTitle = "Profile",
                    MenuPicto = "&#x43;",
                    SlideContent = "/Views/Portfolio/ProfilePartial.html"
                });

                _model.Slides.Add(new Slide
                {
                    PageTitle = "Resume",
                    MenuPicto = "&#x3a;",
                    SlideContent = "/Views/Portfolio/ResumePartial.html"
                });

                _model.Slides.Add(new Slide
                {
                    PageTitle = "Portfolio",
                    MenuPicto = "&#x38;",
                    SlideContent = "/Views/Portfolio/PortfolioPartial.html"
                });

                _model.Slides.Add(new Slide
                {
                    PageTitle = "Contact",
                    MenuPicto = "&#x21;",
                    SlideContent = "/Views/Portfolio/ContactPartial.html"
                });
            }
        }

        public async Task<SlideModel> GetSlideByPageTitleAsync(string title)
        {
            return await Task.Run(() => this.GetSlideModelWithCurrentSlide(title));
        }

        private SlideModel GetSlideModelWithCurrentSlide(string title)
        {
            _model.CurrentSlide = _model.Slides.FirstOrDefault(s => s.PageTitle.ToLower() == title.ToLower());

            return _model;
        }
    }
}