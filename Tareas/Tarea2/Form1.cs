using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Tarea2
{
    public partial class Form1 : Form
    {
        bool llamadaProductos = false;
        bool llamadaFabricante = false;

        SqlConnection miConexionSql;

        Dictionary<int, string> consultas = new Dictionary<int, string>()
        {
            { 1, "1. Lista de productos ordenados por nombre y precio" },
            { 2, "2. Productos con precio entre 60 y 200 euros" },
            { 3, "3. Fabricantes con nombre de 4 caracteres" },
            { 4, "4. Productos con nombres y precios, y sus fabricantes" },
            { 5, "5. Productos de fabricantes específicos" },
            { 6, "6. Lista de fabricantes ordenados por nombre" },
            { 7, "7. Número total de productos" },
            { 8, "8. Fabricantes con suma de precios superior a 1000 euros" },
            { 9, "9. Fabricantes sin productos asociados" },
            { 10, "10. Fabricantes con número de productos con precio superior a 220 euros" }
        };
        public Form1()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["Tarea2.Properties.Settings.tiendaConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            miConexionSql.Open();
            CheckRadioButtons();
            RellenarListaProductos2();
            RellenarListaFabricantes2();
            LlenarComboboxConsultas();
            RealizarConsulta();
        }

        private void RellenarListaFabricantes2()
        {


            string consulta = "SELECT * FROM fabricante";
            SqlCommand comando = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            RellenarListaAdapter(lstFabricantes2, adapter, "codigo", "nombre");
        }

        private void RellenarListaProductos2()
        {

            string consulta = "SELECT * FROM producto";
            SqlCommand comando = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            RellenarListaAdapter(lstProductos2, adapter, "codigo", "nombre");

        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            RellenarListaProductos();
            llamadaProductos = true;

        }

        private void btnMostrarFabricantes_Click(object sender, EventArgs e)
        {
            RellenarListaFabricantes();
            llamadaFabricante = true;
        }
        private void cbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultaComboBox();

        }
        private void cbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealizarConsulta();

        }

        private void RealizarConsulta()
        {
            string consulta;
            if (cbConsultas.SelectedValue is int selectedValue)
                switch (selectedValue)
                {
                    case 1:
                        consulta = "SELECT CONCAT(nombre,' | ',precio,' € ') as INFO FROM producto ORDER BY nombre ASC, precio DESC";
                        RellenarLista(consulta, "codigo", "INFO", lstConsultas);
                        break;
                    case 2:
                        consulta = "SELECT CONCAT(nombre,' | ',precio,' € ') as INFO FROM producto WHERE precio BETWEEN 60 AND 200";
                        RellenarLista(consulta, "codigo", "INFO", lstConsultas);
                        break;
                    case 3:
                        consulta = "SELECT * FROM fabricante WHERE LEN(nombre) = 4";
                        RellenarLista(consulta, "codigo", "nombre", lstConsultas);
                        break;
                    case 4:
                        consulta = "SELECT CONCAT(P.nombre,' | ', P.precio,' € | ', F.nombre) AS INFO FROM producto P JOIN fabricante F ON P.codigo_fabricante = F.codigo";
                        RellenarLista(consulta, "codigo", "INFO", lstConsultas);
                        break;
                    case 5:
                        consulta = "SELECT CONCAT(p.nombre, ' - ', p.precio, '€ - ', f.nombre) AS INFO FROM producto p" +
                             " JOIN fabricante f ON p.codigo_fabricante = f.codigo" + 
                             " WHERE f.nombre IN ('Asus', 'Hewlett-Packard', 'Seagate');";
                        RellenarLista(consulta, "codigo", "INFO", lstConsultas);
                        break;
                    case 6:
                        consulta = "SELECT * FROM fabricante ORDER BY nombre ASC";
                        RellenarLista(consulta, "codigo", "nombre", lstConsultas);
                        break;
                    case 7:
                        consulta = "SELECT COUNT(*) AS TotalProductos FROM producto";
                        RellenarLista(consulta, "codigo", "TotalProductos", lstConsultas);
                        break;
                    case 8:
                        consulta = "SELECT CONCAT(F.nombre,' | ', SUM(P.precio),' € ') AS SumaPrecio FROM fabricante F JOIN producto P ON F.codigo = P.codigo_fabricante GROUP BY F.nombre HAVING SUM(P.precio) > 1000";
                        RellenarLista(consulta, "codigo", "SumaPrecio", lstConsultas);
                        break;
                    case 9:
                        consulta = "SELECT F.nombre FROM fabricante F LEFT JOIN producto P ON F.codigo = P.codigo_fabricante WHERE P.codigo IS NULL";
                        RellenarLista(consulta, "codigo", "nombre", lstConsultas);
                        break;
                    case 10:
                        consulta = "SELECT CONCAT(F.nombre,' | ', COUNT(P.nombre)) AS NumProductos FROM fabricante F LEFT JOIN producto P ON F.codigo = P.codigo_fabricante AND P.precio >= 220 GROUP BY F.nombre";
                        RellenarLista(consulta, "codigo", "NumProductos", lstConsultas);
                        break;
                }
        }

        private void rbFabricantes_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButtons();
        }
        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM producto WHERE codigo = @Codigo";
            SqlCommand comando = new SqlCommand(consulta, miConexionSql);

            comando.Parameters.AddWithValue("@Codigo", lstProductos2.SelectedValue);
            comando.ExecuteNonQuery();
            CheckRadioButtons();
            RellenarListaProductos2();
            if (llamadaProductos)
            {
                RellenarListaProductos();
                RealizarConsulta();

            }

        }

        private void btnBorrarFabricante_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT COUNT(codigo) FROM producto WHERE codigo_fabricante = @Codigo";
            SqlCommand comando = new SqlCommand(consulta, miConexionSql);
            comando.Parameters.AddWithValue("@Codigo", lstFabricantes2.SelectedValue);
            int registros = (int)comando.ExecuteScalar();

            if (registros > 0)
            {
                DialogResult respuesta = MessageBox.Show("El fabricante tiene productos asociados. ¿Desea borrarlos o cancelar?", "ADVERTENCIA", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    consulta = "DELETE FROM producto WHERE codigo_fabricante = @Codigo;" +
                        "DELETE FROM fabricante WHERE codigo = @Codigo;";

                    comando = new SqlCommand(consulta, miConexionSql);

                    comando.Parameters.AddWithValue("@Codigo", lstFabricantes2.SelectedValue);
                    comando.ExecuteNonQuery();
                    CheckRadioButtons();
                    RellenarListaProductos2();
                    RellenarListaFabricantes2();
                    RealizarConsulta();
                    if (llamadaProductos) RellenarListaProductos();
                    if (llamadaFabricante) RellenarListaFabricantes();
                }
            }
            else
            {
                consulta = "DELETE FROM fabricante WHERE codigo = @Codigo;";
                comando = new SqlCommand(consulta, miConexionSql);

                comando.Parameters.AddWithValue("@Codigo", lstFabricantes2.SelectedValue);
                comando.ExecuteNonQuery();
                CheckRadioButtons();
                RellenarListaFabricantes();
                RellenarListaFabricantes2();
                RealizarConsulta();
            }
        }

        private void RellenarListaProductos()
        {

            string consulta = "SELECT CONCAT(codigo,' | ',nombre,' | ',precio,' € ') as INFO FROM producto";
            SqlCommand comando = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);


            RellenarListaAdapter(lstProductos, adapter, "codigo", "INFO");

        }

        private void RellenarListaFabricantes()
        {

            string consulta = "SELECT nombre FROM fabricante";
            SqlCommand comando = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);


            RellenarListaAdapter(lstFabricantes, adapter, "codigo", "nombre");

        }


        private void RellenarListaAdapter(ListBox listaParaRellenar, SqlDataAdapter adaptadorRellenar, string campoIdentificador, string campoMostrar)
        {
            using (adaptadorRellenar)
            {
                DataTable datatable = new DataTable();
                adaptadorRellenar.Fill(datatable);

                listaParaRellenar.ValueMember = campoIdentificador; //La clave asociada a cada futbolista
                listaParaRellenar.DisplayMember = campoMostrar; // El nombre asociado a cada futbolista
                listaParaRellenar.DataSource = datatable;
            }

        }

        private void RellenarComboBox(ComboBox cbRellenar, SqlDataAdapter adapter)
        {

            using (adapter)
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                cbRellenar.ValueMember = "codigo";
                cbRellenar.DisplayMember = "nombre";
                cbRellenar.DataSource = datatable;
            }

        }

        private void CheckRadioButtons()
        {
            if (rbFabricantes.Checked)
            {
                string consulta = "SELECT * FROM fabricante";
                SqlCommand comando = new SqlCommand(consulta, miConexionSql);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                RellenarComboBox(cbOpciones, adapter);

            }
            if (rbProductos.Checked)
            {
                string consulta = "SELECT * FROM producto";
                SqlCommand comando = new SqlCommand(consulta, miConexionSql);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                RellenarComboBox(cbOpciones, adapter);

            }
        }

        private void ConsultaComboBox()
        {
            if (rbFabricantes.Checked)
            {
                string consulta = "SELECT p.nombre FROM fabricante f INNER JOIN producto p ON p.codigo_fabricante = f.codigo WHERE f.codigo = @Codigo";
                RellenarTextBox(tbResultados, consulta);
            }
            if (rbProductos.Checked)
            {
                string consulta = "SELECT f.codigo, f.nombre FROM Producto p INNER JOIN Fabricante f ON p.codigo_fabricante = f.codigo WHERE p.codigo = @Codigo;";
                RellenarTextBox(tbResultados, consulta);
            }

        }
        private void RellenarTextBox(TextBox textBox, string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, miConexionSql);
            comando.Parameters.AddWithValue("@Codigo", cbOpciones.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            using (adapter)
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                StringBuilder sb = new StringBuilder();
                if (dataTable.Rows.Count > 0 && dataTable.Columns.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (rbFabricantes.Checked)
                        {
                            sb.AppendLine($"{row["nombre"]}");

                        }
                        if (rbProductos.Checked)
                        {
                            string codigo = row["codigo"].ToString();
                            string nombre = row["nombre"].ToString();
                            sb.AppendLine($"{codigo} || {nombre}");
                        }
                    }
                }
                else
                {
                    sb.Append("No hay resultados.");
                }

                textBox.Text = sb.ToString();
            }
        }

        private void LlenarComboboxConsultas()
        {
            cbConsultas.DataSource = new BindingSource(consultas, null);
            cbConsultas.DisplayMember = "Value";
            cbConsultas.ValueMember = "Key";
        }

        private void RellenarLista(string consulta, string campoIdentificador, string campoMostrar, ListBox listaParaRellenar)
        {
            SqlCommand comando = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
    
            using (adapter)
            {
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                listaParaRellenar.DataSource = null;

                listaParaRellenar.ValueMember = campoIdentificador;
                listaParaRellenar.DisplayMember = campoMostrar;
                listaParaRellenar.DataSource = datatable;

               
            }
          
        }

    }
}
