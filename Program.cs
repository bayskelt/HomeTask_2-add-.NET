using System;
namespace HomeTask_2_add_.NET
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введiть будь-яке тризначне цiле число: ");
            int numeric = int.Parse(Console.ReadLine());

            int digit_1 = numeric / 100;
            int digit_2 = (numeric / 10) % 10;
            int digit_3 = numeric % 10;

            Console.Write("Максимально можливе число iз цифр: ");

            if (digit_1 >= Math.Max(digit_2, digit_3))
            {
                if (digit_2 >= digit_3)
                {
                    Console.Write($"{digit_1}{digit_2}{digit_3}");  /* 1>2>3 */
                }
                else
                {
                    Console.Write($"{digit_1}{digit_3}{digit_2}");  /* 1>3>2 */
                }
            }

            else
            {
                if (digit_2 >= Math.Max(digit_1, digit_3))
                {
                    if (digit_1 >= digit_3)
                    {
                        Console.Write($"{digit_2}{digit_1}{digit_3}");  /* 2>1>3 */
                    }
                    else
                    {
                        Console.Write($"{digit_2}{digit_3}{digit_1}");  /* 2>3>1 */
                    }
                }

                else
                {
                    if (digit_1 >= digit_2)
                    {
                        Console.Write($"{digit_3}{digit_1}{digit_2}");  /* 3>1>2 */
                    }
                    else
                    {
                        Console.Write($"{digit_3}{digit_2}{digit_1}");  /* 3>2>1 */
                    }
                }

            }
        }
    }
}
