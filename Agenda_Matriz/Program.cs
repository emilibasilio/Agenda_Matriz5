using System;

namespace Agenda_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,]mat= new string[5, 15];
            char OP='s';
            int op;

            while (OP == 's')
            {
                mat[0, 0] = "Nombre";
                mat[1, 0] = "Apellido";
                mat[2, 0] = "Direccion";
                mat[3, 0] = "Telefono";
                mat[4, 0] = "Correo";

                Console.Clear();
                Console.WriteLine("Qué Desea Hacer:\n 1.Ingresar Contacto\n 2.Mostrar Contactos\n 3.Buscar");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese los siguientes datos: Nombre, Apellido, Direccion, Telefono, Correo\n");
                    for (int f = 1; f < 15; f++)
                    {
                        for (int c = 0; c < 5; c++)
                        {
                            Console.Write("Ingrese Nota [Valor:" + (f) + ", Dato:" + (c + 1) + "]: ");

                            mat[c,f] = Console.ReadLine();
                        }
                    }
                }
                if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nDatos de los Contactos: ");
                    for (int f = 0; f < 15; f++)
                    {
                        Console.WriteLine(mat[0, f] + " " + mat[1, f] + " " + mat[2, f] + " " + mat[3, f] + " " + mat[4, f]);
                    }
                }

                if(op == 3)
                {
                    int a, b;
                    Console.Clear();
                    Console.WriteLine("Seleccione El Número de Contacto que Desea Buscar:\n");
                    a = int.Parse(Console.ReadLine());
                    Console.Clear();               
                    Console.WriteLine("El Contacto que buscaba es: " + mat[0, a]+" "+mat[1, a]+ " " +mat[2, a]+ " " +mat[3, a]+ " " +mat[4, a]);
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Desea Regresar al Menú Principal [s/n]");
                OP = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
    