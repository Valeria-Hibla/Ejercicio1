// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//Los productos estan heredando del supermercado, supermercado no puede heredar de productos
var supermercado = new Supermercados();
Supermercados supermercado1 = new Supermercados();
Supermercados supermercado2=new ProductosSupermercado();


supermercado.NIT = 123;
supermercado.Nombre = "OR";
supermercado.Ingresos = 100.5m;
supermercado.EstaAbierto = true;
supermercado.FechaCreacion = DateTime.Now;
supermercado.perecedero = new Perecederos() { NIT = 00, EsPerecedero = "Si" };
supermercado.NoPerecederos = new List<NoPerecederos>();
supermercado.NoPerecederos.Add(new NoPerecederos() { NIT = 23, NombreNPer="Carne" });
Console.WriteLine(supermercado.Nombre);
Console.WriteLine(supermercado.perecedero.NIT);

foreach (var NIT in supermercado.NoPerecederos)
{
    Console.WriteLine(NIT.NIT);
}


public class Perecederos
{
    public int NIT = 0;
    public String? EsPerecedero = "";

}
public class NoPerecederos
{
    public int NIT=0;
    public String? NombreNPer="";

}
public class Supermercados
{
    public int NIT=0;
    public String? Nombre="";
    public decimal Ingresos=0.0m;
    public bool EstaAbierto=false;
    public DateTime FechaCreacion=DateTime.Now;
    public List<NoPerecederos> NoPerecederos=new List<NoPerecederos>();
    public Perecederos perecedero=new Perecederos();

}
public class ProductosSupermercado: Supermercados
{ 
    public String? NombreP;
}