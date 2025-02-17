using Ejercicio.Clases;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        ISessionFactory sessionFactory;
        Repository repository;
        Cuenta cuentaExistente;

        public Form1()
        {
            InitializeComponent();
            sessionFactory = CreateSessionFactory();
            repository = new Repository();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            // Configuración de NHibernate
            var configuration = new Configuration();
            configuration.Configure(); // Cargar la configuración desde hibernate.cfg.xml o desde código

            // Mapeo de clases de entidad
            configuration.AddAssembly(typeof(Cuenta).Assembly);

            // Crear y devolver la fábrica de sesiones
            return configuration.BuildSessionFactory();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string IBAN, Nombre;
            decimal balance;

            IBAN = txtIBAN.Text;
            Nombre = txtNombreCuenta.Text;
            decimal.TryParse(txtBalanceCuenta.Text, out balance);

            Cuenta nuevaCuenta = new Cuenta();
            nuevaCuenta.IBAN = IBAN;
            nuevaCuenta.Nombre = Nombre;
            nuevaCuenta.Balance = balance;

            repository.CreateAccount(nuevaCuenta);
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            string IBAN;
            IBAN = txtIBANBusqueda.Text;

            cuentaExistente = repository.GetAccountByIBAN(IBAN);

            txtNombreCuentaExistente.Text = cuentaExistente.Nombre;
            txtBalanceCuentaExistente.Text = cuentaExistente.Balance.ToString();
        }

        private void btnBorrarCuenta_Click(object sender, EventArgs e)
        {
            string IBAN;
            IBAN = txtIBANBusqueda.Text;

            repository.DeleteAccount(IBAN);
        }

        private void btnActualizarCuenta_Click(object sender, EventArgs e)
        {
            decimal BalanceCuentaExistente;

            if (cuentaExistente != null)
            {
                decimal.TryParse(txtBalanceCuentaExistente.Text, out BalanceCuentaExistente);
                cuentaExistente.Nombre = txtNombreCuentaExistente.Text;
                cuentaExistente.Balance = BalanceCuentaExistente;
                repository.UpdateAccount(cuentaExistente);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta");
            }
        }
    }
}
