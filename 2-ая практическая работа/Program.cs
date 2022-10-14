Console.WriteLine("Практическая работа №2\n");
Console.WriteLine("1 - Задача 1. Игра угадай число");
Console.WriteLine("2 - Задача 2. Таблица умножения");
Console.WriteLine("3 - Задача 3. Вывод делителей числа");
Console.WriteLine("4 - Выход из программы");
int Num = Convert.ToInt32(Console.ReadLine());
{
    while (Num < 4)
    {
        switch (Num)
        {
            case 1:
                Console.Write("Эта игра угадай число \n  Введите число от 1 до 100: ");
                int num = 0;
                Random random = new Random();                
                num = random.Next(0, 100);
                while (true)
                {
                    Double input = Convert.ToDouble(Console.ReadLine());
                    if (num > input)
                        Console.Write("Побольше брат:) ");
                    else if (num < input)
                        Console.Write("Переборщил:( ");
                    else
                        Console.Write("Бинго^-^");
                }
                break;

            case 2:
                int[,] mass1 = new int[10, 10];
                int[] mass2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                for (int i = 9; i < mass2.Length; ++i)
                {
                    Console.Write(mass2[i] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 1; i < mass1.GetLength(0); ++i)
                {
                    for (int j = 1; j < mass1.GetLength(1); ++j)
                    {
                        int sum = i * j;
                        if (i == j)
                        {
                            mass1[i, j] = sum;
                            Console.Write(mass1[i, j] + "\t ");
                        }
                        else if (i > j)
                        {
                            mass1[i, j] = sum;
                            Console.Write(mass1[i, j] + "\t ");
                        }
                        else if (i < j)
                        {
                            mass1[i, j] = sum;
                            Console.Write(mass1[i, j] + "\t ");
                        }
                    }
                    Console.WriteLine("\n");
                }

                break;
            case 3:
                Console.Write("введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                        Console.Write(" " + i + "; ");                       
                }
                Console.WriteLine();
                break;
        }
        Console.WriteLine("1. Угадай число");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("4. Закрыть программу");
        Num = Convert.ToInt32(Console.ReadLine());
        if (Num == 4)
        {            
            break;
        }
    }
}