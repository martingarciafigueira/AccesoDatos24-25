using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tarea03Pokemon.Tienda.Clases;

namespace Tarea03Pokemon.Tienda.Database
{
    public class FabricanteDatabase
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=tienda; integrated security = true");

        BindingList<Fabricante> fabricantes = new BindingList<Fabricante>();
        BindingList<Producto> productos = new BindingList<Producto>();
        
        public BindingList<Fabricante> obtenerFabricantes()
        {
            try
            {                
                conexion.Open();                
                SqlCommand command = new SqlCommand(CadenasSql.SelectFabricantes, conexion);
                SqlDataReader registros = command.ExecuteReader();
                //Recoremos los datos obtenidos de la bd
                while (registros.Read())
                {
                    //Generamos los objectos y los almacenamos
                    Fabricante fabricante = new Fabricante();

                    fabricante.Nombre = (string)registros["nombre"];
                    fabricante.Codigo = (int)registros["codigo"];
                    fabricantes.Add(fabricante);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return fabricantes;
        }

        public BindingList<Producto> obtenerProductos()
        {
            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(CadenasSql.SelectProductos, conexion);
                SqlDataReader registros = command.ExecuteReader();
                while (registros.Read())
                {
                    //Generamos los objectos y los almacenamos
                    Producto producto = new Producto();
                    
                    producto.Nombre = (string)registros["nombre"];
                    producto.Codigo = (int)registros["codigo"];
                    producto.Precio = Convert.ToSingle(registros["precio"]);
                    producto.CodigoFabricante = (int)registros["codigo_fabricante"];

                    productos.Add(producto);
                }                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return productos;
        }
        //Borra el producto pasado por parameto de la base de datos
        // param => Object Producto
        public void BorrarProducto(Producto producto)
        {
            try
            {
                conexion.Open();

                string deleteSql = "DELETE FROM producto WHERE codigo = @value";
                SqlCommand command = new SqlCommand(deleteSql, conexion);
                //añadimos los valores al delete
                command.Parameters.AddWithValue("@value", producto.Codigo);
                //Ejecuta el delete sobre la basde datos
                int rowsDeleted = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }            
        }
        //Borra los produstos asociados al Fabricante
        //param => Object Fabricante 
        public int BorrarProductosFabricante(Fabricante fabricante)
        {
            int rowsDeleted = 0;
            try
            {
                conexion.Open();
                string deleteSql = "DELETE FROM dbo.producto WHERE codigo_fabricante in (select codigo from dbo.fabricante where nombre = @valor);";
                SqlCommand command = new SqlCommand(deleteSql, conexion);
                //añadimos los valores al delete
                command.Parameters.AddWithValue("@valor", fabricante.Nombre);
                //Ejecuta el delete sobre la basde datos
                rowsDeleted = command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return rowsDeleted;
        }
        //Borrar un fabricante de la base de datos
        //param => Object Fabricante
        public string BorrarFabricante(Fabricante fabricante)
        {
            string resultado = "NOK";
            try
            {
                if (CompruebaExistenProductos(fabricante) == 0)
                {
                    resultado = "OK";
                    conexion.Open();
                    string deleteSql = "DELETE FROM fabricante WHERE codigo = @codigo_fabricante";
                    SqlCommand command = new SqlCommand(deleteSql, conexion);
                    //añadimos los valores al delete
                    command.Parameters.AddWithValue("@codigo_fabricante", fabricante.Codigo);
                    //Ejecuta el delete sobre la basde datos
                    int rowsDeleted = command.ExecuteNonQuery();
                    Console.WriteLine("Rows deleted: {0}", rowsDeleted);
                    conexion.Close();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

        //Devuelve un int que indica el numero de productos que tiene asociado un fabricante
        // param => object Fabricante 
        private int CompruebaExistenProductos(Fabricante fabricante)
        {
            int cantidad = 0;
            try
            {
                conexion.Open();
                string selectSql = "SELECT count(*) as cantidad " +
                                   " FROM producto" +
                                   " WHERE codigo_fabricante in (" +
                                   " Select codigo from fabricante where codigo_fabricante = @codigo_fabricante " +
                                   " ) ";
                SqlCommand command = new SqlCommand(selectSql, conexion);
                //añadimos los valores al select
                command.Parameters.AddWithValue("@codigo_fabricante", fabricante.Codigo);
                //Ejecuta el Select sobre la basde datos
                SqlDataReader registros = command.ExecuteReader();

                registros.Read();
                //Cantidad de productos devueltos de la bd
                cantidad = (int)registros["cantidad"];

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            
            return cantidad;
        }

        //param => textoAbuscar: nombre de fabricante
        public List<Fabricante> GetFabricantesFiltro(string textoAbuscar)
        {
            List<Fabricante> listaFabricantesFitlro = new List<Fabricante>();
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand(CadenasSql.SelectFabricantesFiltro, conexion);
                //añadimos los valores al select
                // los % son porque la consulta cotiene un LIKE
                command.Parameters.AddWithValue("@nombre_fabricante", '%' + textoAbuscar + '%');
                //Ejecuta el Select sobre la basde datos
                SqlDataReader registros = command.ExecuteReader();
                while (registros.Read())
                {
                    Fabricante fabricante = new Fabricante();

                    fabricante.Nombre = (string)registros["nombre"];
                    fabricante.Codigo = (int)registros["codigo"];
                    listaFabricantesFitlro.Add(fabricante);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            conexion.Close();
            return listaFabricantesFitlro;
        }

        public List<Producto> GetProductosFiltro(string textoAbuscar)
        {
            List<Producto> listaProductoFitlro = new List<Producto>();
            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(CadenasSql.SelectProductosFiltro, conexion);
                command.Parameters.AddWithValue("@nombre_producto", '%' + textoAbuscar + '%');
                SqlDataReader registros = command.ExecuteReader();
                while (registros.Read())
                {
                    Producto fabricante = new Producto();

                    fabricante.Nombre = (string)registros["nombre"];
                    fabricante.Codigo = (int)registros["codigo"];
                    listaProductoFitlro.Add(fabricante);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            conexion.Close();
            return listaProductoFitlro;
        }
    }
}
