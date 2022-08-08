//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("ВВедите 2 числа ");

int a = int.Parse(Console.ReadLine());

int b = int.Parse(Console.ReadLine());

int result = b == 0 ? 1 : a;

for (int i = 2; i <= b; i++) 
{
    result = result * a;
}




Console.WriteLine(result);
