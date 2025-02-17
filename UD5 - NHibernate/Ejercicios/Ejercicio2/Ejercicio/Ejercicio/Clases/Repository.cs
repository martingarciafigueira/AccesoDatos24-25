using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    public class Repository
    {
        public void AddCategory(Category category)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(category);
                transaction.Commit();
            }
        }

        public void AddProduct(Product product)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(product);
                transaction.Commit();
            }
        }

        public IList<Category> GetCategories()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Category>().List();
            }
        }

        public IList<Product> GetProductsByCategory(int categoryId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Product>().Where(p => p.Category.Id == categoryId).List();
            }
        }
    }
}
