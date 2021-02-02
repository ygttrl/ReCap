using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstruct;
using Entities.Concrete;

namespace DataAccess.Abstruct
{
    public interface IBrandDal
    {
        Car GetById(Car car);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
