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
        for (int i = 0; i < Cocimundo.ListaPedidos.Count; i++)
        {
            Console.WriteLine(Cocimundo.ListaPedidos[i].to_String());
        }
        PedidosASalir = Cocimundo.Distribucion_greedy();
        for(int i = 0; i < PedidosASalir.Count; i++)
            Cocimundo.MasDinero(PedidosASalir[i].getPrecio());
        //Cocimundo.MenosDinero(/*Cocimundo.NaftadelVjaje(PedidosASalir)*/);
        for (int i = 0; i < PedidosASalir.Count; i++)
        {
            Console.WriteLine(PedidosASalir[i].to_String());
        }

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
 
}
