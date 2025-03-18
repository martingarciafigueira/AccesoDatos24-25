using System;
using System.Windows.Forms;
using Tarea03Pokemon.Tienda;
using Tarea03Pokemon.Tienda.Clases;

namespace Tarea03Pokemon
{
    public partial class TiendaPrincipal : Form
    {
        MainTienda tienda = new MainTienda();
        public TiendaPrincipal()
        {
            InitializeComponent();
        }

        private void TiendaPrincipal_Load(object sender, EventArgs e)
        {
            rbFabricante.Checked = true;
            //Obtenemos la lista de fabricante y productos de la base de datos
            lbFabricantes.DataSource = tienda.Getfabricantes();
            lbProductos.DataSource = tienda.GetProductos();
        }

        private void btBorrarFabricante_Click(object sender, EventArgs e)
        {
            var fabricante = (Fabricante)lbFabricantes.SelectedItem;

            if (fabricante != null)
            {


                //Borramos fabricante seleccionado
                var resultado = tienda.BorrarFabricante(fabricante);

                if (resultado == "NOK")
                {
                    DialogResult result = MessageBox.Show("¿Fabricante con productos, quieres borrar el fabricante y sus productos?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        resultado = tienda.BorrarFabricanteyProductos(fabricante);
                        tienda.BorrarFabricanteyProductos(fabricante);
                        if (resultado == "OK")
                        {
                            MessageBox.Show("Fabricante borrando");                                                        
                        }
                    }                    
                }
                else
                {
                    tienda.BorrarFabricanteSinProductos(fabricante);
                    MessageBox.Show("Fabricante borrando");
                }
            }
            else
            {
                MessageBox.Show("Fabricante no seleccionado");
            }
        }

        private void btBorrarProducto_Click(object sender, EventArgs e)
        {
            var producto = (Producto)lbProductos.SelectedItem;

            if (producto != null)
            {
                tienda.BorrarProducto(producto);
            }
            else
            {
                MessageBox.Show("Producto no seleccionado");
            }
        }

        private void tbTextoAbuscar_TextChanged(object sender, EventArgs e)
        {
            TextoLibre();
        }

        private void btRefrescarFabricantes_Click(object sender, EventArgs e)
        {
            lbFabricantes.DataSource = tienda.Getfabricantes();
        }

        private void btRefrescarProductos_Click(object sender, EventArgs e)
        {
            lbProductos.DataSource = tienda.GetProductos();
        }

        private void rbFabricante_CheckedChanged(object sender, EventArgs e)
        {
            TextoLibre();
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
            TextoLibre();
        }

        private void TextoLibre()
        {
            tbResultadoBusqueda.Clear();
            string resultado = "";
            if (rbFabricante.Checked && tbTextoAbuscar.Text.Length > 0)
            {
                resultado = "Buscando";
                resultado = tienda.GetFabricantesFiltro(tbTextoAbuscar.Text);

            }
            else if (rbProducto.Checked && tbTextoAbuscar.Text.Length > 0)
            {
                resultado = "Buscando";
                resultado = tienda.GetProductosFiltro(tbTextoAbuscar.Text);
            }

            tbResultadoBusqueda.Text = resultado;
        }
    }
}
