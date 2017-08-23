using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину кодовых слов: ");
            bool ok;
            int SIZE;

            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out SIZE);
                if (!ok) Console.WriteLine("Ошибка ввода данных!");
                if (SIZE < 1)
                {
                    Console.WriteLine("Ошибка длины строки!");
                    ok = false;
                }
            } while (!ok); //ввода размера слов

            List<string>[] mass = new List<string>[SIZE*SIZE];
            int a = 1;
            for (int n = 0; n < SIZE * SIZE; n++)
            {
                mass[n] = perevod(n, SIZE);
            }

            Console.WriteLine();



            for (int i = 0; i < (SIZE * SIZE); i++)
            {
                mass[i].ForEach(Console.Write);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static List<string> perevod(int temp, int S)
        {
            int temp1 = 0;
            List<string> s = new List<string>();
            while (temp > 0)
            {
                temp1 = temp % 2;
                temp = temp / 2;
                s.Add(temp1.ToString());
            }
         //   s.Reverse();
          
            while(s.Count < S)
                s.Add("0");
            return (s);
        }
    }
}
