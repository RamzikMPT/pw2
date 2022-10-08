using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace практика2
{

    internal class Program
    {

        
        static void Main()
        {
            Console.WriteLine("Введите приложение Игра 'Угадай число'Таблица умножения Вывод делителей числа");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы выбрали угадай число");
                    s();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали таблицу умножения");
                    n();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали вывод делителей числа");
                    t();
                    break;

            }
            static void s()
            {
                
                Random xxx = new Random();

                
                int value = xxx.Next(0, 100);
                int i = value;
                int a;
                do
                {
                    Console.WriteLine("Введите чиcло");
                    a = int.Parse(Console.ReadLine());
                    if (i != a)
                    {
                        if (i > a)
                        {
                            Console.WriteLine("Больше");
                            if (i < a)
                            {
                                Console.WriteLine("Меньше");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Молодец, нашел");
                        }

                    }
                }
                while (a != value);


            }
            static void n()
            {
                Console.WriteLine("Таблица умножения: ");
                Console.ResetColor();
                while (true)
                {
                    int[,] i = new int[9, 9]
                    {
                        {1,2,3,4,5,6,7,8,9},
                        {2,4,6,8,10,12,14,16,18},
                        {3,6,9,12,15,18,21,24,27},
                        {4,8,12,16,20,24,28,32,36},
                        {5,10,15,20,25,30,35,40,45},
                        {6,12,18,24,30,36,42,48,54},
                        {7,14,21,28,35,42,49,56,63},
                        {8,16,24,32,40,48,56,64,72},
                        {9,18,27,36,45,54,64,72,81}
                    };
                    for (int q = 0; q < i.GetLength(0); q++)
                    {
                        for (int o = 0; o < i.GetLength(1); o++)
                        {
                            if (i[q, o] < 10)
                            {
                                Console.Write(i[q, o] + "    ");
                            }
                            else
                            {
                                Console.Write(i[q, o] + "   ");
                            }
                        }
                        Console.WriteLine();
                    }
                   
                    break;
                }
            }
        }
         static void t()
        {

            Console.WriteLine("Введите чиcло");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = p; i > 0; i--)
            {
                {
                    if (p % i == 0)
                    {
                        Console.Write(p / i + " / ");
                    }
                }
            }
            
        }
    }
}
