using System;
using System.Collections.Generic;

namespace MapeoEntidad
{
    class Program
    {
        static List<string> data = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Agregar dato");
                Console.WriteLine("2. Eliminar dato");
                Console.WriteLine("3. Actualizar dato");
                Console.WriteLine("4. Mostrar datos");
                Console.WriteLine("5. Salir del programa");

                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            AgregarDato();
                            break;
                        case 2:
                            EliminarDato();
                            break;
                        case 3:
                            ActualizarDato();
                            break;
                        case 4:
                            MostrarDatos();
                            break;
                        case 5:
                            Console.WriteLine("\nSaliendo del programa...");
                            return;
                        default:
                            Console.WriteLine("\nError: Por favor, seleccione una opción válida.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Por favor, ingrese un número válido.");
                }
            }
        }

        static void AgregarDato()
        {
            Console.Write("\nIngrese el nuevo dato: ");
            string newData = Console.ReadLine();
            data.Add(newData);
            Console.WriteLine("\nEl nuevo dato ha sido agregado.");
        }

        static void EliminarDato()
        {
            Console.Write("\nIngrese el dato a eliminar: ");
            string removeData = Console.ReadLine();
            if (data.Contains(removeData))
            {
                data.Remove(removeData);
                Console.WriteLine("\nEl dato ha sido eliminado.");
            }
            else
            {
                Console.WriteLine("\nError: El dato ingresado no se encuentra en la lista.");
            }
        }

        static void ActualizarDato()
        {
            Console.Write("\nIngrese el dato a actualizar: ");
            string oldData = Console.ReadLine();
            Console.Write("\nIngrese el nuevo dato: ");
            string updatedData = Console.ReadLine();
            int index = data.IndexOf(oldData);
            if (index != -1)
            {
                data[index] = updatedData;
                Console.WriteLine("\nEl dato ha sido actualizado.");
            }
            else
            {
                Console.WriteLine("\nError: El dato ingresado no se encuentra en la lista.");
            }
        }

        static void MostrarDatos()
        {
            Console.WriteLine("\nDatos en la lista:");
            foreach (string item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}


	