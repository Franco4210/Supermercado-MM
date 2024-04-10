using Negocio.Libreria.Modelo;
using Negocio.Libreria.Negocio;
using Spectre.Console;

namespace Negocio.App.Pantalla.PantallaBuscarProducto;

public class BuscarProducto : PantallaPrincipal
{
    public void ListarProductos()
    {

        
        AnsiConsole.Clear();
        AnsiConsole.Write(
            new FigletText("Supermercado MM")
            .LeftJustified()
            .Color(Color.Red3)
        );
        AnsiConsole.MarkupLine("[springgreen2_1]Buscar el producto[/]");

        try
        {
            BuscarServicio buscarServicio = new BuscarServicio();
            //List<Producto> listadoProductos = buscarServicio.ObtenerProductos();
           
            
            string descripcion = AnsiConsole.Prompt(new TextPrompt<string>("Describa el producto: "));

            //SelectionPrompt<Producto> prompt = new SelectionPrompt<Producto>();
            //prompt.Title = "Seleccione el producto >>";
            List<Producto> listadoProductos = buscarServicio.ObtenerProductoPorDe(descripcion);
            
            foreach (Producto producto in listadoProductos)
            {
                
                
                
                
                AnsiConsole.MarkupLine("[White]Descripcion de producto: [/]" + producto.Descripcion );
                AnsiConsole.MarkupLine("[White]Codigo EAN:              [/]" + producto.CodigoEAN);
                AnsiConsole.MarkupLine("[White]Tipo de producto:        [/]" + producto.TipoProducto);
                AnsiConsole.MarkupLine("[White]Porcentaje del IVA:      [/]" + producto.PorcentajeIVA);
                AnsiConsole.MarkupLine("[White]Id del Producto:         [/]" + producto.Identificador);
                AnsiConsole.MarkupLine("[White]Precio del Producto:     [/]" + producto.PrecioUnitario);
                Console.WriteLine("--------------------------------------------------------------");
                
                
            }
            Console.WriteLine("Precione una tecla para continua");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("_");
            Console.WriteLine("_");
        }
    }
}
