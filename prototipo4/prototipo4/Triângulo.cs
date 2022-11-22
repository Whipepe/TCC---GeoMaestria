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
        double? lado1, lado2, lado3, basetri1, basetri2, angulo1, angulo2, angulo2cortado, angulo3, altura, area, perimetro = null;
        double tipolado = 1; //equilatero = 1 | isósceles = 2 | escaleno = 3
        double tipoangulo = 1;

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
            //pedir o lado1 
            if (lado1 == null)
            {
                // descobrindo o lado1 com pitagoras 
                if (basetri1 != null && altura != null)
                {
                    lado1 = Math.Sqrt(Math.Pow(Convert.ToDouble(basetri1), 2) + Math.Pow(Convert.ToDouble(altura), 2));
                }
                // descobrindo o lado1 com seno
                else if (angulo1 != null && lado1 != null)
                {
                    lado1 = altura / (Math.Round(Math.Sin(Convert.ToDouble(angulo1) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                // descobrindo o lado 1 com pitagoras caso fosse tipolado == 1 ,2 
                else if (altura != null && lado3 != null && (tipolado == 1 || tipolado == 2))
                {
                    lado1 = Math.Sqrt(Math.Pow(Convert.ToDouble(lado3 / 2), 2) + Math.Pow(Convert.ToDouble(altura), 2));
                }
                // descobrindo o lado 1 com cosseno 
                else if (angulo2 != null && altura != null && (tipolado == 1 || tipolado == 2))
                {
                    lado1 = altura / (Math.Round(Math.Cos(Convert.ToDouble(angulo2 / 2) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else
                {
                    MessageBox.Show("Impossível calcular.");
                }
            }
            else
            {
                MessageBox.Show("Já está com valor");
            }
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
            //pedir o lado2 
            if (lado2 == null)
            {
                // descobrindo o lado2 com pitagoras 
                if (basetri2 != null && altura != null)
                {
                    lado2 = Math.Sqrt(Math.Pow(Convert.ToDouble(basetri2), 2) + Math.Pow(Convert.ToDouble(altura), 2));
                }
                // descobrindo o lado2 com seno
                else if (angulo3 != null && lado1 != null)
                {
                    lado2 = altura / (Math.Round(Math.Sin(Convert.ToDouble(angulo3) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                // descobrindo o lado 2 com pitagoras caso fosse tipolado == 1 ,2 
                else if (altura != null && lado3 != null && (tipolado == 1 || tipolado == 2))
                {
                    lado2 = Math.Sqrt(Math.Pow(Convert.ToDouble(lado3 / 2), 2) + Math.Pow(Convert.ToDouble(altura), 2));
                }
                // descobrindo o lado 2 com cosseno 
                else if (angulo2 != null && altura != null && (tipolado == 1 || tipolado == 2))
                {
                    lado2 = altura / (Math.Round(Math.Cos(Convert.ToDouble(angulo2 / 2) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else
                {
                    MessageBox.Show("Impossível calcular.");
                }
            }
            else
            {
                MessageBox.Show("Já está com valor");
            }
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
            //pedir o lado3 
            if (lado3 == null)
            {
                if (basetri1 != null && basetri2 != null)
                {
                    lado3 = basetri1 + basetri2;
                }
                else if (lado1 != null && lado2 != null && altura != null)
                {
                    basetri1 = Math.Sqrt(Math.Pow(Convert.ToDouble(lado1), 2) - Math.Pow(Convert.ToDouble(altura), 2));
                    basetri2 = Math.Sqrt(Math.Pow(Convert.ToDouble(lado2), 2) - Math.Pow(Convert.ToDouble(altura), 2));
                    lado3 = basetri1 + basetri2;
                }
                else if (angulo1 != null && angulo3 != null && lado1 != null && lado2 != null)
                {
                    basetri1 = (Math.Round(Math.Cos(Convert.ToDouble(angulo1) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1;

                    basetri2 = (Math.Round(Math.Cos(Convert.ToDouble(angulo3) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                    lado3 = basetri1 + basetri2;
                }
                else
                {
                    MessageBox.Show("Impossível calcular.");
                }
            }
            else
            {
                MessageBox.Show("Já está com valor");
            }
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
            if (basetri1 == null)
            {
                if (lado1 != null && altura != null)
                {
                    basetri1 = Math.Sqrt(Math.Pow(Convert.ToDouble(lado1), 2) - Math.Pow(Convert.ToDouble(altura), 2));
                }
                else if (angulo1 != null && lado1 != null)
                {
                    basetri1 = (Math.Round(Math.Cos(Convert.ToDouble(angulo1) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1;

                }
                else if (lado3 != null && basetri2 != null)
                {
                    basetri1 = lado3 - basetri2;
                }
                else if (lado2 != null && altura != null && lado3 != null)
                {
                    basetri2 = Math.Sqrt(Math.Pow(Convert.ToDouble(lado2), 2) - Math.Pow(Convert.ToDouble(altura), 2));
                    basetri1 = lado3 - basetri2;
                }
                else if (lado2 != null && angulo3 != null && lado3 != null)
                {
                    basetri2 = (Math.Round(Math.Cos(Convert.ToDouble(angulo3) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                    basetri1 = lado3 - basetri2;
                }
                else if ((tipolado == 1 || tipolado == 2) && lado3 != null)
                {
                    basetri1 = lado3 / 2;
                }
                else
                {
                    MessageBox.Show("Impossível calcular.");
                }
            }
            else
            {
                MessageBox.Show("Já está com valor");
            }
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
            if (basetri2 == null)
            {
                if (lado2 != null && altura != null)
                {
                    basetri2 = Math.Sqrt(Math.Pow(Convert.ToDouble(lado2), 2) - Math.Pow(Convert.ToDouble(altura), 2));
                }
                else if (angulo3 != null && lado2 != null)
                {
                    basetri2 = (Math.Round(Math.Cos(Convert.ToDouble(angulo3) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                }
                else if (lado3 != null && basetri1 != null)
                {
                    basetri2 = lado3 - basetri1;
                }
                else if (lado1 != null && altura != null && lado3 != null)
                {
                    basetri1 = Math.Sqrt(Math.Pow(Convert.ToDouble(lado1), 2) - Math.Pow(Convert.ToDouble(altura), 2));
                    basetri2 = lado3 - basetri1;
                }
                else if (lado1 != null && angulo1 != null && lado3 != null)
                {
                    basetri1 = (Math.Round(Math.Cos(Convert.ToDouble(angulo1) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1;
                    basetri2 = lado3 - basetri1;
                }
                else if ((tipolado == 1 || tipolado == 2) && lado3 != null)
                {
                    basetri2 = lado3 / 2;
                }
                else
                {
                    MessageBox.Show("Impossível calcular.");
                }
            }
            else
            {
                MessageBox.Show("Já está com valor");
            }
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
            if (altura == null)
            {


                if (tipolado == 1)
                {
                    //Calculos da altura do Triângulo equilátero 
                    //Calculo da altura com o lado2 e o lado3 (lado direito)
                    if (lado2 != null && lado3 != null)
                    {
                        altura = Math.Sqrt(Math.Pow(Convert.ToDouble(lado3 / 2), 2) - Math.Pow(Convert.ToDouble(lado2), 2));
                    }
                    //Calculo da altura usando bastri 1 e 2
                    else if (lado2 != null && basetri1 != null)
                    {
                        altura = Math.Sqrt(Math.Pow(Convert.ToDouble(basetri1), 2) - Math.Pow(Convert.ToDouble(lado2), 2));
                    }
                    else if (lado2 != null && basetri2 != null)
                    {
                        altura = Math.Sqrt(Math.Pow(Convert.ToDouble(basetri2), 2) - Math.Pow(Convert.ToDouble(lado2), 2));
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando seno 
                    else if (lado2 != null)
                    {
                        altura = (Math.Round(Math.Sin(Convert.ToDouble(60) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;

                    }
                    //Calculo da altura com o angulo2(lado direito) -> usando cosseno 
                    else if (lado2 != null)
                    {
                        altura = (Math.Round(Math.Sin(Convert.ToDouble(30) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando tangente 
                    else if (lado3 != null)
                    {
                        altura = (Math.Round(Math.Sin(Convert.ToDouble(30) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * (lado3 / 2);
                    }
                    //Calculo da altura com o angulo2(lado direito) -> usando tangente
                    else if (lado3 != null)
                    {
                        altura = (lado3 / 2) / (Math.Round(Math.Tan(Convert.ToDouble(30) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                    //Calculo da altura lado esquerdo
                    //Calculo da altura com o lado1 e o lado3(lado esquerdo)
                    else if (lado1 != null && lado3 != null)
                    {
                        altura = Math.Sqrt(Math.Pow(Convert.ToDouble(lado3 / 2), 2) - Math.Pow(Convert.ToDouble(lado1), 2));
                    }
                    //Calculo da altura com o angulo1(lado esquerdo) -> usando seno 
                    else if (lado1 != null)
                    {
                        altura = (Math.Round(Math.Sin(Convert.ToDouble(60) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1;
                    }
                    //Calculo da altura com o angulo2(lado esquerdo) -> usando cosseno 
                    else if (lado1 != null)
                    {
                        altura = (Math.Round(Math.Cos(Convert.ToDouble(30) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1;
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando tangente 
                    else if (lado3 != null)
                    {
                        altura = (Math.Round(Math.Tan(Convert.ToDouble(60) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * (lado3 / 2);
                    }
                    //Calculo da altura com o angulo2 -> usando tangente
                    else if (lado3 != null)
                    {
                        altura = (lado3 / 2) / (Math.Round(Math.Tan(Convert.ToDouble(30) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                    else
                    {
                        MessageBox.Show("Impossível calcular.");
                    }
                }
                // Calcula da altura do triângulo tipo 2
                else if (tipolado == 2)
                {
                    //Calculos da altura do Triângulo isóceles 
                    //Calculo da altura com o lado2 e o lado3 (lado direito)
                    if (lado2 != null && lado3 != null)
                    {
                        altura = Math.Sqrt(Math.Pow(Convert.ToDouble(lado3 / 2), 2) - Math.Pow(Convert.ToDouble(lado2), 2));
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando seno 
                    else if (angulo3 != null && lado2 != null)
                    {
                        altura = (Math.Round(Math.Sin(Convert.ToDouble(angulo3) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                    }
                    //Calculo da altura com o angulo2(lado direito) -> usando cosseno 
                    else if (angulo2 != null && lado2 != null)
                    {
                        altura = Math.Cos(Convert.ToDouble(angulo2 / 2)) * lado2;
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando tangente 
                    else if (angulo3 != null && lado3 != null)
                    {
                        altura = Math.Tan(Convert.ToDouble(angulo3)) * (lado3 / 2);
                    }
                    //Calculo da altura com o angulo2(lado direito) -> usando tangente
                    else if (angulo2 != null && lado3 != null)
                    {
                        altura = (lado3 / 2) / Math.Tan(Convert.ToDouble(angulo2 / 2));
                    }
                    //Calculo da altura lado esquerdo
                    //Calculo da altura com o lado1 e o lado3(lado esquerdo)
                    else if (lado1 != null && lado3 != null)
                    {
                        altura = Math.Sqrt(Math.Pow(Convert.ToDouble(lado3 / 2), 2) - Math.Pow(Convert.ToDouble(lado1), 2));
                    }
                    //Calculo da altura com o angulo1(lado esquerdo) -> usando seno 
                    else if (angulo1 != null && lado1 != null)
                    {
                        altura = Math.Sin(Convert.ToDouble(angulo1)) * lado1;
                    }
                    //Calculo da altura com o angulo2(lado direito) -> usando cosseno 
                    else if (angulo2 != null && lado1 != null)
                    {
                        altura = Math.Cos(Convert.ToDouble(angulo2 / 2)) * lado1;
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando tangente 
                    else if (angulo1 != null && lado3 != null)
                    {
                        altura = Math.Tan(Convert.ToDouble(angulo1)) * (lado3 / 2);
                    }
                    //Calculo da altura com o angulo2(lado direito) -> usando tangente
                    else if (angulo2 != null && lado3 != null)
                    {
                        altura = (lado3 / 2) / Math.Tan(Convert.ToDouble(angulo2 / 2));
                    }
                    else
                    {
                        MessageBox.Show("Impossível calcular.");

                    }
                }
                // Calcula da altura do triângulo tipo 3
                else
                {
                    //Calculos da altura do Triângulo escaleno 
                    //Calculo da altura com o lado2 e o lado3 (lado direito)
                    if (lado2 != null && basetri2 != null)
                    {
                        altura = Math.Sqrt(Math.Pow(Convert.ToDouble(basetri2), 2) - Math.Pow(Convert.ToDouble(lado2), 2));
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando seno 
                    else if (angulo3 != null && lado2 != null)
                    {
                        altura = Math.Sin(Convert.ToDouble(angulo3)) * lado2;
                    }
                    //Calculo da altura com o angulo2(lado direito) -> usando cosseno 
                    else if (angulo3 != null && lado2 != null)
                    {
                        // o angulo 2 no escaleno não se divide no meio, mas se fizermos angulo2cortado = 180 - 90 - angulo3 
                        angulo2cortado = 180 - angulo3;
                        altura = Math.Cos(Convert.ToDouble(angulo2cortado)) * lado2;
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando tangente 
                    else if (angulo3 != null && basetri2 != null)
                    {
                        altura = Math.Tan(Convert.ToDouble(angulo3)) * (basetri2);
                    }
                    //Calculo da altura lado esquerdo
                    //Calculo da altura com o lado1 e o lado3(lado esquerdo)
                    else if (lado1 != null && basetri1 != null)
                    {
                        altura = Math.Sqrt(Math.Pow(Convert.ToDouble(basetri1), 2) - Math.Pow(Convert.ToDouble(lado1), 2));
                    }
                    //Calculo da altura com o angulo1(lado esquerdo) -> usando seno 
                    else if (angulo1 != null && lado1 != null)
                    {
                        altura = Math.Sin(Convert.ToDouble(angulo1)) * lado1;
                    }
                    //Calculo da altura com o angulo2(lado direito) -> usando cosseno 
                    else if (angulo1 != null && lado1 != null)
                    {
                        angulo2cortado = 90 - angulo1;
                        altura = Math.Cos(Convert.ToDouble(angulo2cortado)) * lado1;
                    }
                    //Calculo da altura com o angulo3(lado direito) -> usando tangente 
                    else if (angulo1 != null && basetri1 != null)
                    {
                        altura = Math.Tan(Convert.ToDouble(angulo1)) * (basetri1);
                    }
                    else
                    {
                        MessageBox.Show("Impossível calcular.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Já está com valor");
            }
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
            if (angulo1 == null)
            {
                if (angulo2 != null && angulo3 != null)
                {
                    angulo1 = 180 - angulo2 - angulo3;
                }
                else if (tipolado == 1)
                {
                    angulo1 = 60;
                }
                else if (tipolado == 2 && angulo3 != null)
                {
                    angulo1 = angulo3;
                }
                else if (lado1 != null && altura != null)
                {
                    Math.Pow(Math.Sin(Convert.ToDouble(altura / lado1)), -1);
                }
            }
            else
            {
                MessageBox.Show("Já está com valor");
            }
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

        private void btnExibir_Click(object sender, EventArgs e)
        {
            pnlExibir.Visible = true;
            pnlExibir.BringToFront();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            pnlOcultar.Visible = true;
            pnlOcultar.BringToFront();
        }

        private void pnlExibir_Leave(object sender, EventArgs e)
        {
            pnlExibir.Visible = false;
        }

        private void pnlOcultar_Leave(object sender, EventArgs e)
        {
            pnlOcultar.Visible = false;
        }

        private void btnExibirAltura_Click(object sender, EventArgs e)
        {
            altura_visivel = true;

            //isósceles
           if (tipolado == 1)
            {
                if (angulo_visivel == true)
                {
                    pictureBox1.Load("triangulo_isosceles_altura_angulos.png");
                }
                else
                {
                    pictureBox1.Load("triangulo_isosceles_altura.png");
                }
            }

            btnAltura.Visible = true;
            btnAltura.BringToFront();
            btnBasetri1.Visible = true;
            btnBasetri1.BringToFront();
            btnBasetri2.Visible = true;
            btnBasetri2.BringToFront();
        }

        private void btnExibirAngulos_Click(object sender, EventArgs e)
        {
            angulo_visivel = true;

            //isósceles
            if (tipolado == 1)
            {
                if (altura_visivel == true)
                {
                    pictureBox1.Load("triangulo_isosceles_altura_angulos.png");
                }
                else
                {
                    pictureBox1.Load("triangulo_isosceles_angulos.png");
                }

            }

            btnAngulo1.Visible = true;
            btnAngulo1.BringToFront();
            btnAngulo2.Visible = true;
            btnAngulo2.BringToFront();
            btnAngulo3.Visible = true;
            btnAngulo3.BringToFront();

        }

        private void btnOcultarAltura_Click(object sender, EventArgs e)
        {
            altura_visivel = false;

            //isósceles
            if (tipolado == 1)
            {
                if (angulo_visivel == true)
                {
                    pictureBox1.Load("triangulo_isosceles_angulos.png");
                }
                else
                {
                    pictureBox1.Load("triangulo_isosceles.png");
                }
            }

            btnAltura.Visible = false;
            btnBasetri1.Visible = false;
            btnBasetri2.Visible = false;
        }

        private void btnOcultarAngulos_Click(object sender, EventArgs e)
        {
            angulo_visivel = false;

            //isósceles
            if (tipolado == 1)
            {
                if (altura_visivel == true)
                {
                    pictureBox1.Load("triangulo_isosceles_altura.png");
                }
                else
                {
                    pictureBox1.Load("triangulo_isosceles.png");
                }
            }

            btnAngulo1.Visible = false;
            btnAngulo2.Visible = false;
            btnAngulo3.Visible = false;
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //variáveis
            angulo_visivel = false;
            altura_visivel = false;
            lado1 = null;
            lado2 = null;
            lado3 = null;
            basetri1 = null;
            basetri2 = null;
            angulo1 = null;
            angulo2 = null;
            angulo3 = null;
            altura = null;
            area = null;
            perimetro = null;

            //labels
            lblAngulo1.Visible = false;
            lblAngulo2.Visible = false;
            lblAngulo3.Visible = false;
            lblLado1.Visible = false;
            lblLado2.Visible = false;
            lblLado3.Visible = false;
            lblBasetri1.Visible = false;
            lblBasetri2.Visible = false;
            lblAltura.Visible = false;
            lblArea.Text = "Área: ";
            lblPerimetro.Text = "Perímetro: ";

            //buttons
            btnBasetri1.Visible = false;
            btnBasetri2.Visible = false;
            btnAngulo1.Visible = false;
            btnAngulo2.Visible = false;
            btnAngulo3.Visible = false;
            btnAltura.Visible = false;

            //imagem
            if (tipolado == 1)
            {
                pictureBox1.Load("triangulo_equilatero");
            }
        }

        public void TipoLadoTriangulo()
        {
            if ((angulo1 == angulo2 && angulo2 == angulo3 && angulo3 == angulo1) || (lado1 == lado2 && lado2 == lado3 && lado3 == lado1))
            {
                //tipo 1 é equilatero
                this.tipolado = 1;
            }
            else if ((lado1 == lado2) || (angulo1 == angulo2))
            {
                //tipo 2 é isósceles
                this.tipolado = 2;
            }
            else if ((lado1 != null && lado2 != null && lado3 != null) || angulo1 != null && angulo2 != null && angulo3 != null)
            {
                // tipo 3 é escaleno
                this.tipolado = 3;
            }
            else
            {

            }
        }

    }
}
