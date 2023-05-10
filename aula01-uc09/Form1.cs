using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula01_uc09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entrada;//Variável
            //1 opcao
            entrada = int.Parse(txtEntrada.Text);//entrada e atribuição
            if (entrada == 0) //se
            {//entao
                txtSaida.Text = "0";//Atribuição
            }
            else if (entrada == 1)
            {
                txtSaida.Text = "1";
            }
            int n=2;
            for (n = 2; n <= entrada; n++)
            {

            }


        }
    }
}
