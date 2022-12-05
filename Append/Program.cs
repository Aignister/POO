using System.Threading;
using System.IO;
using System.Linq;
using System.Text;
class Program
{
    static void Main()
    {
        using (StreamWriter w = File.AppendText(@"productapp.txt"));
        {
            w.write("Lista de productos:");
            Console.WriteLine("Prueba de append");
        }
        Console.Read();
    }
}