//EJERCICIO 2 VIETTI JULIAN

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos variables para el estado civil, el sueldo y las posibles ganancias
            int estado = 0;
            int sueldo = 0;
            float ganancias = 0;

            //Pedimos al usuario ingresar su estado civil a traves de numeros y lo guardamos en la variable estado
            Console.WriteLine("Ingrese el numero de su estado civil: ");
            Console.WriteLine(" 1 = Soltero \n 2 = Casado \n 3 = Divorciado \n 4 = Viudo");
            estado = Convert.ToInt32(Console.ReadLine());
            
            /*Evaluamos el estado ingresado por el usuario. En caso de que no sea valido no podra avanzar*/
            while (estado > 4 || estado < 1) {
                Console.WriteLine("\n\nEstado incorrecto. Ingrese un estado valido");
                Console.WriteLine(" 1 = Soltero \n 2 = Casado \n 3 = Divorciado \n 4 = Viudo");
                estado = Convert.ToInt32(Console.ReadLine());
            }
            
            /*Pedimos al usuario ingresar su sueldo y lo guardamos en la variable sueldo*/
            Console.WriteLine("\nIngrese su sueldo: ");
            sueldo = Convert.ToInt32(Console.ReadLine());

            /*Evaluamos con un switch la variable estado*/
            switch (estado) { 
            
                /*En caso de que su estado sea soltero y su sueldo mayor a 85000, entonces debe pagar 10%
                 en ganancias.*/
                case 1:
                    if (sueldo > 85000)
                    {
                        ganancias = 0.1f;
                        Console.WriteLine($"Usted debe pagar ${(sueldo - 85000) * ganancias} en ganancias.");
                    }
                    else {
                        Console.WriteLine("Usted no debe pagar ganancias");
                    }
                    break;

                /*En caso de que su estado sea casado y su sueldo mayor a 96000, entonces debe pagar 8%
                en ganancias.*/
                case 2:
                    if (sueldo > 96000)
                    {
                        ganancias = 0.08f;
                        Console.WriteLine($"Usted debe pagar ${(sueldo - 96000) * ganancias} en ganancias.");
                    }
                    else {
                        Console.WriteLine("Usted no debe pagar ganancias");
                    }
                    break;

                /*En caso de que su estado no sea casado ni soltero entonces no debe pagar ganancias sobre 
                 su sueldo.*/
                default:
                    Console.WriteLine("Usted no debe pagar ganancias");
                    break;


                
            }
            
        }
    }
}
