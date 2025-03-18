using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea03Pokemon.Clases;
using Tarea03Pokemon.Tienda.Clases;
using Tarea03Pokemon.Tienda.Database;

namespace Tarea03Pokemon.Tienda
{
    //Esta clase fue un intento de controlar 
    // Tengo que buscar otra forma, esta no me convence
    public class MainTienda
    {
        BindingList<Fabricante> listaFabricantes = new BindingList<Fabricante>();
        public BindingList<Fabricante> ListaFabricantes { get => listaFabricantes; set => listaFabricantes = value; }
               BindingList<Producto> listaProductos = new BindingList<Producto>();
        public BindingList<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
               FabricanteDatabase fabricanteDatabase = new FabricanteDatabase();

        public BindingList<Producto> GetProductos()
        {
            listaProductos.Clear();
            listaProductos = fabricanteDatabase.obtenerProductos();
            return listaProductos;
        }
        public BindingList<Fabricante> Getfabricantes()
        {
            ListaFabricantes.Clear();
            ListaFabricantes = fabricanteDatabase.obtenerFabricantes();
            return ListaFabricantes;
        }

        public string GetFabricantesFiltro(string textoAbuscar)
        {
            var listaFabricantesFiltro = fabricanteDatabase.GetFabricantesFiltro(textoAbuscar);
            string lineasFichero = "";
            foreach (Fabricante item in listaFabricantesFiltro)
            {
                lineasFichero += item.Nombre + "\r\n";
            }

            return lineasFichero;
        }

        internal string GetProductosFiltro(string textoAbuscar)
        {            
           var listaProductosFiltro = fabricanteDatabase.GetProductosFiltro(textoAbuscar);

            string lineasFichero = "";
            foreach (Producto item in listaProductosFiltro)
            {
                lineasFichero += item.Nombre + "\r\n";
            }
            
            return lineasFichero;
        }

        public string BorrarFabricante(Fabricante fabricante)
        {
            
            return fabricanteDatabase.BorrarFabricante(fabricante);
        }
        public string BorrarFabricanteyProductos(Fabricante fabricante)
        {
            string resultado = "NOK";            
            var countBorrados =  fabricanteDatabase.BorrarProductosFabricante(fabricante);

            if(countBorrados > 0)
            {
                resultado = BorrarFabricante(fabricante);
                ListaFabricantes.Clear();                
                ListaFabricantes = fabricanteDatabase.obtenerFabricantes();
                ListaProductos.Clear();
                ListaProductos = fabricanteDatabase.obtenerProductos();
            }
            return resultado;
        }

        public void BorrarProducto(Producto producto)
        {
            fabricanteDatabase.BorrarProducto(producto);
            ListaProductos.Clear();
            ListaProductos = fabricanteDatabase.obtenerProductos();
        }
        public void BorrarFabricanteSinProductos(Fabricante fabricante)
        {
            fabricanteDatabase.BorrarFabricante(fabricante);
            ListaFabricantes.Clear();
            ListaFabricantes = fabricanteDatabase.obtenerFabricantes();
        }

    }
}
