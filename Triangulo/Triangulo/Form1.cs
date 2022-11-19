using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        double? lado1, lado2, lado3, angulo1, angulo2, angulo3, altura, area, perimetro, basetri1, basetri2, tipolado, tipoangulo = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            TipoAnguloTriangulo();
            TipoLadoTriangulo();
            CalcularAltura();
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
        public void TipoAnguloTriangulo()
        {
            if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
            {
                // tipo 1 é retângulo
                this.tipoangulo = 1;
            }
            else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
            {
                // tipo 1 é obtusangulo
                this.tipoangulo = 2;
            }
            else if ((angulo1 < 90 && angulo2 < 90) || (angulo1 < 90 && angulo2 < 90) || (angulo2 < 90 && angulo3 < 90))
            {
                // tipo 3 é acutângulo
                this.tipoangulo = 3;
            }
            else
            {

            }
        }
        private double CalcularAltura()
        {
            if (tipolado == 1)
            {
                //Calculos da altura do Triângulo equilátero 
                //Calculo da altura com o lado2 e o lado3 (lado direito)
                if (lado2 != null && lado3 != null)
                {
                    altura = Math.Sqrt(Math.Pow(Convert.ToDouble(lado3 / 2), 2) - Math.Pow(Convert.ToDouble(lado2), 2));
                }
                //Calculo da altura com o angulo3(lado direito) -> usando seno 
                else if (angulo3 != null && lado2 != null)
                {
                    altura = Math.Sin(Convert.ToDouble(angulo3)) * lado2;
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

                }
            }
            // Calcula da altura do triângulo tipo 2
            if (tipolado == 2)
            {
                altura = angulo3;
            }
            // Calcula da altura do triângulo tipo 3
            if (tipolado == 3)
            {
               altura = angulo3;
            }
            return Convert.ToDouble(this.altura);
        }
        public double Angulos()
        {
            //calculos para descobrir o angulo1 
            if(angulo2 != null && angulo3 != null)
            {
                angulo1 = 180 - angulo2 - angulo3;
                return Convert.ToDouble(this.angulo3);
            }
            else
            {
                return Convert.ToDouble(this.angulo3);
            }
            //calculos para descobrir o angulo2
            if(angulo1 != null && angulo3 != null)
            {
                angulo2 = 180 - angulo1 - angulo3;
                return Convert.ToDouble(this.angulo3);
            }
            //calculos para descobrir o angulo3
            if (angulo1 != null && angulo2 != null)
            {
                angulo3 = 180 - angulo2 - angulo1;
                return Convert.ToDouble(this.angulo3);
            }
        }
        public double Lados()
        {
            //calculos para descobrir os lados 
            //calculos para descobrir os lados do equilátero 
            if (tipolado == 1)
            {
                if(lado1 != null)
                {
                    lado2 = lado1;
                    lado3 = lado1;                   
                }
                else if(lado2 != null)
                {
                    lado1 = lado2;
                    lado3 = lado2;
                }
                else if(lado3 != null)
                {
                    lado1 = lado3;
                    lado2 = lado3;
                }
                //Calculo dos lados do triangulo equilátero com a altura e um angulo
                else if (altura != null && angulo1 != null)
                {
                    lado1 = altura / Math.Sin(Convert.ToDouble(angulo1));
                    lado2 = lado1;
                    lado3 = lado1;
                }
                else if (altura != null && angulo2 != null)
                {
                    lado1 = altura / Math.Cos(Convert.ToDouble(angulo2/2));
                    lado2 = lado1;
                    lado3 = lado1;
                }
                else if (altura != null && angulo3 != null)
                {
                    lado1 = altura / Math.Sin(Convert.ToDouble(angulo3));
                    lado2 = lado1;
                    lado3 = lado1;
                }
            }
        }
    }
}
