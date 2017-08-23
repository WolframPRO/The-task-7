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

            List<int>[] mass = new List<int>[SIZE*SIZE];
            int a = 1;
            for (int n = 0; n < SIZE * SIZE - 1; n++)
            {
                mass[n] = perevod(n);
            }

            Console.WriteLine();

            for (int i = 0; i < (SIZE * SIZE - 1); i++)
            {
                mass[i].ForEach(Console.Write);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static List<int> perevod(int temp)
        {
            int temp1 = 0;
            List<int> s = new List<int>();
            while (temp > 0)
            {
                temp1 = temp % 2;
                temp = temp / 2;
                s.Add(temp1);
            }
            return (s);
        }
    }
}
