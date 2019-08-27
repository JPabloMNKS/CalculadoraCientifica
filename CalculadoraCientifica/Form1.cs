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


    }
}
