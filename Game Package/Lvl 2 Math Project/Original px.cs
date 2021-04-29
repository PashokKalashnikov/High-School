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
    public partial class Original_px : Form
    {
        private static Original_px _instance;
        public static Original_px Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Original_px();
                return _instance;
            }
        }
        public Original_px()
        {
            InitializeComponent();
        }

        private void Original_px_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
