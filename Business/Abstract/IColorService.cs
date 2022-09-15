using Core.Untilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    internal interface IColorService
    {
        IResult Add(Color color);

        IDataResult<List<Color>> GetColorId(int id);


      
    }
}
