﻿using System;
using System.Collections.Generic;

interface IComparable{}

abstract class Figura : IComparable
{
    protected int x;
    protected int y;
    protected double area;
    protected string color;

    public Figura (int x, int y, double area, string color)
    {
        this.x = x;
        this.y = y;
        this.area = area;
        this.color = color;
    }

    public abstract void Dibuja();

    public double CompareTo(object obj)
    {
        return this.area.CompareTo(((Figura)obj).area);
    }
}

class Circulo : Figura
{
    public Circulo(int x, int y, double area, string color):base(x, y, area, color){}

    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un circulo {color} {x} {y} con un area de {area}");
    }
}

class Rectangulo : Figura
{
    public Rectangulo(int x, int y, double area, string color):base(x, y, area, color){}

    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un rectangulo {color} {x} {y} con un area de {area}");
    }
}
class Program
{
    static void Main()
    {
        List<Figura> figuras = new();
        figuras.Add(new Circulo(12,13,40.80,"verde"));
        figuras.Add(new Rectangulo(12,13, 156,"azul"));
        figuras.Add(new Circulo(5,10,314,"rojo"));
        figuras.Add(new Rectangulo(5,10,50,"amarillo"));      

        foreach (var fig in figuras)
        {
            fig.Dibuja();      
        }
    }
}