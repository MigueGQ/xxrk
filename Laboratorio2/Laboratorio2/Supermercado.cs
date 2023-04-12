using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Supermercado
    {
        public List<Categoria> Categorias { get; set; }
        public List<Producto> Productos { get; set; }

        public Supermercado()
        {
            Categorias = new List<Categoria>();
            Productos = new List<Producto>();
        }

        public void AgregarCategoria(Categoria categoria)
        {
            Categorias.Add(categoria);
        }

        public void EliminarCategoria(Categoria categoria)
        {
            Categorias.Remove(categoria);
        }

        public Categoria BuscarCategoria(string nombre)
        {
            return Categorias.Find(c => c.Nombre == nombre);
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            Productos.Remove(producto);
        }

        public Producto BuscarProducto(string nombre)
        {
            return Productos.Find(p => p.Nombre == nombre);
        }

    }
}

