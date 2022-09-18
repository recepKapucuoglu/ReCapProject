using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {

//constructor yapısı.
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }



        public IResult Add(Color color)
        {
            if (DateTime.Now.Hour == 20)
            {
             return    new ErrorResult(Messages.MaintenanceTime);
            }
            else
            {  _colorDal.Add(color);  
                return new SuccessResult(Messages.ProductAdded);
            }
        }

        public IDataResult<List<Color>> GetColorId(int id)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Color>>(_colorDal.GetAll(c=>c.ColorId==id),Messages.MaintenanceTime);
            }
            else { return new ErrorDataResult<List<Color>>(_colorDal.GetAll(c => c.ColorId == id), Messages.ProductAdded); }
        }
    }
}
