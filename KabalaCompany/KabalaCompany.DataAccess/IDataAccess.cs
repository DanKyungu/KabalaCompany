using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabalaCompany.DataAccess
{
    public interface IDataAccess<T> where T:new()
    {
        void Add(T entity);

        void Delete(T entity);

        bool Update(int id,T entity);
    }
}
