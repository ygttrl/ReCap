using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static  CarManager carManager = new CarManager(new InMemoryCarDal());
        static void Main(string[] args)
        {

            //Listeleme
            var cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }

            //Ekleme
            carManager.Add(new Car { Id=6,BrandId=7,ColorId=2,ModelYear=2020,DailyPrice=380000,Description="Açıklama 6" });
            carManager.Add(new Car { Id = 7, BrandId = 12, ColorId = 22, ModelYear = 2018, DailyPrice = 310000, Description = "Açıklama 7" });

            Console.WriteLine("----------------------------------------");


            foreach (var car in cars)
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }



            //GetById
            var singleCar = carManager.GetById(new Car {Id=7 });
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(singleCar.Id + " " + singleCar.BrandId + " " + singleCar.ColorId + " " + singleCar.ModelYear + " " + singleCar.DailyPrice + " " + singleCar.Description);

            Console.WriteLine("----------------------------------------");
            //Update
            Car updateCar = new Car { Id = 7, BrandId = 12, ColorId = 22, ModelYear = 2018, DailyPrice = 310000, Description = "Açıklama 444444444" };
            carManager.Update(updateCar);

            foreach (var car in cars)
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }


            //Delete
            Console.WriteLine("----------------------------------------");
            Car deleteCar = new Car { Id=7 };
            carManager.Delete(deleteCar);

            foreach (var car in cars)
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }


            Console.ReadLine();
        }

        
    }
}
