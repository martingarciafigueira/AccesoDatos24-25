using Ejercicio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            User usuario = new User();
            
            usuario.Name = txtNombre.Text;
            usuario.Email = txtEmail.Text;

            var userRepository = new UserRepository();
            userRepository.AddUser(usuario);

            MessageBox.Show("El usuario se ha registrado correctamente");
        }
    }
}
