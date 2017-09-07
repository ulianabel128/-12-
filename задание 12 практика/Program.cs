using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_12_практика
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            int n; //кол-во элементов в массивах

            do
            {
                Console.WriteLine("Введите n");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out n);
                if (n < 1) ok = false;
                if (!ok) Console.WriteLine("Неверный ввод, повторите ввод");
            } while (!ok);

            int[] upor_voz = new int[n];
            int[] upor_ubv = new int[n];
            int[] neupor = new int[n];

            int x = 10;
            Random random = new Random();

            for (int i=0; i<upor_voz.Length; i++)
            {
                upor_voz[i] = x;
                x++;
            }

            for (int i = 0; i < upor_ubv.Length; i++)
            {
                upor_ubv[i] = x;
                x--;
            }

            for (int i=0; i< neupor.Length; i++)
            {
                neupor[i] = random.Next(100);
            }

            Console.WriteLine("Массив по возрастанию:");
            for (int i = 0; i < upor_voz.Length; i++)
            {
                Console.WriteLine(upor_voz[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Массив по убыванию:");
            for (int i = 0; i < upor_ubv.Length; i++)
            {
                Console.WriteLine(upor_ubv[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Неупорядоченный массив:");
            for (int i = 0; i < neupor.Length; i++)
            {
                Console.Write(neupor[i] + " ");
            }



            Console.ReadKey();

        }
    }
}
