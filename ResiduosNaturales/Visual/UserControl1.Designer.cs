namespace Visual
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pasto"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Agua"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Semillas"}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Papel"}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cartón"}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Huesos"}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cascaras huevos"}, 6, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Excremento animales"}, 7, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Restos de alimento"}, 8, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flores"}, 9, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Firebrick;
            this.imageList1.Images.SetKeyName(0, "pasto.png");
            this.imageList1.Images.SetKeyName(1, "agua.png");
            this.imageList1.Images.SetKeyName(2, "semillas.png");
            this.imageList1.Images.SetKeyName(3, "papel.png");
            this.imageList1.Images.SetKeyName(4, "cartón.png");
            this.imageList1.Images.SetKeyName(5, "hueso.png");
            this.imageList1.Images.SetKeyName(6, "huevo.png");
            this.imageList1.Images.SetKeyName(7, "poop.png");
            this.imageList1.Images.SetKeyName(8, "banano.png");
            this.imageList1.Images.SetKeyName(9, "flores.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recursos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            listViewItem1.Tag = "";
            listViewItem1.ToolTipText = "este recurso es de los principales que se procesan en la GRUI de la universidad, " +
    "al semestre se procesan 12 toneladas de las cuales 10 se van a la empresa dedica" +
    "da al correcto procesamiento";
            listViewItem2.ToolTipText = "con la cantidad adecuada de agua, que generalmente son 7 litros por grupo de comp" +
    "ostaje, se genera el abono para las plantas de la universidad";
            listViewItem3.ToolTipText = "las semillas que no son aptas para la siembra se recolectan en costales y se mezc" +
    "lan con otros recursos para funcionar como abono";
            listViewItem4.ToolTipText = "el papel que se recolecta en la universidad es triturado en la universidad es don" +
    "ado a empresas de reciclaje para que realicen el proceso adecuado de reutilizaci" +
    "on";
            listViewItem5.ToolTipText = "el carton procesado se ingresa en maquinas especiales y se mezcla con agua para q" +
    "ue forme un material mas blando y necesario para unir con los demas";
            listViewItem6.ToolTipText = "los huesos recolectados son molidos y añadidos al proceso de generacion de abono " +
    "natural, actualmente se recolectan 2 toneladas de huesos provenientes de la basu" +
    "ra del campus";
            listViewItem7.ToolTipText = "estas cascaras son usadas para el alimento de aves y especies naturales del campu" +
    "s ";
            listViewItem8.ToolTipText = "el excremento tiene un proceso aparte, ya que puede dañar el abono que se esta cr" +
    "eando. su recoleccion el semestre pasado fue de 20 kg provenientes de aves y esp" +
    "ecies de a universidad";
            listViewItem9.ToolTipText = "este recurso natural se usa como fuente para abono de matas una vez es procesado," +
    " anualmente se producen 25.000kg de abono ";
            listViewItem10.ToolTipText = "las flores se unen al proceso como principal fuente de nutrientes en la mezcla pa" +
    "ra abono, recolectando las que estan marchitas y triturandolas con aproximadamen" +
    "te 9 kg por semana";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(49, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(223, 249);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGreen;
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(295, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 249);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(532, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListView listView1;
    }
}
