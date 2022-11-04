class Alumno
{
    public string Nombre;
    public string Apellido;
    public string NumControl;

    public Alumno(string nombre, string apellido, string numControl)
    {
        Nombre = nombre;
        Apellido = apellido;
        NumControl = numControl;
    }

    public override string ToString()
    {
        return String.Format($"{NumControl} {Nombre} {Apellido}");
    }

    public void Imprime()
    {
        Console.WriteLine($"{NumControl} {Nombre} {Apellido}");
    }
}

class Licenciatura : Alumno
{
    protected string Servicio;
    protected string Recidencia;

    public Licenciatura(string nombre, string apellido, string numControl, string servicio, string recidencia):base(nombre, apellido, numControl)
    {
        Servicio = servicio;
        Recidencia = recidencia;
    }
    
    public override string ToString()
    {
        return String.Format($"{base.ToString()} {Servicio} {Recidencia}");
    }

    public new void Imprime()
    {
        Console.WriteLine($"{NumControl} {Nombre} {Apellido} {Servicio} {Recidencia}");
    }
}

class Posgrado : Alumno
{
    protected string Investigacion;

    public Posgrado(string nombre, string apellido, string numControl, string investigacion):base(nombre, apellido, numControl)
    {
        Investigacion = investigacion;
    }
    
    public override string ToString()
    {
        return String.Format($"{base.ToString()} {Investigacion}");
    }
    public new void Imprime()
    {
        Console.WriteLine($"{NumControl} {Nombre} {Apellido} {Investigacion}");
    }
}

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno("Azir", "Shurit", "652989A");
            Licenciatura lic = new Licenciatura("Zoe", "Star", "2325742B", "Cyber", "Google");
            Posgrado pos = new Posgrado("Dante", "Mojica", "242120022", "Alacranes");
            a.Imprime();
            a.ToString();
            lic.Imprime();
            lic.ToString();
            pos.Imprime();
            pos.ToString();
        }
    }
}
