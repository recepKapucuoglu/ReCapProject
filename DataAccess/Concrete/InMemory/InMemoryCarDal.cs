using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    {   
        List<Car> _cars; // _cars adında list<Car> tipinde degisken tanımladım.

        public InMemoryCarDal()//constructor.
        {
            _cars = new List<Car>()   // VERİLERİ OLUŞTURDUM.
            {
                new Car{CarId=1,ColorId=2,BrandId=3,ModelYear=2020,DailyPrice=250000},
                new Car{CarId=2,ColorId=2,BrandId=4,ModelYear=2022,DailyPrice=400000},
                new Car{CarId=3,ColorId=6,BrandId=5,ModelYear=2019,DailyPrice=750000},
                new Car{CarId=4,ColorId=7,BrandId=6,ModelYear=2019,DailyPrice=700000},
                new Car{CarId=5,ColorId=8,BrandId=7,ModelYear=2018,DailyPrice=950000},
                new Car{CarId=6,ColorId=9,BrandId=3,ModelYear=2017,DailyPrice=150000},

            };
            
        }

        public void Add(Car car)
        {
              _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar;
            deleteToCar = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(deleteToCar);
        }

        public List<CarDetailDto> FindGetDailyPrice()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> FindGetDailyPrice(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)  //idye göre filtrele.
        {
            
            return _cars.Where(p=>p.CarId == Id).ToList();
            
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car UpdateToCar;
            UpdateToCar=_cars.SingleOrDefault(c=>c.CarId == car.CarId);
            UpdateToCar.CarId = car.CarId;
            UpdateToCar.BrandId = car.BrandId;
            UpdateToCar.ColorId = car.ColorId;
            UpdateToCar.ModelYear = car.ModelYear;
            UpdateToCar.DailyPrice = car.DailyPrice;
        }
    }
}
