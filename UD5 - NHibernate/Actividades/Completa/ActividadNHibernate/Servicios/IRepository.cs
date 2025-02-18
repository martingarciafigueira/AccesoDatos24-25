using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadNHibernate.Servicios
{
    interface IRepository<TEntity, TKey> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetById(TKey id);

        TKey Save(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
