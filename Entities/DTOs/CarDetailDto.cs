using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }

        public string BrandCar { get; set; }
        public string ColorCar { get; set; }

        public int ModelYear { get; set; }

        public decimal DailyPrice { get; set; }

        public string Description { get; set; }
    }
}
