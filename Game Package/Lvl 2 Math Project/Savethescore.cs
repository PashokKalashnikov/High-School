using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lvl_2_Math_Project
{
    public partial class Savethescore : Form
    {
        public Savethescore()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                OK.Enabled = true;
            }
            else
            {
                OK.Enabled = false;
            }
        }
        
        private void Savethescore_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (OK.Enabled))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
