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
                var result = (from rnt in context.Rentals
                              join c in context.Cars on rnt.CarId equals c.CarId
                              join cst in context.Customers on rnt.CustomerId equals cst.UserId
                              select new RentalDetailDto
                              {
                                  Id = rnt.Id,
                                  CarId = c.CarId,
                                  CustomerId = cst.UserId,
                                  RentDate = rnt.RentDate,
                                  ReturnDate = rnt.ReturnDate,
                                  Delivered = rnt.Delivered
                              }).ToList();

                return result;
            }
        }
    }
}
