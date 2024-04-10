
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Negocio.Libreria.Modelo;
[Table("lista_precios")]
public class Producto
{
    [Column("Identificador")]
    public int Identificador { get; set; }
    [Key]
    [Column("CodigoEAN")]
    public string CodigoEAN { get; set; }
    [Column("Descripcion")]
    public string Descripcion { get; set; }
    [Column("TipoProducto")]
    public string TipoProducto { get; set; }
    [Column("PrecioUnitario")]
    public double PrecioUnitario { get; set; }
    [Column("PorcentajeIVA")]
    public double PorcentajeIVA { get; set; }

    public string Devolver()
    {
        return Identificador + " " + CodigoEAN +  " " + Descripcion + " " + TipoProducto + " " +PrecioUnitario + " " + PorcentajeIVA;
    }
}
