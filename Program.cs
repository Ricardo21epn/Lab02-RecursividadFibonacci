using System;
using System.Diagnostics;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timeMeasure = new Stopwatch();
            string title = "\tPROGRAMA DE NUMEROS PRIMOS \nIngresa un numero:";
            string final = "";
            Console.WriteLine(title);
            int inputNumber = int.Parse(Console.ReadLine());
            int aux = 2;
            int counter = 0;
            timeMeasure.Start();
            while (aux <= inputNumber)
            {
                for (int i = 1; i <= aux; i++)
                {
                    if (aux%i == 0)
                    {
                        counter++;
                    }
                    if (counter>2)
                    {
                        break;
                    }
                }
                if (counter == 2)
                {
                    final += aux + " ";
                }
                counter = 0;
                aux++;
            }
        Console.WriteLine(final);
        timeMeasure.Stop();
        Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }
    }
}
