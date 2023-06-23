using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class MapController : Controller
    {
        private readonly IMapService _mapService;

        public MapController(IMapService mapService)
        {
            _mapService = mapService;
        }

        public IActionResult Index()
        {
            var values =_mapService.TGetList();
            return View(values);
        }
        public IActionResult DeleteMap(int id)
        {
            var values=_mapService.TGetByID(id);
            _mapService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateMap(int id)
        {
            var values = _mapService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateMap(Map p)
        {
            _mapService.TUpdate(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddMap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMap(Map p)
        {
            _mapService.TInsert(p);
            return RedirectToAction("Index");
        }
    }
}
