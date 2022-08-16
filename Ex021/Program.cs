// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int x1 = 7;
int y1 = -5; 
int z1 = 0;
int x2 = 1;
int y2 = -1;
int z2 = 9;

int lengthX = x2 - x1;
int lengthY = y2 - y1;
int lrngthZ = z2 - z1;
double distance = Math.Sqrt(lengthX*lengthX + lengthY*lengthY + lrngthZ*lrngthZ);
Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {distance}");