//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12


Console.WriteLine("ВВедите число ");

int input = int.Parse(Console.ReadLine());
int sum = 0;
int num = 0;
do
{
    num = input % 10;
    input = input / 10;
    sum = num + sum;
} while (input != 0);

Console.WriteLine(sum);