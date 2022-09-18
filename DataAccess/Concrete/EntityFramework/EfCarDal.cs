using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarContext>,ICarDal
    {
        public List<CarDetailDto> FindGetDailyPrice(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 CarName=c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,

                             };
                return filter == null
                                ?  result.ToList()           //eğer null ise= veri tabanındaki produc'ı listeye çevir ver. 
                                   : result.Where(filter).ToList();


            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,

                             };

                return result.ToList();


            }
        }
    }

    
        

     
    }

