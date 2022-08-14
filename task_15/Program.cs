//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write ("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1) Console.WriteLine("Понедельник");
if (dayNumber == 2) Console.WriteLine("Вторник");
if (dayNumber == 3) Console.WriteLine("Среда");
if (dayNumber == 4) Console.WriteLine("Четверг");
if (dayNumber == 5) Console.WriteLine("Пятница");
if (dayNumber == 6) Console.WriteLine("Суббота");
if (dayNumber == 7) Console.WriteLine("Воскресенье");

if(dayNumber<=5) Console.WriteLine("рабочий");
else Console.WriteLine("выходной");
