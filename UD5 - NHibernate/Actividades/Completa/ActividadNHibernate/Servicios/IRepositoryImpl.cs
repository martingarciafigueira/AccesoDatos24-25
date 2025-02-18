using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadNHibernate.Servicios
{
    class IRepositoryImpl<TEntity,TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        protected ISession GetISession()
        {
            return Configuraciones.NHibernateUtil.GetISessionFactory().OpenSession();
        }
        
        public TKey Save(TEntity entity)
        {
            ISession sesion = this.GetISession();
            ITransaction tx = sesion.BeginTransaction();

            try
            {
                TKey tkey = (TKey)sesion.Save(entity);
                tx.Commit();
                sesion.Close();
                return tkey;
            }
            catch (Exception)
            {
                tx.Rollback();
                sesion.Close();
                throw;
            }
        }

        public List<TEntity> GetAll()
        {
            ISession sesion = this.GetISession();
            List<TEntity> lista = sesion.Query<TEntity>().ToList();
            sesion.Close();
            return lista;
        }

        public TEntity GetById(TKey id)
        {
            ISession sesion = this.GetISession();
            TEntity entity = sesion.Get<TEntity>(id);
            sesion.Close();
            return entity;
        }

        public void Update(TEntity entity)
        {
            ISession sesion = this.GetISession();
            ITransaction tx = sesion.BeginTransaction();

            try
            {
                sesion.Update(entity);
                tx.Commit();
                sesion.Close();
            }
            catch (Exception)
            {
                tx.Rollback();
                sesion.Close();
                throw;
            }
        }

        public void Delete(TEntity entity)
        {
            ISession sesion = this.GetISession();
            ITransaction tx = sesion.BeginTransaction();

            try
            {
                sesion.Delete(entity);
                tx.Commit();
                sesion.Close();
            }
            catch (Exception)
            {
                tx.Rollback();
                sesion.Close();
                throw;
            }
        }
    }
}
