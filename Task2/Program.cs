/* Задача 2.Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5) */

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
double resultEquationX(int b1, int b2, int k1, int k2)
{
    double x = (double)(b2 - b1) / (k1 - k2); // перевод в double, иначе выдает результат 0
    return x;
}

double resultEquationY(int b1, int b2, int k1, int k2)
{
    double y = (double) k1 * resultEquationX (b1, b2, k1,k2)+ b1;
    return y;
}


int b1 = Prompt("Введите b1: ");
int k1 = Prompt("Введите k1: ");
int b2 = Prompt("Введите b2: ");
int k2 = Prompt("Введите k2: "); 

System.Console.WriteLine($"X равно {resultEquationX(b1, b2, k1, k2)}, Y равно {resultEquationY(b1, b2, k1, k2)}");
