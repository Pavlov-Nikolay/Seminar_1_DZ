bool isWork = true;

while (isWork)
{
    Console.WriteLine("Есть 4 программы.");
    Console.WriteLine("Программа 1: Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("Программа 2: Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
    Console.WriteLine("Программа 3: Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("Программа 4: Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.WriteLine("Для выхода из диалога наберите -1.");
    Console.WriteLine("Введите номер программы.");

    if (int.TryParse(Console.ReadLine(), out int i));
    {
        switch (i)
        {
            case 1:
            {
                // Напишите программу, которая на вход принимает два числа 
                // и выдаёт, какое число большее, а какое меньшее.
                // a = 5; b = 7 -> max = 7
                // a = 2 b = 10 -> max = 10
                // a = -9 b = -3 -> max = -3

                System.Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
                System.Console.WriteLine("Введите первое число");
                int.TryParse(Console.ReadLine(), out int a);
                System.Console.WriteLine("Введите второе число");
                int.TryParse(Console.ReadLine(), out int b);
                Console.WriteLine();

                    if (a > b)
                    {
                        System.Console.WriteLine("Первое число больше второго числа");
                    }
                    else
                    {
                    System.Console.WriteLine("Второе число больше первого числа"); 
                    }
                    if (a == b)
                    {
                        System.Console.WriteLine("Вы ввели два одинаковых числа");
                    }
                Console.WriteLine();
                break;
            }
             case 2:
            {
                // Напишите программу, которая принимает на вход три числа
                // и выдаёт максимальное из этих чисел.
                // 2, 3, 7 -> 7
                // 44 5 78 -> 78
                // 22 3 9 -> 22

                System.Console.WriteLine("Введите первое число");
                int.TryParse(Console.ReadLine(), out int a);
                System.Console.WriteLine("Введите второе число");
                int.TryParse(Console.ReadLine(), out int b);
                System.Console.WriteLine("Введите третье число");
                int.TryParse(Console.ReadLine(), out int c);
                int[] arr = {a, b, c};
                Console.WriteLine();
                Console.WriteLine("Максимальное введенное число " + arr.Max());
                Console.WriteLine();
                break;
            }
             case 3:
            {
                // Напишите программу, которая на вход принимает число и выдаёт, 
                // является ли число чётным (делится ли оно на два без остатка).

                System.Console.WriteLine("Введите число");
                int.TryParse(Console.ReadLine(), out int a);
                Console.WriteLine();

                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Вы ввели четное число");
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели нечетное число");
                    }
                    Console.WriteLine();

                break;
            }
            case 4:
            {
                // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
                
                System.Console.WriteLine("Введите число");
                int.TryParse(Console.ReadLine(), out int a);
                int count = 2;
                Console.WriteLine();
                    while (count <= a)
                        {
                            Console.WriteLine(count);
                            count = count + 2;
                        }
                    Console.WriteLine();
              break;          
            }
             case -1: isWork = false; 
            {

            }
             break;
          
            default:
                break;
        }
    }
}