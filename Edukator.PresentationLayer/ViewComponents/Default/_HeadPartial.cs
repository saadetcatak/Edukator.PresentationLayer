using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent 
    { 
        public IViewComponentResult Invoke() 
        
        { 
            return View();
        }

    }

 }

