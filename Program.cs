namespace tp_final;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        cCocimundo Cocimundo = new cCocimundo();
        List<cPedidos> PedidosASalir = new List<cPedidos>();
        Cocimundo.CargarPedidos();
        Cocimundo.crearvehiculos();
        for (int i = 0; i < Cocimundo.ListaPedidos.Count; i++)
        {
            Console.WriteLine(Cocimundo.ListaPedidos[i].to_String());
        }
        PedidosASalir = Cocimundo.Distribucion_greedy(Cocimundo.ListaVehiculos[0]);
        for (int j = 0; j < PedidosASalir.Count; j++)
            Cocimundo.MasDinero(PedidosASalir[j].getPrecio());
        Cocimundo.MenosDinero(Cocimundo.ListaVehiculos[0].getpreciocomb() * Cocimundo.NaftadelVjaje(Cocimundo.ListaVehiculos[0]));
        for (int j = 0; j < PedidosASalir.Count; j++)
        {
            Console.WriteLine(PedidosASalir[j].to_String());
        }

        Cocimundo.FinalDelDia();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
 
}
