using Core.DataAccess;
using Entities.Concrete; //entities katmanındaki cari referans verdik.
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car> // car ' ın operasyon sınıfı.
    {

        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> FindGetDailyPrice(Expression<Func<CarDetailDto, bool>> filter = null);

    }

}
