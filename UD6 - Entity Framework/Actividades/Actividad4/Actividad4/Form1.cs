using Actividad4.Data;
using System.Collections.Generic;

namespace Actividad4
{
    public partial class Form1 : Form
    {
        private readonly PanaderiaContext _context;

        public Form1(PanaderiaContext context)
        {
            _context = context;
            InitializeComponent();
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
                // Crear un nuevo producto basado en los valores de los TextBox
                var producto = new Producto
                {
                    Nombre = tbNombre.Text
                };

                // Agregar y guardar el producto en la base de datos
                _context.Productos.Add(producto);
                _context.SaveChanges();
                RefreshObtenerProductos();

                MessageBox.Show("Producto guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos
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
                PanaderiaId = (Int32)cbPanaderia.SelectedValue,
                ProductoId = (Int32)cbProducto.SelectedValue,
                Stock = Int32.Parse(tbStock.Text),
                Precio = Int32.Parse(tbPrecio.Text)
            };
            // Agregar y guardar el producto en la base de datos
            _context.PanaderiasProductos.Add(panaderiaProducto);
            _context.SaveChanges();
            RefreshObtenerPanaderiaProductos();
        }


        public void RefreshPanaderias()
        {
            // Consultar todos los productos de la base de datos
           var Panaderias = _context.Panaderias.ToList();
            cbPanaderia.DataSource = Panaderias;
            cbPanaderia.DisplayMember = "Nombre";
            cbPanaderia.ValueMember = "Id";
            cbPanaderia.SelectedIndex = -1;
            dgvPanaderia.DataSource = Panaderias;
        }

        public void RefreshObtenerProductos()
        {
            // Consultar todos los productos de la base de datos
           var Productos =  _context.Productos.ToList();

            cbProducto.DataSource = Productos;
            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "Id";
            cbProducto.SelectedIndex = -1;
            dgvProductos.DataSource = Productos;

        }

        public void RefreshObtenerPanaderiaProductos()
        {
            // Consultar todos los productos de las panaderias de la base de datos
            var panaderiaProductos = _context.PanaderiasProductos
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
            try
            {
                // Crear un nuevo producto basado en los valores de los TextBox
                var panaderia = new Panaderia
                {
                    Nombre = tbNombrePanaderia.Text,
                    Direccion = tbDireccion.Text,
                    Telefono = tbTelefono.Text,
                };

                // Agregar y guardar el producto en la base de datos
                _context.Panaderias.Add(panaderia);
                _context.SaveChanges();
                RefreshPanaderias();
                MessageBox.Show("Panadería guardada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos
                tbNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
