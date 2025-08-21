// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Supermercados supermercado = new ProductosSupermercado();//Los productos estan heredando del supermercado, supermercado no puede heredar de productos
var supermercado1 = new Supermercados();
ProductosSupermercado persona2 = new ProductosSupermercado();
Supermercados persona3 = persona2;

supermercado.NIT = 123;
supermercado.Nombre = "OR";
supermercado.Ingresos = 100.5m;
supermercado.EstaAbierto = false;
supermercado.FechaCreacion = DateTime.Now;
supermercado.Perecedero = new Perecederos() { NIT = 123, EsPerecedero = "Perecedero" };
supermercado.NoPerecedero = new List<NoPerecederos>();
supermercado.NoPerecedero.Add(new Noperecedero() { NIT = 23, });
console.WriteLine(supermercado.Nombre);
console.WriteLine(supermercado.Perecedero.EsPerecedero);


public class Perecederos
{
    public int NIT;
    public String? EsPerecedero;

}
public class NoPerecederos
{
    public int NIT;
    public String? NombreNPer;

}
public class Supermercados
{
    public int NIT;
    public String? Nombre;
    public decimal Ingresos;
    public bool EstaAbierto;
    public DateTime FechaCreacion;
    public List<NoPerecederos>? NoPerecedero;
    public String? Perecedero;

}
public class ProductosSupermercado: Supermercados
{ 
    public String? NombreP;
}