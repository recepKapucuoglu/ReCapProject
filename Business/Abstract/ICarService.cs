using Core.Utilities;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService  
    {
        IDataResult<List<Car>> getAll();  //CAR CLASINA ULAŞABİLMEK İÇİN ENTİTİESDEN REFERANS ALDIK.

        IDataResult<List<Car>> GetCarsByBrandId(int id);

        IDataResult<List<Car>> GetCarsByColorId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();
        

        IDataResult<List<CarDetailDto>> FindGetDailyPrice(int id);
        IResult Add(Car car);

        IResult Update(Car car);

        IResult DeleteCar(Car car);


    }
}
