using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardGetLast5CoursePartial:ViewComponent
    { 
        private readonly ICourseService _courseService;

        public _DashboardGetLast5CoursePartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        { var values = _courseService.TGetLast5Course();
            return View(values);
        }
    }
}
