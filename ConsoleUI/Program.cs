using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsDetail())
            {
                //Console.WriteLine(car.  /*car.ModelYear+" "+car.Description*/);
                Console.WriteLine(car.BrandName+" "+car.CarName+" "+car.ColorName+" "+car.DailyPrice);
            }
            
        }
    }
}
