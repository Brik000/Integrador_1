using System;
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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listView1.SelectedItems[0];
                textBox1.Text = listItem.ToolTipText ;
                
                
            }

            
        }
    }
}
