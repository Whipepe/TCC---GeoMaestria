using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo2
{
    public partial class AreaExe : UserControl
    {
        public AreaExe()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            quadrado1.Visible = true;
            quadrado1.BringToFront();
        }
    }
}
