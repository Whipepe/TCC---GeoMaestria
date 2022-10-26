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
    public partial class Quadrado : UserControl
    {
        int lado1 = 0;
        int lado2 = 0;
        int lado3 = 0;
        int lado4 = 0;
        int area = 0;
        int perimetro = 0;
        public Quadrado()
        {
            InitializeComponent();
        }

        private void btnLado1_Click(object sender, EventArgs e)
        {
            pnlLado1.Visible = true;
            pnlLado1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInserirLado1_Click(object sender, EventArgs e)
        {
            TBLado1.BringToFront();
            TBLado1.Visible = true;
        }

        private void btnLado2_Click(object sender, EventArgs e)
        {
            pnlLado2.Visible = true;
            pnlLado2.BringToFront();
        }

        private void btnLado3_Click(object sender, EventArgs e)
        {
            pnlLado3.Visible = true;
            pnlLado3.BringToFront();
        }

        private void btnLado4_Click(object sender, EventArgs e)
        {
            pnlLado4.Visible = true;
            pnlLado4.BringToFront();
        }

        private void btnInserirLado2_Click(object sender, EventArgs e)
        {
            TBLado2.BringToFront();
            TBLado2.Visible = true;
        }

        private void btnInserirLado3_Click(object sender, EventArgs e)
        {
            TBLado3.BringToFront();
            TBLado3.Visible = true;
        }

        private void btnInserirLado4_Click(object sender, EventArgs e)
        {
            TBLado4.BringToFront();
            TBLado4.Visible = true;
        }

        private void TBLado4_Enter(object sender, EventArgs e)
        {
            TBLado4.Visible = false;
            pnlLado4.Visible = false;
            this.lado4 = Convert.ToInt32(TBLado4.Text);
        }

        private void TBLado1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int.TryParse(TBLado1.Text, out this.lado1);
                TBLado1.Visible = false;
                pnlLado1.Visible = false;
                lado4 = lado3 = lado2 = lado1;
                lblLado1.Text = Convert.ToString(lado1);
                lblLado1.Visible = true;
                lblLado2.Visible = true;
                lblLado3.Visible = true;
                lblLado4.Visible = true;
                lblLado2.Text = lblLado3.Text = lblLado4.Text = lblLado1.Text;
            }
        }

        private void TBLado2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int.TryParse(TBLado2.Text, out this.lado2);
                TBLado2.Visible = false;
                pnlLado2.Visible = false;
                lado4 = lado3 = lado1 = lado2;
                lblLado2.Text = Convert.ToString(lado2);
                lblLado1.Visible = true;
                lblLado2.Visible = true;
                lblLado3.Visible = true;
                lblLado4.Visible = true;
                lblLado1.Text = lblLado3.Text = lblLado4.Text = lblLado2.Text;
            }
        }

        private void TBLado3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int.TryParse(TBLado3.Text, out this.lado3);
                TBLado3.Visible = false;
                pnlLado3.Visible = false;
                lado4 = lado1 = lado2 = lado3;
                lblLado3.Text = Convert.ToString(lado3);
                lblLado1.Visible = true;
                lblLado2.Visible = true;
                lblLado3.Visible = true;
                lblLado4.Visible = true;
                lblLado2.Text = lblLado1.Text = lblLado4.Text = lblLado3.Text;
            }
        }

        private void TBLado4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int.TryParse(TBLado4.Text, out this.lado4);
                TBLado4.Visible = false;
                pnlLado4.Visible = false;
                lado1 = lado3 = lado2 = lado4;
                lblLado4.Text = Convert.ToString(lado4);
                lblLado1.Visible = true;
                lblLado2.Visible = true;
                lblLado3.Visible = true;
                lblLado4.Visible = true;
                lblLado2.Text = lblLado3.Text = lblLado1.Text = lblLado4.Text;
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (this.lado1 != 0)
            {
                this.area = this.lado1 * this.lado1;
                lblArea.Text = ("Área: " + this.area);
            }
            else
            {
                MessageBox.Show("Não foi possível calcular a área");
            }
            pnlExplicacaoBaixo.Visible = true;
            lblExplicacao.MaximumSize = new Size(178,0) ;
            lblExplicacao.Text = "A área de um quadrado é calculada multiplicando dois de seus lados, ou seja: "+ Convert.ToString(lado1)+" X "+Convert.ToString(lado1)+" ou "+Convert.ToString(lado1)+" X 2.";
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            if (this.lado1 != 0)
            {
                this.perimetro = this.lado1 * 4;
                lblPerimetro.Text = ("Perímetro: " + this.perimetro);
            }
            else
            {
                MessageBox.Show("Não foi possível calcular o perímetro");
            }
            pnlExplicacaoBaixo.Visible = true;
            lblExplicacao.MaximumSize = new Size(178, 0);
            lblExplicacao.Text = "O perímetro de um quadrado é calculado somando seus quatro lados, ou seja: " + Convert.ToString(lado1) + " + " + Convert.ToString(lado1) + " + " + Convert.ToString(lado1) + " + " + Convert.ToString(lado1) + " ou " + Convert.ToString(lado1) + " X 4.";
        }
    }

}
