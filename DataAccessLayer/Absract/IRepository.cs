using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Absract
{
    public interface IRepository<T>
    {
        List<T> List();
        void insert(T p);
        void update(T p);
        void delete(T p);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
