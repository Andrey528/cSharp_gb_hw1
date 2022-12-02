Console.WriteLine($"Задание: напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");

int first_number = 0, second_number = 0;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out first_number);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out second_number);

if (first_number > second_number) Console.Write($"Большее число: {first_number}\nМеньшее числоЖ: {second_number}");
else Console.WriteLine($"Большее число: {second_number}\nМеньшее число: {first_number}");

//-----------------------------------------------------------------------------

Console.WriteLine($"Задание: напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");

int third_number = 0;
first_number = 0;
second_number = 0;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out first_number);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out second_number);
Console.Write($"Введите третье число: ");
int.TryParse(Console.ReadLine()!, out third_number);

if ((first_number >= second_number) && (first_number >= third_number)) Console.WriteLine($"Максимальное число: {first_number}\n");
if ((second_number >= first_number) && (second_number >= third_number)) Console.WriteLine($"Максимальное число: {second_number}\n");
if ((third_number >= first_number) && (third_number >= second_number)) Console.WriteLine($"Максимальное число: {third_number}\n");

//----------------------------------------------------------------

Console.WriteLine($"Задание: напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");

int number = 0;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

if (number % 2 == 0) Console.WriteLine($"Четное");
else Console.WriteLine($"Нечетное");

//--------------------------------------------------------------

Console.WriteLine($"Задание: напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");

number = 0;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0) Console.Write($"{i}, ");
}