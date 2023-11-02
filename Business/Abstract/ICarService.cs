
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int CarId);
        List<Car> GetByName(string Name);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetCarsByBrandId(int brandId);

    }
}
