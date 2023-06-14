//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 - да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int EvenNumber = Convert.ToInt32(Console.ReadLine());

int DateDiv = EvenNumber % 2;

if(DateDiv ==0)
{
     Console.Write("Да,результат: ");
}
else
{
     Console.Write("Нет,число не делиться без остатка");
}
