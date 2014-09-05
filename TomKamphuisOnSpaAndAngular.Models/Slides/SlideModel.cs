using System.Collections.Generic;

namespace TomKamphuisOnSpaAndAngular.Models.Slides
{
    public class SlideModel
    {
        public Slide CurrentSlide { get; set; }
        public IList<Slide> Slides { get; set; }
    }
}