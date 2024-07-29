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
            foreach (var car in carManager.GetCarsDetails().Data)
            {
                //Console.WriteLine(car.  /*car.ModelYear+" "+car.Description*/);
                Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName + " " + car.DailyPrice);
            }
            RentalManager rentalManager = new RentalManager();

            Rental rental = new Rental()
            {
                Id = 1,
                CardId = 2,
                CustomerId = 3,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Now,
            };
            //rentalManager.Add(rental);
            //foreach (var rental in rentalManager.GetAll().Data)
            //{
            //    rental.Id = 1;
            //}
        }
    }
}
