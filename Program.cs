using Sysdfgtem;
using System.Colghhfglections.Generic;
using System.Lidfhfgnq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i=0;i<n;i++) 
            {
                Console.WriteLine("Enter a[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("=============");
            for (int i=0;i<n-1;i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine(array[n-1]);

            Console.WriteLine($"{Environment.NewLine}============{Environment.NewLine}");

            int min = int.MaxValue;//0;
            int max = int.MinValue;//0;

            for (int i=0;i<n;i++) 
            {
                if (array[i]>max) 
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("max: {0}", max);
            Console.WriteLine("min: {0}", min);

            for (int i=0;i<n-1;i++) 
            {

                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j]>array[j+1]) 
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                PrintArray();
            }

            Console.ReadKey();
        }

        static void PrintArray(int[] array, int? min = null, int? max=null) 
        {
            var n = array.Length - 1;
            for (int i = 0; i < n; i++)
            {
                if (min.HasValue && array[i] == min.Value)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(array[i]);
                    Console.ResetColor();

                }
                else
                if (max.HasValue && array[i] == max.Value)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(array[i]);
                    Console.ResetColor();

                }
                else 
                {
                    Console.Write(array[i]);
                }

                //Console.Write(array[i]);
                Console.Write(", ");
            }
            Console.WriteLine(array[n]);
        }

        static void PrintNumber(int number, int? min=null, int? max=null)
        {
            if (min.HasValue && array[i] == min.Value)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(array[i]);
                Console.ResetColor();

            }
            else
                if (max.HasValue && array[i] == max.Value)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(array[i]);
                Console.ResetColor();

            }
            else
            {
                Console.Write(array[i]);
            }
        }

        static int ReadNumberFromConsole() 
        {
            int number = default(int);
            while (!int.TryParse(Console.ReadLine(), out number)) 
            {
                Console.WriteLine("Incorrect number, try again");
            }
            return number;
        }
    }
}
