using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EnitiyFramework
{
    public class ColorWrapper
    {
        public Color Value { get; set; }
    }

    public class EfColorDal : IEntityRepository<ColorWrapper>
    {
        public void Add(ColorWrapper entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ColorWrapper entity)
        {
            throw new NotImplementedException();
        }

        public ColorWrapper Get(Expression<Func<ColorWrapper, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ColorWrapper> GetAll(Expression<Func<ColorWrapper, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(ColorWrapper entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ColorWrapper entity)
        {
            throw new NotImplementedException();
        }
    }
}
