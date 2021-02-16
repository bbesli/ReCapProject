using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetailsTest(); //worked fine
            //CarAddingTest(); //worked fine
            //CarDeletingTest(); //worked fine
            //CarUpdatingTest(); //worked fine

            //RentalDetailsTest(); // worked fine

            //AddRental(); //worked fine



        }

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = DateTime.Now
            });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId + "---" + rental.RentDate + " ---- " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarUpdatingTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 2, BrandId = 4, ColorId = 3, DailyPrice = 150, CarManufacturedYear = new DateTime(2019, 01, 01) });
        }

        private static void CarDeletingTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 1 });
        }

        private static void CarAddingTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 3, ColorId = 1, CarManufacturedYear = new DateTime(2020, 01, 01), DailyPrice = 355 });
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }
        }
    }
}
