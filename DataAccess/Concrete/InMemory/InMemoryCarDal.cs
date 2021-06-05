using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = 2015, Description = "Fiat Punto"},
                new Car {Id = 2, BrandId = 1, ColorId = 3, DailyPrice = 200, ModelYear = 2016, Description = "BMW M3"},
                new Car {Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 300, ModelYear = 2017, Description = "Mercedes G500"},
                new Car {Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 150, ModelYear = 2014, Description = "Honda Civic"},
                new Car {Id = 5, BrandId = 1, ColorId = 2, DailyPrice = 145, ModelYear = 2019, Description = "Seat Leon"},
            };
        }

        public Car GetById(int Id)
        {
            Car car;
            car=_cars.SingleOrDefault(p => p.Id == Id);
            return car;
        }

        

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate= _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
