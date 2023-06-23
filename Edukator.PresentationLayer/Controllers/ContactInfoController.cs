using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class ContactInfoController : Controller
    {
        private readonly IContactInfoService _contactInfoService;

        public ContactInfoController(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public IActionResult Index()
        {
            var values =_contactInfoService.TGetList();
            return View(values);
        }

        public IActionResult DeleteContactInfo(int id)
        {
            var values = _contactInfoService.TGetByID(id);
            _contactInfoService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateContactInfo(int id)
        {
            var values = _contactInfoService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateContactInfo(ContactInfo p)
        {

            _contactInfoService.TUpdate(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddContactInfo(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContactInfo(ContactInfo p)
        {
            _contactInfoService.TInsert(p);
            return RedirectToAction("Index");
        }

    }
}
