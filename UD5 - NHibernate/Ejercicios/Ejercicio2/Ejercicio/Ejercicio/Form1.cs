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
        Repository repository;
        public Form1()
        {
            repository = new Repository();
            InitializeComponent();
            ActualizarCategorias();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Category categoria = new Category();

            categoria.Name = txtNombreCategoria.Text;
            categoria.Description = txtDescripcionCategoria.Text;

            repository.AddCategory(categoria);

            MessageBox.Show("La categoria se ha registrado correctamente");
            ActualizarCategorias();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Product producto = new Product();

            producto.Name = txtNombreProducto.Text;
            producto.Price = decimal.Parse(txtPrecioProducto.Text);
            producto.Category = cbCategoriaProducto.SelectedItem as Category;

            repository.AddProduct(producto);

            MessageBox.Show("El producto se ha registrado correctamente");
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = (List<Category>) repository.GetCategories().Distinct().ToList();
            return categories;
        }

        private void cbCategoriaSeleccionada_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener categorías y productos asociados
            Category categoriaSeleccionada = cbCategoriaSeleccionada.SelectedItem as Category;
            lstProductosAsociados.DataSource = categoriaSeleccionada.Products;
        }

        public void ActualizarCategorias()
        {
            cbCategoriaProducto.DataSource = GetAllCategories();
            cbCategoriaSeleccionada.DataSource = GetAllCategories();
        }
    }
}
