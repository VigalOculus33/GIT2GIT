


//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int max = 0;
int min = 0;//объявили значения int

Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if(Number1 > Number2)
{
    max = Number1;
    min = Number2;
}
else
{
    max = Number2;
    min = Number1;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);