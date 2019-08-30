using KabalaCompany.DataEntities;
using System.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabalaCompany.DataAccess
{
    public class BaseDataAccess<T> : IDataAccess<T> where T : new()
    {
        protected KabalaComapany DbContext { get; }

        public BaseDataAccess()
        {
            DbContext = new KabalaComapany();
        }

        public void Add(T entity)
        {
            using (DbContext)
            {
                DbContext.Set(entity.GetType()).Add(entity);
                DbContext.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (DbContext)
            {
                DbContext.Set(entity.GetType()).Remove(entity);
                DbContext.SaveChanges();
            }
        }

        public bool Update(int id, T entity)
        {
            using (DbContext)
            {
                var currentEmployee = DbContext.Set(entity.GetType())
                    .Find(id);
                //DbContext.Entry(currentEmployee).CurrentValues.SetValues(entity);

                DbContext.SaveChanges();

                return true;
            }
        }
    }

}
