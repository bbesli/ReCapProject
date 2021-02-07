using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {

            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Daily price must be bigger than 0");
            }
            else
            {
                _carDal.Add(car);
                Console.WriteLine(car.CarManufacturedYear + "model car has been added to DateBase.");

            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("The id of "+car.CarId + " car has been deleted.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("The id of " + car.CarId + " car has been updated.");
        }
    }
}
