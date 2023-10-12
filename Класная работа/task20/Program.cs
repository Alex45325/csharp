/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки (x1 y1): ");
        string[] pointA = Console.ReadLine().Split();
        int x1 = int.Parse(pointA[0]);
        int y1 = int.Parse(pointA[1]);

        Console.WriteLine("Введите координаты второй точки (x2 y2): ");
        string[] pointB = Console.ReadLine().Split();
        int x2 = int.Parse(pointB[0]);
        int y2 = int.Parse(pointB[1]);

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"Расстояние между точками A({x1},{y1}) и B({x2},{y2}): {distance:F2}");
    }

    static double CalculateDistance(int x1, int y1, int x2, int y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}