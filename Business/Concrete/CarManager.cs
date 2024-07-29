using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            return _carDal.GetAll(p => p.Id == id);
        }

        public List<Car> GetByDailyPrice(decimal dailyPriceMin, decimal dailyPriceMax)
        {
            return _carDal.GetAll(p=>p.DailyPrice>=dailyPriceMin && p.DailyPrice<=dailyPriceMax);
        }

        public List<Car> GetByDailyPrice(decimal dailyPriceMin)
        {
            return _carDal.GetAll(p => p.DailyPrice >= dailyPriceMin);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p=>p.BrandId==brandId);
        }

        public List<Car> GetCarsByCarNameLenght(int carNameLenght)
        {
            return _carDal.GetAll(p=>p.CarName.Length>=carNameLenght);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p=>p.ColorId==colorId);
        }

        public List<CarDetailDto> GetCarsDetail()
        {
            return _carDal.GetCarDetails();
        }
    }
}