using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ISubscriberService _subscriberService;

        public DefaultController(ISubscriberService subscriberService)
        {
            _subscriberService = subscriberService;
        }

        public IActionResult Index()
        {
            return View();

        }
        [HttpGet]
        public PartialViewResult AddSubscriber()
        {
            return PartialView();
        }
        [HttpPost]
         public IActionResult AddSubscriber(Subscriber subscriber)
        { 
            _subscriberService.TInsert(subscriber);
            return RedirectToAction("Index"); 
        }




    }
}
