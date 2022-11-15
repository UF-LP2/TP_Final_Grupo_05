using csvfiles;
namespace tp_final;

public partial class Form1 : Form
{
    public Form1(List<cPedidos> ListaPedidos)
    {
        InitializeComponent();
        var csv_ = new csvfiles._csv();
        List<Pedido> Pedidos = csv_.read_csv();
        for (int i = 0; i < ListaPedidos.Count; i++)
        {
            switch (ListaPedidos[i].Cliente.m_cUbicacion.GetBarrio())
            {
                case eBarrio.Comuna_1:
                    label19.BackColor = label23.BackColor;
                    break;
                case eBarrio.Comuna_2:
                    label14.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_3:
                    label21.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_4:
                    label18.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_5:
                    label19.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_6:
                    label9.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_7:
                    label10.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_8:
                    label6.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_9:
                    label12.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_10:
                    label5.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_11:
                    label3.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_12:
                    label8.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_13:
                    label13.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_14:
                    label20.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Comuna_15:
                    label11.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.VicenteLopez:
                    label15.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.SanIsidro:
                    label1.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.SanMartin:
                    label16.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.TresdeFebrero:
                    label24.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Moron:
                    label34.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.LaMatanza:
                    label7.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.LomasdeZAmora:
                    label25.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Lanus:
                    label4.BackColor = System.Drawing.Color.Red;
                    break;
                case eBarrio.Avellaneda:
                    label32.BackColor = System.Drawing.Color.Red;
                    break;
            }
        }
            for (int j = 0; j < ListaPedidos.Count; j++)
            {
                switch (ListaPedidos[j].Cliente.m_cUbicacion.GetBarrio())
                {
                    case eBarrio.Comuna_1:
                        label19.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_2:
                        label14.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_3:
                        label21.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_4:
                        label18.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_5:
                        label19.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_6:
                        label9.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_7:
                        label10.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_8:
                        label6.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_9:
                        label12.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_10:
                        label5.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_11:
                        label3.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_12:
                        label8.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_13:
                        label13.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_14:
                        label20.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Comuna_15:
                        label11.BackColor = label33.BackColor;
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
                        label7.BackColor = label33.BackColor;
                        break;
                    case eBarrio.LomasdeZAmora:
                        label25.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Lanus:
                        label4.BackColor = label33.BackColor;
                        break;
                    case eBarrio.Avellaneda:
                        label32.BackColor = label33.BackColor;
                        break;
                }
            }

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label30_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
