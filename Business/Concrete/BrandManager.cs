using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetAllById(int id)
        {
            return _brandDal.GetAll(p => p.Id == id);
        }
    }
}