using modulo4.moduelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo4
{
    internal class Program
    {
     
    static List<Cliente> clientes = new List<Cliente>();
        static int siguienteId = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Sistema de Registro de Clientes del Gimnasio =====");
                Console.WriteLine("1. Dar de alta un cliente");
                Console.WriteLine("2. Mostrar detalles de un cliente");
                Console.WriteLine("3. Listar clientes");
                Console.WriteLine("4. Buscar cliente (Nombre)");
                Console.WriteLine("5. Dar de baja un cliente");
                Console.WriteLine("6. Modificar un cliente");
                Console.WriteLine("7. Salir");
                Console.Write("\nSelecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        DarDeAltaCliente();
                        break;
                    case "2":
                        MostrarDetallesCliente();
                        break;
                    case "3":
                        ListarClientes();
                        break;
                    case "4":
                        BuscarClientePorNombre();
                        break;
                    case "5":
                        DarDeBajaCliente();
                        break;
                    case "6":
                        ModificarCliente();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intenta nuevamente.");
                        break;
                }
            }
        }

        static void DarDeAltaCliente()
        {
            Console.Write("\nNombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine();

            Cliente nuevoCliente = new Cliente
            {
                Id = siguienteId++,
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Teléfono = telefono
            };

            clientes.Add(nuevoCliente);
            Console.WriteLine("\nCliente registrado con éxito.");
            Console.ReadKey();
        }

        static void MostrarDetallesCliente()
        {
            Console.Write("\nIngresa el ID del cliente: ");
            int idCliente;
            if (int.TryParse(Console.ReadLine(), out idCliente))
            {
                var cliente = clientes.FirstOrDefault(c => c.Id == idCliente);
                if (cliente != null)
                {
                    Console.WriteLine($"\nID: {cliente.Id}");
                    Console.WriteLine($"Nombre: {cliente.Nombre} {cliente.Apellido}");
                    Console.WriteLine($"Email: {cliente.Email}");
                    Console.WriteLine($"Teléfono: {cliente.Teléfono}");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID no válido.");
            }

            Console.ReadKey();
        }

        static void ListarClientes()
        {
            if (clientes.Any())
            {
                Console.WriteLine("\nListado de Clientes:");
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"ID: {cliente.Id} - {cliente.Nombre} {cliente.Apellido}");
                }
            }
            else
            {
                Console.WriteLine("No hay clientes registrados.");
            }

            Console.ReadKey();
        }

        static void BuscarClientePorNombre()
        {
            Console.Write("\nIngresa el nombre del cliente a buscar: ");
            string nombreBuscar = Console.ReadLine().ToLower();
            var resultados = clientes.Where(c => c.Nombre.ToLower().Contains(nombreBuscar)).ToList();

            if (resultados.Any())
            {
                Console.WriteLine("\nClientes encontrados:");
                foreach (var cliente in resultados)
                {
                    Console.WriteLine($"ID: {cliente.Id} - {cliente.Nombre} {cliente.Apellido}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron clientes con ese nombre.");
            }

            Console.ReadKey();
        }

        static void DarDeBajaCliente()
        {
            Console.Write("\nIngresa el ID del cliente a dar de baja: ");
            int idCliente;
            if (int.TryParse(Console.ReadLine(), out idCliente))
            {
                var cliente = clientes.FirstOrDefault(c => c.Id == idCliente);
                if (cliente != null)
                {
                    clientes.Remove(cliente);
                    Console.WriteLine("\nCliente dado de baja con éxito.");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID no válido.");
            }

            Console.ReadKey();
        }

        static void ModificarCliente()
        {
            Console.Write("\nIngresa el ID del cliente a modificar: ");
            int idCliente;
            if (int.TryParse(Console.ReadLine(), out idCliente))
            {
                var cliente = clientes.FirstOrDefault(c => c.Id == idCliente);
                if (cliente != null)
                {
                    Console.WriteLine("\nModificar cliente:");
                    Console.Write($"Nombre ({cliente.Nombre}): ");
                    cliente.Nombre = Console.ReadLine();
                    Console.Write($"Apellido ({cliente.Apellido}): ");
                    cliente.Apellido = Console.ReadLine();
                    Console.Write($"Email ({cliente.Email}): ");
                    cliente.Email = Console.ReadLine();
                    Console.Write($"Teléfono ({cliente.Teléfono}): ");
                    cliente.Teléfono = Console.ReadLine();

                    Console.WriteLine("\nCliente modificado con éxito.");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID no válido.");
            }

            Console.ReadKey();
        }
    } }
