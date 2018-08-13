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
            ResiduosNaturales residuo = new ResiduosNaturales("organico", 1200, "agua");
            Composta_Universidad composta = new Composta_Universidad();
                 
                int nueva = int.Parse(textBox1.Text);
                
               
                composta.AgregarResiduos(int.Parse(textBox1.Text), residuo);
                int label = int.Parse(label4.Text);
                int final = label + nueva;
                
                
            label4.Text = final+"";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Porfavor complete todos los campos");
            }
            else { 
            ResiduosNaturales residuo = new ResiduosNaturales("organico", 1200, "agua");
            Composta_Universidad composta = new Composta_Universidad();
            composta.RetirarResiduos(int.Parse(textBox1.Text), residuo);
            
            }
            if (label4.Text=="0")
            {
                MessageBox.Show("En el Momento no hay residuos");
            }
            else
            {
                int nuevo = int.Parse(textBox1.Text);
                int label = int.Parse(label4.Text);
                int final = label - nuevo;
                label4.Text = final + "";


            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
