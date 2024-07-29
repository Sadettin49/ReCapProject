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
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarsDetails().Data)
            //{
            //    //Console.WriteLine(car.  /*car.ModelYear+" "+car.Description*/);
            //    Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName + " " + car.DailyPrice);
            //}
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental = new Rental { CardId=1, ReturnDate = DateTime.Now , RentDate= DateTime.Now};    
            
            rentalManager.Add(rental);

            foreach (var rentals in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rentals.CardId+" "+ rentals.ReturnDate+" "+rentals.RentDate);
            }
        }
    }
}
