using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        { 
            var values = _aboutService.TGetList();
            return View(values);
        }
    }
}
