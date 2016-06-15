using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialRGS
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 2;
        [Flags]
        enum precio
        {
            Bajo = 100,
            MedioBajo = 1000,
            Medio = 5000,
            MedioAlto = 1000,
            Alto = 20000,
        };
        struct Almacen
        {
            public int idA;
            public string nameA;
            public string tipo;
            public string fechavencimiento;
            public string proveedor;
            public string estante;
            public double precio;
        };

        static Almacen[] almacen;

        static void AddProducto()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < almacen.Length)
                {
                    Console.WriteLine("-* Global Machines  *-*");
                    Console.WriteLine("Ingreso de producto.             ");
                    Console.Write("Digite el ID:                  ");
                    almacen[i].idA = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del producto:    ");
                    almacen[i].nameA = Console.ReadLine();
                    Console.Write("Digite el tipo de producto:     ");
                    almacen[i].tipo = Console.ReadLine();
                    Console.Write("Digite la fecha de vencimiento: ");
                    almacen[i].fechavencimiento = Console.ReadLine();
                    Console.Write("Digite el nombre del proveedor:    ");
                    almacen[i].proveedor = Console.ReadLine();
                    Console.Write("Digite la posicion del estante: ");
                    almacen[i].estante = Console.ReadLine();
                    Console.WriteLine("Seleccione el precio del producto:");
                    Console.Write(precio.Bajo + ":" + (int)precio.Bajo + "\n" +
                                  precio.MedioBajo + ":" + (int)precio.MedioBajo + "\n" +
                                  precio.Medio + ":" + (int)precio.Medio + "\n" +
                                  precio.MedioAlto + ":" + (int)precio.MedioAlto + "\n" +
                                  precio.Alto + ":" + (int)precio.Alto + "\n");
                    Console.Write("Ingrese el Precio: ");
                    almacen[i].precio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Precio " + almacen[i].precio);
                    Console.WriteLine("Desea agregar otro producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de libros lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void ModProducto()
        {
            
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("Digite el ID del producto a modificar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < almacen.Length; i++)
                {
                    if (ID == almacen[i].idA)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("ID:       " + almacen[i].idA);
                        Console.Write("Nuevo ID: ");
                        almacen[i].idA =int.Parse( Console.ReadLine());
                        Console.WriteLine("Nombre:   " + almacen[i].nameA);
                        Console.Write("Nuevo nombre:  ");
                        almacen[i].nameA = Console.ReadLine();
                        Console.WriteLine("Tipo:     " + almacen[i].tipo);
                        Console.Write("Nuevo Tipo:     ");
                        almacen[i].tipo = Console.ReadLine();
                        Console.WriteLine("Proveedor:    "+ almacen[i].proveedor);
                        Console.Write("Nuevo proveedor: ");
                        almacen[i].proveedor = Console.ReadLine();
                        Console.WriteLine("Posicion del estante: "+almacen[i].estante);
                        Console.Write("Nuevo estante: ");
                        almacen[i].estante = Console.ReadLine();
                        Console.WriteLine("Precio:   " + almacen[i].precio);
                        Console.WriteLine("Escoja un nuevo precio:   ");
                        Console.Write(precio.Bajo + ":" + (int)precio.Bajo + "\n" +
                                  precio.MedioBajo + ":" + (int)precio.MedioBajo + "\n" +
                                  precio.Medio + ":" + (int)precio.Medio + "\n" +
                                  precio.MedioAlto + ":" + (int)precio.MedioAlto + "\n" +
                                  precio.Alto + ":" + (int)precio.Alto + "\n");
                        Console.Write("Ingrese el Precio: ");
                        almacen[i].precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Precio " + almacen[i].precio);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea modificar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void EliProducto()
        {

            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("Digite el ID del producto a eliminar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < almacen.Length; i++)
                {
                    if (ID == almacen[i].idA)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        
                        Console.WriteLine("ID:       " + almacen[i].idA);
                        Console.Write("Eliminar ID: ");
                        almacen[i].idA = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre:   " + almacen[i].nameA);
                        Console.Write("Eliminar nombre:  ");
                        almacen[i].nameA = Console.ReadLine();
                        Console.WriteLine("Tipo:     " + almacen[i].tipo);
                        Console.Write("Eliminar Tipo:     ");
                        almacen[i].tipo = Console.ReadLine();
                        Console.WriteLine("Proveedor:    " + almacen[i].proveedor);
                        Console.Write("Eliminar proveedor: ");
                        almacen[i].proveedor = Console.ReadLine();
                        Console.WriteLine("Posicion del estante: " + almacen[i].estante);
                        Console.Write("Eliminar estante: ");
                        almacen[i].estante = Console.ReadLine();
                        Console.WriteLine("Precio:   " + almacen[i].precio);
                        Console.WriteLine("Escoja un nuevo precio:   ");
                        Console.Write(precio.Bajo + ":" + (int)precio.Bajo + "\n" +
                                  precio.MedioBajo + ":" + (int)precio.MedioBajo + "\n" +
                                  precio.Medio + ":" + (int)precio.Medio + "\n" +
                                  precio.MedioAlto + ":" + (int)precio.MedioAlto + "\n" +
                                  precio.Alto + ":" + (int)precio.Alto + "\n");
                        Console.Write("Ingrese el Precio: ");
                        almacen[i].precio = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Eliminar Precio " + almacen[i].precio);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea modificar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void BusquedaProductos()
        {
            int reg = 0;
            int ID = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            { 
                Console.Clear();
            Console.WriteLine("-* Global Machines  *-*");
            Console.WriteLine("Listado de productos.             ");
            Console.WriteLine("Digite el ID del libro a buscar");
            ID = int.Parse(Console.ReadLine());
            for (i = 0; i < almacen.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("ID:       " + almacen[i].idA);
                Console.WriteLine("Nombre:   " + almacen[i].nameA);
                Console.WriteLine("Tipo:     " + almacen[i].tipo);
                Console.WriteLine("Fecha de vencimiento:     " + almacen[i].fechavencimiento);
                Console.WriteLine("Proveedor:     " + almacen[i].proveedor);
                Console.WriteLine("Posicion:     " + almacen[i].estante);
                Console.WriteLine("Precio:   " + almacen[i].precio);
            }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());

            }
            Console.ReadKey();
        }

        static void ListaProductos()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("-* Global Machines  *-*");
            Console.WriteLine("Listado de productos.             ");
            for (i = 0; i < almacen.Length; i++)
            {
                reg = i + 1;
                /* Console.WriteLine("Registro: " + reg);
                 Console.WriteLine("ID:       " + almacen[i].idA);
                 Console.WriteLine("Nombre:   " + almacen[i].nameA);
                 Console.WriteLine("Tipo:     " + almacen[i].tipo);
                 Console.WriteLine("Fecha de vencimiento:     " + almacen[i].fechavencimiento);
                 Console.WriteLine("Proveedor:     " + almacen[i].proveedor);
                 Console.WriteLine("Posicion:     " + almacen[i].estante);
                 Console.WriteLine("Precio:   " + almacen[i].precio);*/

               
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("Listado de productos.             ");
                Console.WriteLine("Regi      id      nombre       tipo      vencimiento    proveedor   posicion   precio");
                Console.WriteLine(+ reg + "         " + almacen[i].idA + "       " + almacen[i].nameA + "       " + almacen[i].tipo + "        " + almacen[i].fechavencimiento + "       " + almacen[i].proveedor + "     " + almacen[i].estante + "     " + almacen[i].precio);
                Console.WriteLine("========");
            }

            Console.ReadKey();
        }

        static void VentaProducto()
        {
            string name = " ";
            int telefono;
            string numero = "n°0000";
            int venta = 0;
            int pre, des, vdes, iv, tot;
            int mr, mc;
            Console.Clear();
            Console.WriteLine("-* Global Machines  *-*");
            Console.WriteLine("Listado de productos.             ");
            for (i = 0; i < almacen.Length; i++)
            {
                venta = int.Parse(Console.ReadLine());
                pre = 3000 * venta;
                des = 15;
                vdes = (pre * des) / 100;
                iv = ((pre - vdes) * 13) / 100;
                tot = pre - vdes + iv;
                Console.Write("Item                        ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");

                Console.WriteLine("Doritos.          " + venta + "        " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Cantidad con la que cancela");
                mr = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);

                Console.Clear();

                Console.WriteLine("=======================================");
                Console.WriteLine("*.*          Global Machines         *.*");
                Console.WriteLine("=======================================");
                numero = numero + 1;
                Console.WriteLine("Factura Proforma                   " + numero);
                Console.Write("Cliente:");
                name = Console.ReadLine();
                Console.Write("Teléfono: ");
                telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                Console.Write("Item                        ");
                Console.Write("Cantidad     ");
                Console.Write("Precio      ");
                Console.WriteLine("Subtotal");
                Console.WriteLine("Doritos.          " + venta + "        " + pre + "          " + pre);
                Console.WriteLine("-----------");
                Console.WriteLine("Total de la orden:                        " + pre);
                Console.WriteLine("Descuento:                                " + vdes);
                Console.WriteLine("Impuesto de venta:                           13%");
                Console.WriteLine("Impuesto Total:                           " + iv);
                Console.WriteLine("Precio Neto:                              " + tot);
                Console.WriteLine("---------------------");
                Console.WriteLine("Monto Recibido:     " + mr);
                mc = mr - tot;
                Console.WriteLine("Monto Cambio:       " + mc);
                Console.WriteLine("================================");
                Console.WriteLine("Gracias por su compra.");
            }
        }
    

        static void Main(string[] args)
        {
            almacen = new Almacen[size];
            do
            {
                Console.Clear();
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("1. Ingreso de producto.");
                Console.WriteLine("2. Modificación de producto.");
                Console.WriteLine("3. Eliminación de producto.");
                Console.WriteLine("4. Búsquedas de producto.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddProducto();
                            break;
                        }
                    case 2:
                        {
                            ModProducto();
                            break;
                        }
                    case 3:
                        {
                            EliProducto();
                            break;
                        }
                    case 4:
                        {
                           BusquedaProductos();
                            break;
                        }
                    case 5:
                        {
                            ListaProductos();
                            break;
                        }
                    case 6:
                        {
                            VentaProducto();
                            break;
                        }
                    case 7:
                   
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}