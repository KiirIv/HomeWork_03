/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number < 9999 || number > 99999)
{
    Console.Write("Число НЕ пятизначное");
}
else if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
{
    Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число не является палиндромом");
}