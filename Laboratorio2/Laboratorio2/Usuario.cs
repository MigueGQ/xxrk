using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Usuario
    {
        public int id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contra { get; set; }
        public int Edad { get; set; }
        public string Nivel { get; set; }

        private Supermercado supermercado;

        public void CrearCategoria(string nombre)
        {
            Categoria categoria = new Categoria { Nombre = nombre };
            supermercado.AgregarCategoria(categoria);
        }

        public void CrearProducto(string nombre, string proveedor, DateTime fechaCaducidad, DateTime fechaEntrada, string detalles, decimal precio, int unidadesDisponibles)
        {
            Producto producto = new Producto
            {
                Nombre = nombre,
                Proveedor = proveedor,
                FechaCaducidad = fechaCaducidad,
                FechaEntrada = fechaEntrada,
                Detalles = detalles,
                Precio = precio,
                UnidadesDisponibles = unidadesDisponibles
            };
            supermercado.AgregarProducto(producto);
        }

        public void EliminarCategoria(string nombre)
        {
            Categoria categoria = supermercado.BuscarCategoria(nombre);
            supermercado.EliminarCategoria(categoria);
        }

        public void EliminarProducto(string nombre)
        {
            Producto producto = supermercado.BuscarProducto(nombre);
            supermercado.EliminarProducto(producto);
        }

        public Categoria BuscarCategoria(string nombre)
        {
            return supermercado.BuscarCategoria(nombre);
        }

        public Producto BuscarProducto(string nombre)
        {
            return supermercado.BuscarProducto(nombre);
        }

        public void VerCategorias()
        {
            Console.WriteLine("Categorías:");
            foreach (Categoria categoria in supermercado.Categorias)
            {
                Console.WriteLine(categoria.Nombre);
            }
        }

        public void VerProductos()
        {
            Console.WriteLine("Productos:");
            foreach (Producto producto in supermercado.Productos)
            {
                Console.WriteLine(producto.Nombre);
            }
        }

        public void RealizarVenta(string nombreCliente, string detallesProducto, decimal totalPagar)
        {
            Venta venta = new Venta
            {
                NombreCliente = nombreCliente,
                DetallesProducto = detallesProducto,
                TotalPagar = totalPagar
            };

        }

        public Usuario (int id, string nombre, string contra, int edad, string nivel, Supermercado supermercado)
        {
            this.id = id;
            this.NombreUsuario = nombre;
            this.Contra = contra;
            this.Edad = edad;
            this.Nivel = nivel;
            this.supermercado = supermercado;
        }
    }
}
