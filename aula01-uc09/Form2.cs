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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool condicao = true;
            int valor = 50;
            while (condicao)
            {
                if(valor > 0)
                {
                    lstView.Items.Add(valor.ToString());
                    valor--;
                }
                else
                { 
                    condicao = false;
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor = 0;//inicio
            bool condicao = true;
            
            do{
                if (valor < 50){//condicao
                    lstView.Items.Add(valor.ToString());
                    valor++;//passo
                }
                else{
                    condicao = false;
                }
            } while (condicao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
              //inicio         condicao  passo
            for(int valor = 0; valor<=31;valor++)
            {
                lstView.Items.Add(valor.ToString());
            }
        }
    }
}
