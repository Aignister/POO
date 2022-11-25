abstract class Musico
{
    public string Nombre;
    public string Apellido;
    public string NombreArtistico;

    public Musico(string nombre, string apellido, string nombreartistico)
    {
        Nombre = nombre;
        Apellido = apellido;
        NombreArtistico = nombreartistico;
    }
    public abstract void Saluda();
    public abstract void Afina();
    public abstract void Tocar();
}

class Baterista : Musico
{
    public Baterista(string nombre, string apellido, string nombreartistico):base(nombre, apellido, nombreartistico)
    {
    }
    public override void Tocar()
    {
        Console.WriteLine($"{NombreArtistico} Empieza a tocar sus tambores");
    }
}

class Bajista : Musico
{
    public Bajista(string nombre, string apellido, string nombreartistico):base(nombre, apellido, nombreartistico)
    {
    }
    public override void Tocar()
    {
        Console.WriteLine($"{NombreArtistico} Empieza a tocar su bajo");
    }
}

class Guitarrista : Musico
{
    public Guitarrista(string nombre, string apellido, string nombreartistico):base(nombre, apellido, nombreartistico)
    {
    }
    public override void Tocar()
    {
        Console.WriteLine($"{NombreArtistico} Empieza a tocar su guitarra");
    }
}

class Program
{
    static void Main()
    {
        var musico1 = new Baterista("Jose","Rose","Killer");
        var musico2 = new Bajista("Eve","Pocho","Mino");
        var musico3 = new Guitarrista("Farfa","Abyss","Burning");
        List<Musico> musicos = new();
        musicos.Add(musico1);
        musicos.Add(musico2);
        musicos.Add(musico3);

        foreach (var Mus in musicos)
        {
            Mus.Tocar();
        }

    }
}