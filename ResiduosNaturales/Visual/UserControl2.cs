﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            this.button2.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listView1.Items.Add("List item text", 3);

            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.png";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Seleccione una imagen";
            BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = this.textBox1.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                this.textBox1.Text = BuscarImagen.FileName; String Direccion = BuscarImagen.FileName; this.pictureBox1.ImageLocation = Direccion;


                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}