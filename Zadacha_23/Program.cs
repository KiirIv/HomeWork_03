/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int i = 1;
int N = GetNumber();

while (i < N)
{
    Console.Write(i * i * i + ", ");
    i += 1;
}
Console.Write(i * i * i);