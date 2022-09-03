//Задача 9
// Напишите программу, которая выводит случайное число из отрезка 10-99 и показывает наибольшую цифру числа
// 78 -> 8
// 75 -> 7


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;  // 78 / 10 = 7
int secondDigit = number % 10; // Остаток от деления 78 на 10 = 8
int maximum = firstDigit;
if(secondDigit > maximum) maximum = secondDigit;

System.Console.WriteLine("Наибольшая цифра в числе " + number + " - это " + maximum); // Конкатенация - процесс сложения строк
// Или
System.Console.WriteLine($"Наибольшая цифра в числе {number} - это {maximum}"); // Интерполяция

