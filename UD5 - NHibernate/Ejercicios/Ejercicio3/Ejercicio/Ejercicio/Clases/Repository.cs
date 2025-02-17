using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    public class Repository
    {
        public void CreateAccount(Cuenta account)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(account);
                transaction.Commit();
            }
        }

        public Cuenta GetAccountByIBAN(string IBAN)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<Cuenta>()
                      .FirstOrDefault(c => c.IBAN == IBAN);
            }
        }

        public void UpdateAccount(Cuenta account)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Update(account);
                transaction.Commit();
            }
        }

        public void DeleteAccount(string IBAN)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var cuentaToDelete = session.Query<Cuenta>()
                                             .FirstOrDefault(c => c.IBAN == IBAN);
                if (cuentaToDelete != null)
                {
                    session.Delete(cuentaToDelete);
                    transaction.Commit();
                }
            }
        }
    }
}
