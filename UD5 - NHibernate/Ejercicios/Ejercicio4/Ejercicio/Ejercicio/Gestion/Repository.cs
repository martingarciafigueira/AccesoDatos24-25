using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    public class Repository
    {
        public void AddOrUpdate(Vehiculo Vehiculo)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(Vehiculo);
                transaction.Commit();
            }
        }

        public IList<Vehiculo> GetAll()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Vehiculo>().List();
            }
        }

        public IList<T> GetAll<T>() where T : Vehiculo
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<T>().List();
            }
        }
    }
}
