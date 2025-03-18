using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea03Pokemon
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btEjercicio1_Click(object sender, EventArgs e)
        {
            TiendaPrincipal formTienda = new TiendaPrincipal();
            formTienda.ShowDialog();
        }

        private void btCentroPokemon_Click(object sender, EventArgs e)
        {
            CentroPokemonMenu formCentroPokemon = new CentroPokemonMenu();
            formCentroPokemon.ShowDialog();
        }
    }
}
