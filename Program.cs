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

        //carga y ordenamiento de listas
        Cocimundo.CargarPedidos();
        Cocimundo.crearvehiculos();

        //aca se podria poner un bucle for para probar correr 2 dias, deberia abarcar hasta la funcion FinalDelDia()
        Cocimundo.OrdenarListaPedidos();

        //imprimimos todos los pedidos para chequear que esten bien cargados
        for (int i = 0; i < Cocimundo.ListaPedidos.Count; i++)
        {
            Console.WriteLine(Cocimundo.ListaPedidos[i].to_String());
        }
        //for(int i = 0;i< Cocimundo.ListaVehiculos.Count;i++) //no lo dejo porque entran todos los objetos en un solo vehiculo
       // {
            //se hace el algoritmo de guardado dinamico
            PedidosASalir = Cocimundo.Dinamico_Mochila(Cocimundo.ListaVehiculos[0]);

            //se hace el algoritmo de distribucion
            PedidosASalir = Cocimundo.Distribucion_greedy(PedidosASalir, Cocimundo.ListaVehiculos[0]);

            //se cuenta el dinero ganado y se suma a la caja de cocimundo
            for (int j = 0; j < PedidosASalir.Count; j++)
                Cocimundo.MasDinero(PedidosASalir[j].getPrecio());

            //se resta el dinero gastado por la nafta, cada vehiculo gasta segun la disstancia recorrida, se carga cuando sea necesario, y cuando se vuelve a la base nuevamente
            Cocimundo.MenosDinero(Cocimundo.ListaVehiculos[0].getpreciocomb() * Cocimundo.NaftadelVjaje(Cocimundo.ListaVehiculos[0]));

        ////imprmir la lista de pedidos a despachar

                Console.WriteLine("Pedidos a salir");
        for (int j = 0; j < PedidosASalir.Count(); j++)
            {
          
                Console.WriteLine(PedidosASalir[j].to_String());
            }

            //grafo que muestra como se despacha el pedido
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(PedidosASalir));
        //}
        
        //se hacee un recuento de la plata y se saca el neto, y se decrementa en 1 el tiempo de prioridades
        Cocimundo.FinalDelDia();

        return;
    }    
 
}
