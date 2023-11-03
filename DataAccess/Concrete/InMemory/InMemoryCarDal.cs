using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { CarId = 1, BrandId = 7, ColorId = 6, DailyPrice = 5000, ModelYear = 2010, Description = "Aciklama1" },
                new Car { CarId = 2, BrandId = 7, ColorId = 4, DailyPrice = 7500, ModelYear = 2002, Description = "Aciklama2" },
                new Car { CarId = 3, BrandId = 9, ColorId = 5, DailyPrice = 5000, ModelYear = 2020, Description = "Aciklama3" },
                new Car { CarId = 4, BrandId = 8, ColorId = 6, DailyPrice = 5000, ModelYear = 2000, Description = "Aciklama4" },
                new Car { CarId = 5, BrandId = 8, ColorId = 6, DailyPrice = 5000, ModelYear = 2000, Description = "Aciklama5" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            if (carToDelete != null)
            {
                _cars.Remove(carToDelete);
            }
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
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Remove(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
            }
        }
    }

}
