using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        //List<Car> _car;
        //public InMemoryCarDal()
        //{
        //    //_car = new List<Car> {
        //    //    new Car{Id=1 ,BrandId="BMW",ColorId=1,DailyPrice=500,ModelYear="2021", Description ="Dizel, otomatik"  },
        //    //    new Car{Id=2 ,BrandId="Mercedes",ColorId=2,DailyPrice=400,ModelYear="2020", Description ="Benzin, otomatik, sunroof"  },
        //    //    new Car{Id=3 ,BrandId="Volkswagen",ColorId=2,DailyPrice=250,ModelYear="2020", Description ="Dizel, manuel, ısıtmalı koltuk"  },
        //    //    new Car{Id=4 ,BrandId="Alfa Romeo",ColorId=3,DailyPrice=150,ModelYear="2018", Description ="Dizel, manuel, Apple Car Play desteği"  },
        //    //    new Car{Id=5 ,BrandId="Toyota",ColorId=1,DailyPrice=300,ModelYear="2020", Description ="Hybrid, otomatik, geri görüş ve park sensörü"  }
        //    //};
        //}
        //public void Add(Car car)
        //{
        //    _car.Add(car);
        //}

        //public void Delete(int carId)
        //{
        //    Car carToDelete = _car.SingleOrDefault(c => c.Id == carId);
        //    _car.Remove(carToDelete);
        //}

        //public List<Car> GetAll()
        //{
        //    return _car;
        //}

        //public List<Car> GetById(int id)
        //{
        //    return _car.Where(c => c.CarId == id).ToList();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.Id);
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.ModelYear = car.ModelYear;
        //    carToUpdate.Description = car.Description;
        //}
    }
}
