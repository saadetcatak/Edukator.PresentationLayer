using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class MapManager : IMapService
    {
        private readonly IMapService _mapService;
        public void TDelete(Map t)
        {
            _mapService.TDelete(t);
        }

        public Map TGetByID(int id)
        {
            return _mapService.TGetByID(id);
        }

        public List<Map> TGetList()
        {
            return _mapService.TGetList();
        }

        public void TInsert(Map t)
        {
            _mapService.TInsert(t);
        }

        public void TUpdate(Map t)
        {
           _mapService.TUpdate(t);
        }
    }
}
