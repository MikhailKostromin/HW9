/*Задача 64: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/

Console.WriteLine ("Введите  значение M");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите  значение N");
int M = Convert.ToInt32(Console.ReadLine());

string Sum(int N, int M)
{
    if (N == M) return $"{M} ";
    return Sum(N - 1, M) + N + ", ";
}
Console.WriteLine(Sum(M, N));