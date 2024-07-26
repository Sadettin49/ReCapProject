using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetAllById(int id)
        {
            return _colorDal.GetAll(p => p.Id == id);
        }
    }
}