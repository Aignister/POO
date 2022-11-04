interface IBaterista
{
    void Tambor();
    void Platillo();
}
interface IBajista
{
    void Corto();
    void Alto();
}
interface IGuitarrista
{
    void Solo();
    void Tocar();
}
class Musico
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
}

class Baterista : Musico, IBaterista
{
    public Baterista(string nombre, string apellido, string nombreartistico):base(nombre, apellido, nombreartistico)
    {
    }
    public void Tambor()
    {
        Console.WriteLine($"{NombreArtistico} Toca los tambores");
    }
    public void Platillo()
    {
        Console.WriteLine($"{NombreArtistico} Toca los platillos");
    }
}

class Bajista : Musico, IBajista
{
    public Bajista(string nombre, string apellido, string nombreartistico):base(nombre, apellido, nombreartistico)
    {
    }
    public void Corto()
    {
        Console.WriteLine($"{NombreArtistico} Realiza un sono alto");
    }
    public void Alto()
    {
        Console.WriteLine($"{NombreArtistico} Realiza un sono bajo");
    }
}

class Guitarrista : Musico, IGuitarrista
{
    public Guitarrista(string nombre, string apellido, string nombreartistico):base(nombre, apellido, nombreartistico)
    {
    }
    public void Solo()
    {
        Console.WriteLine($"{NombreArtistico} Realiza un solo");
    }
    public void Tocar()
    {
        Console.WriteLine($"{NombreArtistico} Empieza a tocar su guitarra");
    }
}

class Program
{
    static void Main()
    {
        
    }
}