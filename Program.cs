// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int number2 = Convert.ToInt32 (Console.ReadLine());

// if (number1 > number2)
// {
//     Console.Write("max=");
//     Console.WriteLine(number1);
//     Console.Write("min=");
//     Console.WriteLine(number2);
// }
// else 
// {
//     Console.Write("max=");
//     Console.WriteLine(number2);
//     Console.Write("min=");
//     Console.WriteLine(number1);
// }

-----------------------------------------------------------------------------------------------------

// //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int number2 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите число 3");
// int number3 = Convert.ToInt32 (Console.ReadLine());

// int max = number1;

// if (number2 > max) max=number2;
// if (number3 > max) max=number3;

// Console.Write("max=");
// Console.WriteLine(max);


--------------------------------------------------------------------------

// //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32 (Console.ReadLine());

// int result = number % 2;

// if (result == 0) Console.WriteLine("Число является чётным");

// else Console.WriteLine("Число является нечётным");

---------------------------------------------------------------------------

// //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32 (Console.ReadLine());

// int index = 2;

// while (index <= number)
// {
//     Console.WriteLine (index);
//     index=index+2;
// }