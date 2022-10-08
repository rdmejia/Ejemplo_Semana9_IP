using System;

namespace L9_RDMA_25873
{
    class Program
    {
        static void manejarOpcion(int opcion, Automovil automovil)
        {
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un nuevo modelo: ");
                    automovil.modelo = int.Parse(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Ingrese el nuevo precio: ");
                    automovil.precio = double.Parse(Console.ReadLine());
                    break;

                case 3:
                    Console.Write("Ingrese la marca: ");
                    automovil.marca = Console.ReadLine();
                    break;

                case 4:
                    Console.Write("Sigue disponible? (si o no): ");

                    string disponible = Console.ReadLine();

                    if (disponible.Equals("si"))
                    {
                        automovil.disponible = true;
                    }
                    else if (disponible.Equals("no"))
                    {
                        automovil.disponible = false;
                    }
                    else
                    {
                        Console.WriteLine(disponible + " no es una opcion valida");
                        Console.ReadKey();
                    }

                    break;

                case 5:
                    Console.Write("Ingrese el nuevo tipo de cambio: ");
                    automovil.tipoDeCambioDolar = double.Parse(Console.ReadLine());
                    break;

                case 6:
                    Console.Write("Ingrese el nuevo descuento: ");
                    automovil.descuentoAplicado = double.Parse(Console.ReadLine());
                    break;

                case 0:
                    Console.WriteLine("Adios!");
                    break;

                default:
                    Console.WriteLine(opcion + " no es una opcion valida");
                    break;
            }
        }

        static void mostrarAutomovil(Automovil automovil)
        {
            Console.Clear();
            Console.WriteLine("Modelo: " + automovil.modelo);
            Console.WriteLine("Marca: " + automovil.marca);
            Console.WriteLine("Precio: Q" + automovil.ObtenerPrecio());
            Console.WriteLine("Precio en dolares: $" + automovil.ObtenerPrecioEnDolares());

            if (automovil.disponible)
            {
                Console.WriteLine("Disponible.");
            }
            else
            {
                Console.WriteLine("No disponible.");
            }
        }

        static void Main(string[] args)
        {
            Automovil objAutomovil =
                new Automovil(2022, 150000, "Mercedes Benz", true, 7.73);

            int opcion;

            do
            {
                Console.WriteLine("1. Cambiar el modelo");
                Console.WriteLine("2. Cambiar el precio");
                Console.WriteLine("3. Cambiar la marca");
                Console.WriteLine("4. Cambiar la disponibilidad");
                Console.WriteLine("5. Cambiar el tipo de cambio");
                Console.WriteLine("6. Aplicar descuento");
                Console.WriteLine("0. Salir");

                Console.Write("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                manejarOpcion(opcion, objAutomovil);

                mostrarAutomovil(objAutomovil);

                Console.WriteLine();
                Console.Write("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 0);

        }
    }
}
