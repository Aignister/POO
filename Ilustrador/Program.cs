using System;
using System.Collections.Generic;

//Programa de figuras con clases abstractas
//Interface del area para utilizar IComparable
//Metodo abstracto decimal Area
//2 figuras Retctagulo, Circulo

interface IComparable{}

abstract class Figura : IComparable
{
    protected int x;
    protected int y;
    protected string color;

    public Figura (int x, int y, string color)
    {
        this.x = x;
        this.y = y;
        this.color = color;
    }
    public abstract void Dibuja();
}

class Circulo : Figura
{
    //x= radio y= diametro 
    //Area = Pi*radio^2
    public Circulo(int x, int y, string color):base(x, y, color){}

    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un circulo del color {color}");
    }
}

class Retctagulo : Figura
{
    //x= base y= altura
    //Area = base * altura
    public Rectangulo(int x, int y, string color):base(x, y, color){}

    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un rectangulo del color {color}");
    }
}
class Program
{
    static void Main()
    {
        List<Figura> figuras = new();
        figuras.Add(new Circulo(12,13,"verde"));
    }
}