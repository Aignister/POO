using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Producto
{
    public string codigo {get; set;}
    public string descripcion {get; set;}
    public int departamento {get; set;}
    public int likes {get; set;}
    public decimal precio {get; set;}

    public Producto(string codigo, string descripcion, int departamento, int likes, decimal precio)
    {
      this.codigo = codigo;
      this.descripcion = descripcion;
      this.departamento = departamento;
      this.likes = likes;
      this.precio = precio;
    }

    public override string ToString()
    {
        return String.Format($"Codigo: {codigo} Descripcion: {descripcion} Departamento: {departamento} Likes: {likes} Precio: {precio}");
    }
}

class ProductoDB
{
    public static void SaveText(List<Producto> productos, String path)
    {
      StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));

      foreach (var producto in productos )
      {
        sw.WriteLine($"{producto.codigo}|{producto.descripcion}|{producto.departamento}|{producto.likes}|{producto.precio}");
      }
      sw.Close();
    }
   
    public static void SaveBin(List<Producto> products, String path)
    {
      BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));
      foreach(var product in products)
      {
        bw.Write(product.codigo);
        bw.Write(product.descripcion);
        bw.Write(product.departamento);
        bw.Write(product.likes);
        bw.Write(product.precio);
      }
      bw.Close();
    }

    public static List<Product> GetText(String path)
    {
       List<Product> products = new();
       StreamReader sr = new StreamReader(
          new FileStream(path, FileMode.Open, FileAccess.Read)
          );
       
       while ( sr.Peek() != -1)
       {
          String? row = sr.ReadLine();
          String[] columns = row.Split("|");
          products.Add(new Product(columns[0], columns[1], Decimal.Parse(columns[2])));
       }
        sr.Close();

        return products;
    }
   
    public static List<Product> GetBin(String path)
    {
       List<Product> products = new();
       BinaryReader br = new BinaryReader(
          new FileStream(path, FileMode.Open, FileAccess.Read)
          );
       
       while ( br.PeekChar() != -1)
       {
         products.Add( new Product(
               br.ReadString(), br.ReadString(), br.ReadDecimal()
               ));
       }
        br.Close();

        return products;
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Lista de Productos");
        List<Product> products = new();
        products.Add( new Product("AAA", "FIFA 2023 XBOX", 65.23m));
        products.Add( new Product("AAB", "FIFA 2023 Play", 65.23m));
        products.Add( new Product("AAC", "FIFA 2022", 55.23m));
   
        foreach(var p in products)
          Console.WriteLine(p);
        Console.WriteLine();

       //ProductDB.SaveBin(products, @"productos.bin");
       /* List<Product> productsArchivo =  ProductDB.GetText(@"productos.txt");
*/      
        List<Product> productsArchivo =  ProductDB.GetBin(@"productos.bin");
        foreach(var p in productsArchivo)
          Console.WriteLine(p);
    }
}