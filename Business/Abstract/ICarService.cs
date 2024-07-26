using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetByDailyPrice(decimal dailyPriceMin,decimal dailyPriceMax);
        List<Car> GetByDailyPrice(decimal dailyPriceMin);
        List<Car> GetCarsByCarNameLenght(int carNameLenght);
        List<CarDetailDto> GetCarsDetail(int carNameLenght);
    }
}
