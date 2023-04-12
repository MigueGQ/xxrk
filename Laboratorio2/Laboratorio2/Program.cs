using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermercado supermercado = new Supermercado();
            Usuario[] usuario = new Usuario[2];

            //Crear usuarios
            usuario[0] = new Usuario(1, "SU", "Tomatito123", 22, "Admin", supermercado);
            usuario[1] = new Usuario(2, "Bob", "1234", 25, "Vendedor", supermercado);

            Console.WriteLine("Bienvenido, inicie sesion");
            Console.WriteLine("Nombre de usuario");
            string User = Console.ReadLine();
            Console.WriteLine("Contraseña");
            string Pass = Console.ReadLine();

            int Nivel=0;
            for (int i = 0; i < usuario.Length; i++)
            {
                if (User == usuario[i].NombreUsuario && Pass == usuario[i].Contra)
                {
                    if (usuario[i].Nivel == "Admin")
                    {
                        Nivel = 1;
                    }
                    if (usuario[i].Nivel == "Vendedor")
                    {
                        Nivel = 2;
                    }
                }
            }

            if (Nivel == 1)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("¨1) Agregar categoria");
                Console.WriteLine("¨2) Agregar categoria");
                Console.WriteLine("¨3) Crear categoria");
                Console.WriteLine("¿Qué desea hacer?");
            }
            Console.WriteLine(Nivel);
            Console.ReadLine();
        }
    }
}
