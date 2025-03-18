using Actividad5.Data;
using Actividad5.Services;
using System.Collections.Generic;

namespace Actividad5
{
    public partial class Form1 : Form
    {
        private readonly IProductoService _productoService;
        private readonly IPanaderiaService _panaderiaService;
        private readonly IPanaderiaProductoService _panaderiaProductoService;

        public Form1(IProductoService productoService, IPanaderiaService panaderiaService, IPanaderiaProductoService panaderiaProductoService)
        {
            InitializeComponent();
            _productoService = productoService;
            _panaderiaService = panaderiaService;
            _panaderiaProductoService = panaderiaProductoService;
            RefreshPanaderias();
            RefreshObtenerProductos();
            RefreshObtenerPanaderiaProductos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                var producto = new Producto { Nombre = tbNombre.Text };
                _productoService.AgregarProducto(producto);
                RefreshObtenerProductos();
                MessageBox.Show("Producto guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btGuardarProductoPanaderia_Click(object sender, EventArgs e)
        {
            var panaderiaProducto = new PanaderiaProducto
            {
                PanaderiaId = (int)cbPanaderia.SelectedValue,
                ProductoId = (int)cbProducto.SelectedValue,
                Stock = int.Parse(tbStock.Text),
                Precio = int.Parse(tbPrecio.Text)
            };
            _panaderiaProductoService.AgregarRelacion(panaderiaProducto);
            RefreshObtenerPanaderiaProductos();
        }


        public void RefreshPanaderias()
        {
            // Consultar todos los productos de la base de datos
            var Panaderias = _panaderiaService.ObtenerPanaderias();
            cbPanaderia.DataSource = Panaderias;
            cbPanaderia.DisplayMember = "Nombre";
            cbPanaderia.ValueMember = "Id";
            cbPanaderia.SelectedIndex = -1;
            dgvPanaderia.DataSource = Panaderias;
        }

        public void RefreshObtenerProductos()
        {
            // Consultar todos los productos de la base de datos
            var Productos = _productoService.ObtenerProductos();

            cbProducto.DataSource = Productos;
            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "Id";
            cbProducto.SelectedIndex = -1;
            dgvProductos.DataSource = Productos;

        }

        public void RefreshObtenerPanaderiaProductos()
        {
            // Consultar todos los productos de las panaderias de la base de datos
            var panaderiaProductos = _panaderiaProductoService.ObtenerRelaciones()
            .Select(pp => new
            {
                Panaderia = pp.Panaderia.Nombre,  // Nombre de la panadería
                Producto = pp.Producto.Nombre,   // Nombre del producto
                Precio = pp.Precio,     // Precio del producto
                Stock = pp.Stock       // Stock del producto
            })
            .ToList();
            dgvPanaderiaProductos.DataSource = panaderiaProductos;
        }

        private void btGuardarPanaderia_Click(object sender, EventArgs e)
        {
            var panaderia = new Panaderia { Nombre = tbNombrePanaderia.Text, Direccion = tbDireccion.Text, Telefono = tbTelefono.Text };
            _panaderiaService.AgregarPanaderia(panaderia);
            RefreshPanaderias();
            MessageBox.Show("Panadería guardada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbNombrePanaderia.Clear();
        }
    }
}
