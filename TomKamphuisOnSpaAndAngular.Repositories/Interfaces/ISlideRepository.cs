using System.Threading.Tasks;
using TomKamphuisOnSpaAndAngular.Models.Slides;

namespace TomKamphuisOnSpaAndAngular.Repositories.Interfaces
{
    public interface ISlideRepository
    {
        Task<SlideModel> GetSlideByPageTitleAsync(string title);
    }
}