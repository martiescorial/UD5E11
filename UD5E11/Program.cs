using System;

namespace UD5E11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            int suma = 0;

            foreach (int i in array)
            {
                string posicion = "Inserta un numero en la posicion " + i;

                array[i] = Convert.ToInt32(posicion);

                suma =+ i;

                Console.WriteLine("La suma es" + suma);
            }


            
        }
    }
}
