﻿using Core.Untilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAllBrand();

        IResult AddToBrand(Brand brand);


    }
}
