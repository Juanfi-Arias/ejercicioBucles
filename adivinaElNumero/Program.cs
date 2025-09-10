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
            int er = 0, intento = 0;
            Random rnd = new Random(); //se crea el obj random name: rnd
            int numAlt=rnd.Next(1,101);//se genera el numero aleatorio entre uno y cien, el limite que es ciento uno no cuenta
            Console.WriteLine("======<Hola mundo>======");
            Console.WriteLine("A continuacion haremos un divertido juego\nadivina el numero entre 1 y 100");
            /* uso de bucle indefinido while porque no sabemos cuantos 
             * intentos hara el usuario*/

            while ( numAlt!= intento)
            {
                try
                {
                    intento = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ingresaste una letra, no un numero");
                    Console.WriteLine("Se iniciara el valor en 0");
                    intento = 0;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("El numero es demaciado grande");
                    Console.WriteLine("Se iniciara el valor en 0");
                    intento = 0;
                }

                if (numAlt < intento)
                    Console.WriteLine("El numero que buscas es menor");

                else if (numAlt > intento)
                    Console.WriteLine("El numero que buscas es mayor");

                er++;
            }

            Console.WriteLine($"\nCorrecto!!! El numeor que buscabas era {numAlt}, te tomaste {er} intentos");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }
    }
}
