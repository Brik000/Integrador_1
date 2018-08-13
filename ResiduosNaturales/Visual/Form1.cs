using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Residuos  ;

namespace Visual
{

    public partial class Form1 : Form
    {
        private ResiduosNaturales residuos;

        public Form1()
        {
            
            residuos = new ResiduosNaturales("organico", 1201,"pasto");
            residuos = new ResiduosNaturales("organico", 1202, "agua");
            residuos = new ResiduosNaturales("organico", 1203, "semillas");
            residuos = new ResiduosNaturales("organico", 1204, "papel");
            residuos = new ResiduosNaturales("organico", 1205, "carton");
            residuos = new ResiduosNaturales("organico", 1206, "huesos");
            residuos = new ResiduosNaturales("organico", 1207, "cascara huevos");
            residuos = new ResiduosNaturales("organico", 1208, "excremento animales");
            residuos = new ResiduosNaturales("organico", 1209, "flores");

            InitializeComponent();
        }

        private void listaElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();

        }
    }
}
