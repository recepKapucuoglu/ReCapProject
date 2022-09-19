using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac;
using Core.Aspect.Autofac.Caching;
using Core.Aspect.Autofac.Performance;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Business;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;

        public CarManager(ICarDal carDal, IBrandService brandService)  //constructor.-interface ile bir database seçim hakkı tanıdık
        {
            _carDal = carDal;
            _brandService = brandService;
        }
        //constructor.



        [CacheAspect] //key,value
        public IDataResult<List<Car>> getAll()
        {
            if (DateTime.Now.Hour == 19)

                return new ErrorDataResult<List<Car>>(_carDal.GetAll(), Messages.MaintenanceTime);
            else { return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.ProductAdded); }
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails()
               , Messages.MaintenanceTime);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new ErrorDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), Messages.MaintenanceTime);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {


            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id), Messages.MaintenanceTime);
        }
        [CacheRemoveAspect("ICarService.Get")]
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]   //ProductValidatoru kullanarak Add metunu dogrula .

        [PerformanceAspect(5)]

   
        public IResult Add(Car car)
        {
            var result = BusinessRules.Run(CheckIfCarLimitExceded(car.Id));
            if (result != null)
            { return result; }
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);


        }

        public IDataResult<List<CarDetailDto>> FindGetDailyPrice(int priceSelect)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<CarDetailDto>>(_carDal.FindGetDailyPrice(), Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(_carDal.FindGetDailyPrice(p => p.DailyPrice > priceSelect), Messages.ProductAdded);
            }
        }

        public IResult Update(Car car)
        {
            if (DateTime.Now.Hour == 20)
            {

                return new ErrorResult(Messages.MaintenanceTime);
            }

            else
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.ProductAdded);
            }

        }
        public IResult DeleteCar(Car car)
        {
            if (DateTime.Now.Hour == 20)
            {

                return new ErrorResult(Messages.MaintenanceTime);
            }

            else
            {
                _carDal.Delete(car);
                return new SuccessResult(Messages.ProductAdded);
            }

        }
        private IResult CheckIfCarLimitExceded(int carid)
        {
            var result = _carDal.GetAll();
            if (result.Count >21 )
            {
                return new ErrorResult(Messages.CarListCapacity);
            }
            else return new SuccessResult();
        }
    }
}
