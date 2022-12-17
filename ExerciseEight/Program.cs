/*Задача 8: Напишите программу, 
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

/*Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());
bool evenNumber = Convert.ToBoolean(number % 2);
int count = 1;
while (count <= number)
{
    if (evenNumber)
    {
        Console.Write($"{count + 1}");
        count++;
    }
}*/

Console.WriteLine("Введите любое целое число");
int number = int.Parse(Console.ReadLine());
int count = 2;
while (count <= number)
{
    Console.WriteLine(count);
    count += 2;
}