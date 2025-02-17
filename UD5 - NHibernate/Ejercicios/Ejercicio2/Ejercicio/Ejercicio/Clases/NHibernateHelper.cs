using NHibernate.Mapping.ByCode;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;

namespace Ejercicio.Clases
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure(); // carga la configuración de NHibernate del archivo hibernate.cfg.xml

                    // Mapea las clases
                    var mapper = new ModelMapper();
                    mapper.AddMapping<CategoryMap>();
                    mapper.AddMapping<ProductMap>();
                    var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
                    configuration.AddDeserializedMapping(mapping, null);

                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
