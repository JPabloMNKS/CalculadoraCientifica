using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class Form1 : Form
    {
        // Drag Window Panel
        private bool draggable;
        private int mouseX;
        private int mouseY;

        // Variables de Calculadora
        bool igual = true, inicio = true, operacion1 = true, operacion2 = true;
        double a, b, c, memoria = 0, resultado, valor1, valor2;
        String funciones, tipoOperaciones;

        //Botones numericos


        public Form1()
        {
            InitializeComponent();
        }

        // Drag Window
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Calculadora

        private void Numero_Click(int n)
        {
            if (inicio)
            {
                textBox_principal.Text = "";
                textBox_principal.Text = n+"";
                inicio = false;
            }
            else
            {
                textBox_principal.Text += n + "";
            }
        }


        private void Btn1_Click(object sender, EventArgs e)
        {
            Numero_Click(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Numero_Click(2);
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            Numero_Click(3);
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            Numero_Click(4);
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            Numero_Click(5);
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            Numero_Click(6);
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            Numero_Click(7);
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            Numero_Click(8);
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            Numero_Click(9);
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            Numero_Click(0);
        }
        private void Btn_decimal_Click(object sender, EventArgs e)
        {
            if (textBox_principal.Text.Contains("."))
            {

            }
            else
            {
                textBox_principal.Text += ".";
                inicio = false;
            }
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            funcion_click("+");
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            funcion_click("-");
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            funcion_click("*");
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            funcion_click("/");
        }
        private void BtnSin_Click(object sender, EventArgs e)
        {
            funciones = "Sin";
            Trigonometria();
        }
        private void BtnCos_Click(object sender, EventArgs e)
        {
            funciones = "Cos";
            Trigonometria();
        }
        private void BtnTan_Click(object sender, EventArgs e)
        {
            funciones = "Tan";
            Trigonometria();
        }
        private void BtnSin1_Click(object sender, EventArgs e)
        {
            funciones = "Sin1";
            Trigonometria();
        }
        private void BtnCos1_Click(object sender, EventArgs e)
        {
            funciones = "Cos1";
            Trigonometria();
        }
        private void BtnTan1_Click(object sender, EventArgs e)
        {
            funciones = "Tan1";
            Trigonometria();
        }

        private void Trigonometria()
        {
            if (rbHexadecimal.Checked)
            {
                switch (funciones)
                {
                    case "Sin":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Sin( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Sin(Math.PI * (valor1) / 180));
                        break;
                    case "Sin1":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Sin^-1( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Asin(valor1) * 180/Math.PI);
                        break;

                    case "Cos":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Cos( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Cos(Math.PI * (valor1) / 180));
                        break;
                    case "Cos1":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Cos^-1( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Acos(valor1) * 180 / Math.PI);
                        break;

                    case "Tan":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Tan( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Tan(Math.PI * (valor1) / 180));
                        break;
                    case "Tan1":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Tan^-1( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Atan(valor1) * 180 / Math.PI);
                        break;
                }
            }
            else if (rbRadianes.Checked)
            {
                switch (funciones)
                {
                    case "Sin":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Sin( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Sin(valor1));
                        break;
                    case "Sin1":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Sin^-1( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Asin(valor1));
                        break;

                    case "Cos":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Cos( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Cos(valor1));
                        break;
                    case "Cos1":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Cos^-1( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Acos(valor1));
                        break;

                    case "Tan":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Tan( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Tan(valor1));
                        break;
                    case "Tan1":
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                        txtBox_previo.Text = "Tan^-1( " + valor1.ToString() + " )";
                        textBox_principal.Text = Convert.ToString(Math.Atan(valor1));
                        break;
                }
            }
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            txtBox_previo.Text = "";
            textBox_principal.Text = Math.PI.ToString();
        }

        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox_principal.Text);
            if(valor1 >= 0)
            {
                txtBox_previo.Text = "sqrt(" + valor1 + ")";
                textBox_principal.Text = Convert.ToString(Math.Sqrt(valor1));
            }
            else
            {
                textBox_principal.Text = "Error";
            }
        }

        private void BtnPorcentaje_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(textBox_principal.Text);
            txtBox_previo.Text += textBox_principal;
            textBox_principal.Text = Convert.ToString((valor1 * valor2) / 100);
            igual = true;
        }
        private void Btn1x_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox_principal.Text);
            txtBox_previo.Text = "reciproc( " + valor1.ToString() + " )";
            textBox_principal.Text = Convert.ToString(1 / valor1);
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            textBox_principal.Text = "0";
            txtBox_previo.Text = "";
            inicio = true;
            funciones = "";
            operacion1 = true;
            operacion2 = true;
            igual = true;
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtBox_previo.Text = "";
            textBox_principal.Text = "0";
            inicio = true;
            funciones = "";
        }

        private void BtnRetroceso_Click(object sender, EventArgs e)
        {
            if (textBox_principal.Text.Length > 1)
            {
                textBox_principal.Text = textBox_principal.Text.Remove(textBox_principal.Text.Length-1,1);
                if(textBox_principal.Text.Length == 1)
                {
                    textBox_principal.Text = "0";
                    inicio = true;
                }
                if(textBox_principal.Text == "0")
                {

                }
            }
        }

        private void BtnMasMenos_Click(object sender, EventArgs e)
        {
            textBox_principal.Text = Convert.ToString(0 - Convert.ToDouble(textBox_principal.Text));
        }







        private void BtnIgual_Click(object sender, EventArgs e)
        {
            inicio = true;
            operacion1 = true;
            if (igual)
            {
                if(tipoOperaciones == null)
                {

                }
                else
                {
                    valor2 = Convert.ToDouble(textBox_principal.Text);
                    txtBox_previo.Text += textBox_principal;
                    Operaciones(valor1, valor2);
                    igual = false;
                }
            }
        }
        private void funcion_click(string signo)
        {
            igual = true;
            inicio = true;
            if (operacion1)
            {
                valor1 = Convert.ToDouble(textBox_principal.Text);
                txtBox_previo.Text = "";
                txtBox_previo.Text += textBox_principal.Text + signo;
                operacion1 = false;
            }
            else if (operacion2)
            {
                valor2 = Convert.ToDouble(textBox_principal.Text);
                txtBox_previo.Text += textBox_principal.Text + signo;
                operacion2 = false;
            }
            else
            {
                txtBox_previo.Text += textBox_principal.Text + signo;
                Operaciones(resultado, valor2);
            }
            tipoOperaciones = signo;
        }
        private void Operaciones(double valor1,double valor2)
        {
            switch (tipoOperaciones)
            {
                case "+":
                    resultado = valor1 + valor2;
                    textBox_principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(textBox_principal.Text);
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    textBox_principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(textBox_principal.Text);
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    textBox_principal.Text = resultado.ToString();
                    valor1 = Convert.ToDouble(textBox_principal.Text);
                    break;
                case "/":
                    if(valor2 == 0)
                    {
                        textBox_principal.Text = "Error";
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                        textBox_principal.Text = resultado.ToString();
                        valor1 = Convert.ToDouble(textBox_principal.Text);
                    }
                    break;

            }
        }
    }
}
