using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinaElNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int er = 0;
            Random rnd = new Random();
            int numAlt=rnd.Next(1,101);
            //se genera el numero aleatorio entre uno y cien, el limite que es ciento uno no cuenta
            Console.WriteLine("======<Hola mundo>======");
            Console.WriteLine("A continuacion haremos un divertido juego\nadivina el numero entre 1 y 100");
            int intento=Int32.Parse(Console.ReadLine());

            

            /* uso de bucle indefinido while porque no sabemos cuantos 
             * intentos hara el usuario*/

            while ( numAlt!= intento)
            {
                Console.WriteLine("Incorrecto");
                if (numAlt < intento)
                {
                    Console.WriteLine("El numero que buscas es menor");
                    Console.WriteLine("Intente con otro numero");
                    intento=int.Parse(Console.ReadLine());
                }
                else if (numAlt > intento)
                {
                    Console.WriteLine("El numero que buscas es mayor");
                    Console.WriteLine("Intente con otro numero");
                    intento = int.Parse(Console.ReadLine());
                }
                er++;
            }

            Console.WriteLine($"\nCorrecto!!! El numeor que buscabas era {numAlt}");

            if (er >= 1) 
                Console.WriteLine($"Te equivocaste {er} veces");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();

        }
    }
}
