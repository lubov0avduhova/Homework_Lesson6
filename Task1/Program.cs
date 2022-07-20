/*  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


int aboveZero = 0;
int number = 0;
Console.WriteLine("Если необходимо завершить программу, введите 1000");
inputNumber();
System.Console.WriteLine($"Вы ввели количество цифр больше нуля: {aboveZero}");


void inputNumber ()
{
while (number != 1000)
{
    number = Prompt("Введите число: ");
    if (number > 0 && number != 1000)
        aboveZero++;
}
}


int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}