using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class CourseRegisterManager : ICourseRegisterService
    {
        private readonly ICourseRegisterDal _courseRegisterDal;

        public CourseRegisterManager(ICourseRegisterDal courseRegisterDal)
        {
            _courseRegisterDal = courseRegisterDal;
        }

        public List<CourseRegister> TCourseRegisterListWithCourseByUser(int id)
        {
            return _courseRegisterDal.CourseRegisterListWithCourseByUser(id);
        }

        public List<CourseRegister> TCourseRegisterListWithCoursesAndUsers()
        {
            return _courseRegisterDal.CourseRegisterListWithCoursesAndUsers();
        }

        public void TDelete(CourseRegister t)
        {
            _courseRegisterDal.Delete(t);
        }

        public CourseRegister TGetByID(int id)
        {
            return _courseRegisterDal.GetByID(id);
        }

        public List<CourseRegister> TGetList()
        {
            return _courseRegisterDal.GetList();
        }

        public void TInsert(CourseRegister t)
        {
            _courseRegisterDal.Insert(t);
        }

        public void TUpdate(CourseRegister t)
        {
               _courseRegisterDal.Update(t);
        }
    }
}
