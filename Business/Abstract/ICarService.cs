using Core.Utilities.Results;
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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByCategoryId(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetByDailyPrice(decimal dailyPriceMin,decimal dailyPriceMax);
        IDataResult<List<Car>> GetByDailyPrice(decimal dailyPriceMin);
        IDataResult<List<Car>> GetCarsByCarNameLenght(int carNameLenght);
        IDataResult<List<CarDetailDto>> GetCarsDetails();
        IResult Add(Car car);
    }
}
