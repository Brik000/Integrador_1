using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Residuos;

namespace Visual
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            
            Composta_Universidad composta = new Composta_Universidad();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Porfavor complete todos los campos");
            }
            else { 
            ResiduosNaturales residuo = new ResiduosNaturales("organico", 1200, listBox1.Text);
            Composta_Universidad composta = new Composta_Universidad();
                try{
                    composta.AgregarResiduos(int.Parse(textBox1.Text), residuo);
                }catch(Exception ){
                    MessageBox.Show("error en cantidades");
                }

            label4.Text = composta.Cantidad_Actual1+"";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Porfavor complete todos los campos");
            }
            else { 
            ResiduosNaturales residuo = new ResiduosNaturales("organico", 1200, listBox1.Text);
            Composta_Universidad composta = new Composta_Universidad();
                try
                {
                    composta.RetirarResiduos(int.Parse(textBox1.Text), residuo);
                }catch(Exception){
                    MessageBox.Show("error en cantidades");
                }

            label4.Text = composta.Cantidad_Actual1 + "";
            }
            if (label4.Text=="0")
            {
                MessageBox.Show("En el Momento no hay residuos");
            }

        }
    }
}
