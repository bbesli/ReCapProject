using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = (from c in context.Cars
                              join r in context.Rentals
                              on c.CarId equals r.CarId
                              select new RentalDetailDto
                              {
                                  CarId = c.CarId,
                                  RentDate = r.RentDate,
                                  ReturnDate = r.ReturnDate,
                              }).ToList();

                return result;
            }
        }
    }
}
