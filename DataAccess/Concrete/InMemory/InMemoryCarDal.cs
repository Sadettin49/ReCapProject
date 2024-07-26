using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=1000,Description="güzel araba al bunu"},
                new Car { Id = 2,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=100,Description="Sarmaz kardeş alma"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car productToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
        }
    }
}