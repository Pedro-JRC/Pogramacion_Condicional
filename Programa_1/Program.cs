using System;
using System.ComponentModel.Design;

namespace CondicionalAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            int numero1;
            int numero2;
            int suma;
            int resta;
            int producto;
            int cociente;

            

            // SOLICITUD DEL PRIMER NUMERO
            Console.WriteLine("Favor introducir el primer numero.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            // SOLICITUD DEL SEGUNDO NUMERO
            Console.WriteLine("Favor introducir el segundo numero.");
            numero2 = Convert.ToInt32(Console.ReadLine());

            // OPERACIONES A REALIZAR SEGUN CONDICION
            if (numero1 > numero2)

            {
                // REALIZA UNA SUMA Y UNA RESTA SI NUMERO 1 ES MAYOR A NUMERO2
                suma = numero1 + numero2;
                resta = numero1 - numero2;
                Console.WriteLine($"La suma de { numero1 } y { numero2 } es igual a: { suma }");
                Console.WriteLine($"La resta de { numero1 } y { numero2 } es igual a: { resta }");
            }
            
            else
            
            {
                // CALCULA EL PRODUCTO Y COCIENTE SI NUMERO 1 ES MENOR A NUMERO 2
                producto = numero1 * numero2;
                cociente = numero2 / numero1;
                Console.WriteLine($"El producto de { numero1 } y { numero2 } es igual a: { producto }");
                Console.WriteLine($"El cociente de { numero1 } y { numero2 } es igual a: { cociente }");
            }
        }
    }
}
