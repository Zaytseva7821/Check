//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int EvenNum = 2;
if (num<2)
{
    Console.WriteLine("В диапазоне от 1 до вашего числа нет четных. Попробуйте другое число");
}
else
{
Console.WriteLine("Четные числа в диапазоне от 1 до вашего числа:");
while (EvenNum<=num)
{
    Console.WriteLine(EvenNum);
    EvenNum = EvenNum + 2;
}
}