using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   ColorandBrandId();
            //  joinsfull();
            //AddtoCar();
            //    IResultile();
            //IResultcolorAdd();
            // IResulDataBrandlist();
            // GetforPrice();
            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Update(new Car { CarId = 17, BrandId = 9, ColorId = 2, ModelYear = 2020, DailyPrice = 180000, Description = "FİESTA" });

            //foreach (var item in carManager.getAll().Data)
            //{
            //    Console.WriteLine(item.Description);
            //}

        }

        //private static void GetforPrice()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.FindGetDailyPrice(1000000);
        //    if (result.Success == false)
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //    else
        //    {
        //        foreach (var prices in result.Data)
        //        {
        //            Console.WriteLine(prices.DailyPrice + prices.BrandCar + prices.ColorCar + prices.ModelYear);
        //        }
        //    }
        //}

        //private static void ıresuldatabrandlist()
        //{
        //    brandmanager brandmanager = new brandmanager(new efbranddal());
        //    var result = brandmanager.getallbrand();
        //    if (result.success == false)
        //    {
        //        console.writeline(result.message);
        //    }
        //    else
        //    {
        //        foreach (var brand in result.data)
        //        {
        //            console.writeline(brand.brandcar);
        //        }
        //    }
        //}

        //private static void ıresultcoloradd()
        //{
        //    colormanager colormanager = new colormanager(new efcolordal());
        //    var result = colormanager.getcolorıd(2);
        //    if (result.success == false)
        //    {
        //        console.writeline(result.message);
        //    }
        //    else
        //    {
        //        foreach (var car in result.data)
        //        {
        //            console.writeline(car.colorcar);
        //        }

        //    }
        //}

        //private static void IResultile()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.getAll();
        //    if (result.Success == false)
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //    else
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.DailyPrice );
        //        }

        //    }
        //}

        //private static void AddtoCar()
        //{


        //    UserManager userManager = new UserManager(new EfUserDal());
        //    userManager.Add(new User() { UserId = 1, FirstName = "RECEP", LastName = "KAPUCUOGLU", Email = "recepkapucuoglu@gmail.com", Password = "123recep" });



        //    foreach (var item in userManager.GetAll().Data)
        //    {
        //        Console.WriteLine(item.UserId);
        //    }

        //}

        //private static void joinsfull()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var c in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(c.BrandCar + "---" + c.ModelYear + "----" + c.ColorCar + "---" + c.DailyPrice + "--" + c.Description);
        //    }
        //}

        //private static void ColorandBrandId()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    foreach (var c in carManager.GetCarsByBrandId(1))
        //    {
        //        Console.WriteLine("yıl" + c.ModelYear + "fiyat" + c.DailyPrice + "Açıklama =" + c.Description);
        //    }
        //    Console.WriteLine("-----------------------------");
        //    foreach (var c in carManager.GetCarsByColorId(1))
        //    {
        //        Console.WriteLine("yıl" + c.ModelYear + "fiyat" + c.DailyPrice + "Açıklama =" + c.Description);
        //    }
        //}
    }
}
