using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo4
{
    public partial class Triângulo : UserControl
    {
        public Triângulo()
        {
            InitializeComponent();
        }

        bool angulo_visivel, altura_visivel = false;
        double? lado1, lado2, lado3, basetri1, basetri2, angulo1, angulo2, angulo3, altura, area, perimetro = null;

        private void btnLado1_Click(object sender, EventArgs e)
        {
            pnlLado1.Visible = true;
            pnlLado1.BringToFront();
        }

        private void btnInserirLado1_Click(object sender, EventArgs e)
        {
            txtLado1.Visible = true;
            txtLado1.BringToFront();
        }

        private void txtLado1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lado1 = Convert.ToDouble(txtLado1.Text);
                lblLado1.Text = Convert.ToString(this.lado1);
                lblLado1.Visible = true;
                lblLado1.BringToFront();
                pnlLado1.Visible = false;
                txtLado1.Visible = false;
            }
        }

        private void btnPedirLado1_Click(object sender, EventArgs e)
        {

        }

        private void btnLado2_Click(object sender, EventArgs e)
        {
            pnlLado2.Visible = true;
            pnlLado2.BringToFront();
        }

        private void btnInserirLado2_Click(object sender, EventArgs e)
        {
            txtLado2.Visible = true;
            txtLado2.BringToFront();
        }

        private void txtLado2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lado2 = Convert.ToDouble(txtLado2.Text);
                lblLado2.Text = Convert.ToString(this.lado2);
                lblLado2.Visible = true;
                lblLado2.BringToFront();
                pnlLado2.Visible = false;
                txtLado2.Visible = false;
            }
        }
        private void btnPedirLado2_Click(object sender, EventArgs e)
        {

        }

        private void btnLado3_Click(object sender, EventArgs e)
        {
            pnlLado3.Visible = true;
            pnlLado3.BringToFront();
        }

        private void btnInserirLado3_Click(object sender, EventArgs e)
        {
            txtLado3.Visible = true;
            txtLado3.BringToFront();
        }

        private void txtLado3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lado3 = Convert.ToDouble(txtLado3.Text);
                lblLado3.Text = Convert.ToString(this.lado3);
                lblLado3.Visible = true;
                lblLado3.BringToFront();
                pnlLado3.Visible = false;
                txtLado3.Visible = false;
            }
        }

        private void btnPedirLado3_Click(object sender, EventArgs e)
        {

        }

        private void btnBasetri1_Click(object sender, EventArgs e)
        {
            pnlBasetri1.Visible = true;
            pnlBasetri1.BringToFront();
        }

        private void btnInserirBasetri1_Click(object sender, EventArgs e)
        {
            txtBasetri1.Visible = true;
            txtBasetri1.BringToFront();
        }

        private void txtBasetri1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.basetri1 = Convert.ToDouble(txtBasetri1.Text);
                lblBasetri1.Text = Convert.ToString(this.basetri1);
                lblBasetri1.Visible = true;
                lblBasetri1.BringToFront();
                pnlBasetri1.Visible = false;
                txtBasetri1.Visible = false;
            }
        }

        private void btnPedirBasetri1_Click(object sender, EventArgs e)
        {

        }

        private void btnBasetri2_Click(object sender, EventArgs e)
        {
            pnlBasetri2.Visible = true;
            pnlBasetri2.BringToFront();
        }

        private void btnInserirBasetri2_Click(object sender, EventArgs e)
        {
            txtBasetri2.Visible = true;
            txtBasetri2.BringToFront();
        }

        private void txtBasetri2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.basetri2 = Convert.ToDouble(txtBasetri2.Text);
                lblBasetri2.Text = Convert.ToString(this.basetri2);
                lblBasetri2.Visible = true;
                lblBasetri2.BringToFront();
                pnlBasetri2.Visible = false;
                txtBasetri2.Visible = false;
            }
        }

        private void btnPedirBasetri2_Click(object sender, EventArgs e)
        {

        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            pnlAltura.Visible = true;
            pnlAltura.BringToFront();
        }

        private void btnInserirAltura_Click(object sender, EventArgs e)
        {
            txtAltura.Visible = true;
            txtAltura.BringToFront();
        }

        private void txtAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.altura = Convert.ToDouble(txtAltura.Text);
                lblAltura.Text = Convert.ToString(this.altura);
                lblAltura.Visible = true;
                lblAltura.BringToFront();
                pnlAltura.Visible = false;
                txtAltura.Visible = false;
            }
        }

        private void btnPedirAltura_Click(object sender, EventArgs e)
        {

        }

        private void btnAngulo1_Click(object sender, EventArgs e)
        {
            pnlAngulo1.Visible = true;
            pnlAngulo1.BringToFront();
        }

        private void btnInserirAngulo1_Click(object sender, EventArgs e)
        {
            txtAngulo1.Visible = true;
            txtAngulo1.BringToFront();
        }

        private void txtAngulo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.angulo1 = Convert.ToDouble(txtAngulo1.Text);
                lblAngulo1.Text = Convert.ToString(this.angulo1);
                lblAngulo1.Visible = true;
                lblAngulo1.BringToFront();
                pnlAngulo1.Visible = false;
                txtAngulo1.Visible = false;
            }
        }

        private void btnPedirAngulo1_Click(object sender, EventArgs e)
        {

        }

        private void btnAngulo2_Click(object sender, EventArgs e)
        {
            pnlAngulo2.Visible = true;
            pnlAngulo2.BringToFront();
        }

        private void btnInserirAngulo2_Click(object sender, EventArgs e)
        {
            txtAngulo2.Visible = true;
            txtAngulo2.BringToFront();
        }

        private void txtAngulo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.angulo2 = Convert.ToDouble(txtAngulo2.Text);
                lblAngulo2.Text = Convert.ToString(this.angulo2);
                lblAngulo2.Visible = true;
                lblAngulo2.BringToFront();
                pnlAngulo2.Visible = false;
                txtAngulo2.Visible = false;
            }
        }

        private void btnPedirAngulo2_Click(object sender, EventArgs e)
        {

        }

        private void btnAngulo3_Click(object sender, EventArgs e)
        {
            pnlAngulo3.Visible = true;
            pnlAngulo3.BringToFront();
        }

        private void btnInserirAngulo3_Click(object sender, EventArgs e)
        {
            txtAngulo3.Visible = true;
            txtAngulo3.BringToFront();
        }

        private void txtAngulo3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.angulo3 = Convert.ToDouble(txtAngulo3.Text);
                lblAngulo3.Text = Convert.ToString(this.angulo3);
                lblAngulo3.Visible = true;
                lblAngulo3.BringToFront();
                pnlAngulo3.Visible = false;
                txtAngulo3.Visible = false;
            }
        }

        private void btnPedirAngulo3_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (lado3 != null && altura != null)
            {
                this.area = (lado3 * altura) / 2;
                lblArea.Text = "Área: " + Convert.ToString(this.area);
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "A área de um triângulo é calculada com a seguinte fórmula: (base * altura)/2, ou seja: (" + Convert.ToString(lado3) + " * " + Convert.ToString(altura) + ")/2";
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
            }
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            if (lado1 != null && lado2 != null && lado3 != null)
            {
                this.perimetro = lado1 + lado2 + lado3;
                lblPerimetro.Text = "Perímetro: " + Convert.ToString(this.perimetro);
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "O perímetro de um triângulo é calculado somando todos seus lados, ou seja: " + Convert.ToString(lado1) + " + " + Convert.ToString(lado2) + " + " + Convert.ToString(lado3);
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
            }
        }


    }
}
