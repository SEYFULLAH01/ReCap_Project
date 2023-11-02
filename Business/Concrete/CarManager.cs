using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int CarId)
        {
            return _carDal.GetAll(p => p.CarId == CarId);
        }

        public List<Car> GetByName(string Name)
        {
            return _carDal.GetAll(p=>p.Name == Name);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public void Remove(Car car)
        {
            _carDal.Remove(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
