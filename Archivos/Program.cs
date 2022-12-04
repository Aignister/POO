using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Product
{
  public string code {get; set;}
  public string description {get; set;}
  public int departament {get; set;}
  public int likes {get; set;}
  public decimal price {get; set;}

  public Product(string code, string description, int departament, int likes, decimal price)
  {
    this.code = code;
    this.description = description;
    this.departament = departament;
    this.likes = likes;
    this.price = price;
  }

    public override string ToString()
    {
        return String.Format($"{code} {description} {departament} {likes} {price}");
    }
}

class ProductDB
{
  public static void SaveText(List<Product> products, String path)
  {
    StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite));

    foreach (var product in products)
    {
      sw.WriteLine($"{product.code}|{product.description}|{product.departament}|{product.likes}|{product.price}");
    }
    sw.Close();
  }

  public static void SaveBin(List<Product> productos, String path)
  {
    BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite));

    foreach (var producto in productos)
    {
      bw.Write(producto.code);
      bw.Write(producto.description);
      bw.Write(producto.departament);
      bw.Write(producto.likes);
      bw.Write(producto.price);
    }
    bw.Close();
  }

  public static List<Product> GetText(String path)
  {
    List<Product> products = new();
    StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

    while(sr.Peek() != -1)
    {
      String? row = sr.ReadLine();
      String[] columns = row.Split("|");
      products.Add(new Product(columns[0], columns[1], int.Parse(columns[2]), int.Parse(columns[3]), Decimal.Parse(columns[4])));
    }
    sr.Close();
    
    return products;
  }

  public static List<Product> GetBin(String path)
  {
    List<Product> products = new();
    BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read));

    while(br.PeekChar() != -1)
    {
      products.Add(new Product(br.ReadString(), br.ReadString(), br.ReadInt32(), br.ReadInt32(), br.ReadDecimal()));
    }
    br.Close();

    return products;
  }
}

class Program
{
  static void Main()
  {
    Console.WriteLine("Lista de productos");
    List<Product> products = new();
    products.Add(new Product("HIF", "Halo Infinite", 3, 117, 59));
    products.Add(new Product("HOM", "Hotline Miami", 4, 50, 29));
    products.Add(new Product("HAF", "Half Life", 3, 1000, 19));
    products.Add(new Product("CYP", "Cyberpunk 2077", 5, 2077, 59));

    foreach(var prod in products)
    Console.WriteLine(prod);
    Console.WriteLine();

    
    //Archivos Bin
    /*
    ProductDB.SaveBin(products, @"productos.bin");
    List<Product> productsArchivo = ProductDB.GetBin(@"productos.bin");
    foreach(var pa in productsArchivo)
    Console.WriteLine(pa);
    */
  }
}