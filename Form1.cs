using csvfiles;
namespace tp_final;



public partial class Form1 : Form
{
    List<cPedidos> ListaGlobal = new List<cPedidos>(); //creo una lista externa para poder usarla en el boton
    public Form1(List<cPedidos> ListaPedidos)
    {
        InitializeComponent();
        var csv_ = new csvfiles._csv();
        List<Pedido> Pedidos = csv_.read_csv();
        ListaGlobal = ListaPedidos;
        for (int i = 0; i < ListaPedidos.Count; i++) //recorro toda la lista
        {
            switch (ListaPedidos[i].Cliente.m_cUbicacion.GetBarrio()) //reviso los barrios, y segun que barrio, pinto la label correspondiente a esa comuna
            {
                case eBarrio.Comuna_1:
                    label19.BackColor = label23.BackColor; //usa el color de una de las labels del grafo
                    break;
                case eBarrio.Comuna_2:
                    label14.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_3:
                    label10.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_4:
                    label18.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_5:
                    label17.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_6:
                    label21.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_7:
                    label9.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_8:
                    label28.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_9:
                    label35.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_10:
                    label3.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_11:
                    label36.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_12:
                    label8.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_13:
                    label13.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_14:
                    label11.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_15:
                    label20.BackColor = label23.BackColor;
                    break;
                case eBarrio.VicenteLopez:
                    label15.BackColor = label23.BackColor;
                    break;
                case eBarrio.SanIsidro:
                    label1.BackColor = label23.BackColor;
                    break;
                case eBarrio.SanMartin:
                    label16.BackColor = label23.BackColor;
                    break;
                case eBarrio.TresdeFebrero:
                    label24.BackColor = label23.BackColor;
                    break;
                case eBarrio.Moron:
                    label34.BackColor = label23.BackColor;
                    break;
                case eBarrio.LaMatanza:
                    label5.BackColor = label23.BackColor;
                    break;
                case eBarrio.LomasdeZAmora:
                    label12.BackColor = label23.BackColor;
                    break;
                case eBarrio.Lanus:
                    label26.BackColor = label23.BackColor;
                    break;
                case eBarrio.Avellaneda:
                    label27.BackColor = label23.BackColor;
                    break;
            }
        }
    }

    public void button1_Click(object sender, EventArgs e) //cuando se aprete el boton
    {
        for (int j = 0; j < ListaGlobal.Count; j++) //recorre la lsta nuevamente
        {
            switch (ListaGlobal[j].Cliente.m_cUbicacion.GetBarrio()) //y segun el barrio pinta de verde si fue entreagdo el pedido
            {
                case eBarrio.Comuna_1:
                    label19.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_2:
                    label14.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_3:
                    label10.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_4:
                    label18.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_5:
                    label17.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_6:
                    label21.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_7:
                    label9.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_8:
                    label28.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_9:
                    label35.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_10:
                    label3.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_11:
                    label36.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_12:
                    label8.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_13:
                    label13.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_14:
                    label11.BackColor = label33.BackColor;
                    break;
                case eBarrio.Comuna_15:
                    label20.BackColor = label33.BackColor;
                    break;
                case eBarrio.VicenteLopez:
                    label15.BackColor = label33.BackColor;
                    break;
                case eBarrio.SanIsidro:
                    label1.BackColor = label33.BackColor;
                    break;
                case eBarrio.SanMartin:
                    label16.BackColor = label33.BackColor;
                    break;
                case eBarrio.TresdeFebrero:
                    label24.BackColor = label33.BackColor;
                    break;
                case eBarrio.Moron:
                    label34.BackColor = label33.BackColor;
                    break;
                case eBarrio.LaMatanza:
                    label5.BackColor = label33.BackColor;
                    break;
                case eBarrio.LomasdeZAmora:
                    label12.BackColor = label33.BackColor;
                    break;
                case eBarrio.Lanus:
                    label26.BackColor = label33.BackColor;
                    break;
                case eBarrio.Avellaneda:
                    label27.BackColor = label33.BackColor;
                    break;
            }
            System.Threading.Thread.Sleep(125); //espera 1/4 de segundo
        }

        Salida.BackColor = System.Drawing.Color.LightBlue;
        Salida.ForeColor = System.Drawing.Color.DarkBlue;
        Salida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Salida.Text = "Distribucion terminada, todos los pedidos fueron entregados";
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
