// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//координаты двух точек и находит расстояние между ними в 3D пространстве
double GetDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return Math.Round(distance, 2, MidpointRounding.ToNegativeInfinity);
}




Console.Write("Input X(1 number): ");
int x = int.Parse(Console.ReadLine());

Console.Write("Input Y(1 number): ");
int y = int.Parse(Console.ReadLine());

Console.Write("Input Z(1 number): ");
int z = int.Parse(Console.ReadLine());

Console.Write("Input X(2 number): ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Input Y(2 number): ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Input Z(2 number): ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Растояние между точкой A c координатами ({x},{y},{z}) и точкой B c координатами({x1},{y1},{z1}) = {GetDistance(x, y, x1, y1, z, z1)}");