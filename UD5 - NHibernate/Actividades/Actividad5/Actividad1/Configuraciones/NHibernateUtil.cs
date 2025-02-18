using Actividad1.Entidades;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Configuraciones
{
    class NHibernateUtil
    {
		private static ISessionFactory sessionFactory;

        private static ISessionFactory BuildSessionFactory()
        {
			try
			{
				if (NHibernateUtil.sessionFactory == null)
				{
					Configuration config = new Configuration();
					config.Configure();

					HbmSerializer.Default.Validate = true;
					config.AddInputStream(HbmSerializer.Default.Serialize(Assembly.GetExecutingAssembly()));

					config.AddAssembly(typeof(Asignatura).Assembly);
					config.AddAssembly(typeof(Instituto).Assembly);
					config.AddAssembly(typeof(Estudiante).Assembly);

					new SchemaUpdate(config);

					NHibernateUtil.sessionFactory = config.BuildSessionFactory();
				}
				return sessionFactory;
			}
			catch (Exception)
			{
				throw;
			}
        }

		public static ISessionFactory GetISessionFactory()
		{
			if (sessionFactory == null)
			{
				return BuildSessionFactory();
			}
			else
			{
				return sessionFactory;
			}
		}

		public static void Start()
		{
			BuildSessionFactory();
		}

		public static void Stop()
		{
			NHibernateUtil.GetISessionFactory().Close();
		}
    }
}
