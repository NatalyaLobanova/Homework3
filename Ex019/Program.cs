// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

int number = ReadInt("Введите пятизначное число: ");

if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
