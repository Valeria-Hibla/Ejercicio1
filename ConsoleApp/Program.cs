// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Supermercados supermercado = new Supermercados();
supermercado.NIT = 123;
supermercado.Nombre = "OR";
supermercado.Ingresos = 100.5m;
supermercado.EstaAbierto = false;
supermercado.FechaCreacion = DateTime.Now;
supermercado.perecedero = new Perecederos() { NIT = 123, EsPerecedero = "Perecedero" };

public class Perecederos
{
    public int NIT;
    public String? EsPerecedero;

}
public class Supermercados
{
    public int NIT;
    public String? Nombre;
    public decimal Ingresos;
    public bool EstaAbierto;
    public DateTime FechaCreacion;
    public Perecederos? perecedero;

}
public class ProductosSupermercado: Supermercados
{ 
    public String? NombreP;
 

}