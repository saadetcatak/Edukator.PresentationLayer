using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Edukator.PresentationLayer.ViewComponents.Course
{
    public class _AllCoursesPartial:ViewComponent
    {
        private readonly ICourseService _courseService;

        public _AllCoursesPartial(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetCoursesWithCategories();
            return View(values);
        }
    }
}
