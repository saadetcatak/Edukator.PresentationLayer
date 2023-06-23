using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _TeacherPartial:ViewComponent   
    {
        private readonly ITeacherService _teacherService;

        public _TeacherPartial(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _teacherService.TGetList();
            return View(values);
        }
    }
}
