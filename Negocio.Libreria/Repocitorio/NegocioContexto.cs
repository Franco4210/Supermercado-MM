using Negocio.Libreria.Modelo;
using Microsoft.EntityFrameworkCore;
using Npgsql;
namespace Negocio.Libreria.Repocitorio;
public class NegocioContexto :  DbContext
{
    private static NegocioContexto instaciaContexto;
    private readonly string _cadenaConexion;
    private NegocioContexto(string cadenaConexion)
    {
        _cadenaConexion = cadenaConexion;
    } 
    public DbSet<Producto> producto {get; set;}  //asd
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_cadenaConexion);
        base.OnConfiguring(optionsBuilder);
    }
    public static NegocioContexto CrearInstancia()
    {
        if (instaciaContexto == null)
        {
            //C:\Users\ListaPreciosNueva.txt
            instaciaContexto = new NegocioContexto("HOST=localhost;Port=5432;Database=Productos;UserId=postgres;sslmode=prefer;Password=42105625");
        }
        return instaciaContexto;
    }
}

      