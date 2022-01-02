//EJERCICIO 1 VIETTI JULIAN

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos variables para el precio del producto, la cantidad de la compra y el descuento posible
            int precio = 0;
            int cantidad = 0;
            float descuento = 0.2f;
   

            //Pedimos al usuario ingresar el precio y la cantidad de productos a comprar
            Console.WriteLine("Ingrese el precio del producto: ");
            precio= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de productos: ");
            cantidad= Convert.ToInt32(Console.ReadLine());

            //Si la cantidad de productos es mayor a 3 obtienen un 20 de descuento. De otra manera solo mostramos el total de la compra
            if (cantidad > 3)
            {
                Console.WriteLine("¡Su compra califica para un descuento del 20%!");
                Console.WriteLine($"Usted debe abonar: {(precio * (1 - descuento)) * cantidad}");
            }
            else {
                Console.WriteLine($"Usted debe abonar: {precio * cantidad}");
            }
 



        }
    }
}
