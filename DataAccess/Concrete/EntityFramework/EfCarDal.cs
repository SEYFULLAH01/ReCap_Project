using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntitiyRepositoryBase<ReCapProjectDbContext, Car>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos(int id)
        {
            using (ReCapProjectDbContext capProjectDbContext = new ReCapProjectDbContext())
            {
                var result = from c in capProjectDbContext.Cars
                             join b in capProjectDbContext.Brands
                             on c.CarId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = b.BrandId,
                                 ColorId = c.ColorId,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 CarName = c.CarName
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }
    }
}
