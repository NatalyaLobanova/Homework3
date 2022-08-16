// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

int randomNumber = new Random().Next(1, 10);
Console.WriteLine(randomNumber);
int count = 1;

while(count <= randomNumber)
{
    Console.Write(Cube(count) + " ");
    count++;
}

int Cube(int num)
{
    return(num * num * num);
}


