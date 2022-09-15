using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac;
using Core.Untilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
                _brandDal = brandDal;   
        }




        [ValidationAspect(typeof(BrandValidator))]   //ProductValidatoru kullanarak Add metunu dogrula .

        public IResult AddToBrand(Brand brand)
        {
            
        
            
                _brandDal.Add(brand); 
                return new SuccessResult(Messages.ProductAdded);
            
        }


        public IDataResult<List<Brand>> GetAllBrand()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Brand>>(_brandDal.GetAll(),Messages.MaintenanceTime);
            }
            else { return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.ProductAdded); }
        }
    }
}
