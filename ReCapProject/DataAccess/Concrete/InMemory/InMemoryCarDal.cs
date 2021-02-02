using DataAccess.Abstruct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            if (_cars == null)
            {
                _cars = new List<Car> {
                    new Car{ Id=1,BrandId=1,ColorId=2,DailyPrice=180000,Description="Açıklama1",ModelYear=2012 },
                    new Car{ Id=2,BrandId=3,ColorId=4,DailyPrice=200000,Description="Açıklama2",ModelYear=2014 },
                    new Car{ Id=3,BrandId=4,ColorId=8,DailyPrice=540000,Description="Açıklama3",ModelYear=2021 },
                    new Car{ Id=4,BrandId=2,ColorId=1,DailyPrice=240000,Description="Açıklama4",ModelYear=2020 },
                    new Car{ Id=5,BrandId=5,ColorId=3,DailyPrice=220000,Description="Açıklama5",ModelYear=2018 }
                };
            }
        }

        public void Add(Car car)
        {
            if (car!=null && car.Id>0)
            {
                _cars.Add(car);
            }
        }

        public void Delete(Car car)
        {
            if (car.Id>0)
            {
                var deleteCar = _cars.SingleOrDefault(x => x.Id==car.Id);
                if (deleteCar!=null)
                {
                    _cars.Remove(deleteCar);
                }
            }
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Car car)
        {
            Car getCar = null;
            if (car.Id>0 && car!=null)
            {
               getCar = _cars.Find(x => x.Id== car.Id);
            }

            return getCar;
        }

        public void Update(Car car)
        {
            if (car!=null)
            {
                Car upDateCar = _cars.FirstOrDefault(x => x.Id== car.Id);
                upDateCar.Id = car.Id;
                upDateCar.BrandId = car.BrandId;
                upDateCar.ColorId = car.ColorId;
                upDateCar.ModelYear = car.ModelYear;
                upDateCar.DailyPrice = car.DailyPrice;
                upDateCar.Description = car.Description;
            }
        }
    }
}
