﻿// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков

// int num = new Random().Next(100,1000);
// int rezult = num / 10 % 10;
// if ((num <= 999) && (num>99)){
//   Console.WriteLine ($"Второй цифрой числа {num} является число {rezult}"!);  
// }
// else
// {
//     Console.WriteLine ($"Введено не верное число, введите трёхзначное число"!);
// }

// способ с помощью строк

// Console.WriteLine ("Введите трёхзначное число");
// int number = int.Parse(Console.ReadLine()!);
// string Num = Convert.ToString(number);
// if (Num.Length == 3)
// {
//     Console.WriteLine($"Вторая цифра числа {number} -> {Num[1]}");
// }
// else
// {
//     Console.WriteLine($"Введено не верное число, введите трёхзначное число");
// }

//__________________________________________________________________________________

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

// Console.WriteLine ("Введите число");
// int num = int.Parse(Console.ReadLine()!);
// if (num<100)
// {
//     Console.WriteLine($"Третей цифры нет");
// }
// if ((num>=100) && (num<=999)){
   
//    Console.WriteLine($"Третья цифра числа {num} -> {num % 10}");  
// } 
// if ((num >= 1000) && (num <= 9999)){
    
//     Console.WriteLine($"Третья цифра числа {num} -> {(num % 100)/10}");
// }
    
// if ((num >= 10000) && (num <= 100000)){
    
//     Console.WriteLine($"Третья цифра числа {num} -> {(num % 1000)/100}"); 
// }

// if (num > 100000)
// {
//     Console.WriteLine($"Введено не корректрое число");
// }


// с помощью строк и другого вида конвертации в строки

// Console.WriteLine ("Введите число");
// int num = int.Parse(Console.ReadLine()!);
// string Number = num.ToString();
// if (Number.Length < 3)
// {
//     Console.WriteLine ($"Третей цифры нет");
// }
// else if (Number.Length > 5)
// {
//     Console.WriteLine ($"Число введено не корректно");
// }
// else
// {
//     Console.WriteLine ($"Третья цифра числа {num} -> {Number[2]}");
// } 


//____________________________________________________________________________

// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.
// Обязательна проверка на ввод числа <1 и >7

// Console.WriteLine ("Введите число от 1 до 7");
// int num = int.Parse(Console.ReadLine()!);
// if (num>7 || num<1)
// {
//     Console.WriteLine ($"Введено не верное число. Введите число от 1 до 7");
//     return;
// }
// if (num>5)
// {
//     Console.WriteLine ($"Выходной день");
// }
// else
// {
//     Console.WriteLine ($"Будний день");
// }
