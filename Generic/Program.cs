class Pila
{
    private int[] pila;
    private int apuntador = 0;
    private int size;

    public Pila(int s)
    {
        size = s;
        pila = new int[s];
    }
    public void Push(int d)
    {
        try
        {
            pila[apuntador++] = d;
        }
        catch (System.IndexOutOfRangeException)
        {
            Console.WriteLine("Se supero la capacidad de la pila");
        }
    }
    public int Pop()
    {
        return pila[apuntador--];
    }
}

class Program
{
    static void Main()
    {
        Pila a = new Pila(5);
        a.Push(5);
        a.Push(3);
        a.Push(4);
        a.Pop();

    }
}