using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TomKamphuisOnSpaAndAngular.Models.Slides;
using TomKamphuisOnSpaAndAngular.Repositories.Interfaces;

namespace TomKamphuisOnSpaAndAngular.Controllers
{
    public class SlideController : ApiController
    {
        private readonly ISlideRepository _slideRepository;

        public SlideController(ISlideRepository slideRepository)
        {
            _slideRepository = slideRepository;
        }

        public async Task<IHttpActionResult> Get(string title)
        {
            SlideModel model = await this.GetSlideAsync(title);

            if(model == null)
            {
                return this.NotFound();
            }

            return this.Ok(model);
        }

        private async Task<SlideModel> GetSlideAsync(string pageTitle)
        {
            return await _slideRepository.GetSlideByPageTitleAsync(pageTitle);
        }
    }
}