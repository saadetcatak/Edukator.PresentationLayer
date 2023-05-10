using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
