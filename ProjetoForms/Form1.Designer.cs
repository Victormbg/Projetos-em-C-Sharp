using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Button btnLimpar, btnSair, btnCalcular;
        private ListBox listBox1;
        private TextBox textBox1, textBox2;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // Tamanho da Janela
            this.ClientSize = new System.Drawing.Size(300, 500);
            // Titulo da Janela
            this.Text = "Calculadora";
            // Bloquear de arrasta a janela e aumentar seu tamanho
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            // Remover o botão Maximizar
            this.MaximizeBox = false;
            // Remover o botão Minimizar
            //this.MinimizeBox = false;
            // Definir icone da Janela
            this.Icon = new Icon("icon.ico");
            // Cor de Fundo da Janela
            this.BackColor = Color.LightBlue;
            // auto redimensionar a janela
            this.AutoSize = true;

            // Criando a Label
            Label label1 = new Label();
            label1.Text = "Calculadora";
            label1.Top = 20;
            label1.Left = 0;
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Size = new Size(300, 60);

            // INPUT VALOR1
            textBox1 = new TextBox();
            textBox1.Location = new Point(50, 100);
            textBox1.Name = "txtInput";
            textBox1.Size = new Size(200, 20);
            textBox1.TabIndex = 0;

            // INPUT VALOR2
            textBox2 = new TextBox();
            textBox2.Location = new Point(50, 150);
            textBox2.Name = "txtInput";
            textBox2.Size = new Size(200, 20);
            textBox2.TabIndex = 0;

            // Botao Calcular
            btnCalcular = new Button();
            btnCalcular.Left = (this.ClientSize.Width - btnCalcular.Width) / 2;
            btnCalcular.Top = 200;
            btnCalcular.Location = new Point(50, 200);
            btnCalcular.Text = "Calcular";
            btnCalcular.Font = new Font("Arial", 8, FontStyle.Bold);
            btnCalcular.Size = new Size(200, 30);
            btnCalcular.Click += new EventHandler(Calcular);

            // Botao Limpar
            btnLimpar = new Button();
            btnLimpar.Left = (this.ClientSize.Width - btnLimpar.Width) / 2;
            btnLimpar.Top = 200;
            btnLimpar.Location = new Point(50, 250);
            btnLimpar.Text = "Limpar";
            btnLimpar.Font = new Font("Arial", 8, FontStyle.Bold);
            btnLimpar.Size = new Size(200, 30);
            btnLimpar.Click += new EventHandler(Limpar);

            // Criando a Lista  
            listBox1 = new ListBox();
            listBox1.Location = new Point(50, 300);
            listBox1.Size = new Size(200, 200);

            // Botao Sair Programa
            btnSair = new Button();
            btnSair.Top = 500;
            btnSair.Left = 50;
            btnSair.Size = new Size(200, 30);
            //btnSair.BackColor = Color.MediumVioletRed;
            btnSair.Text = "Sair";
            btnSair.Font = new Font("Arial", 8, FontStyle.Bold);
            btnSair.Click += new EventHandler(Sair);

            // Adicionando os Controls
            this.Controls.Add(label1);
            this.Controls.Add(btnCalcular);
            this.Controls.Add(btnLimpar);
            this.Controls.Add(btnSair);
            this.Controls.Add(listBox1);
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
        }
        #endregion
    }
}

