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

        private Button button1, button2;
        private ListBox listBox1;
        private TextBox textBox1, textBox2;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Text = "Calculadora";
            // Bloquear de arrasta a janela e aumentar seu tamanho
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            // Remover o botão Maximizar
            this.MaximizeBox = false;
            // Remover o botão Minimizar
            this.MinimizeBox = false;
            // Definir icone
            this.Icon = new Icon("icon.ico");

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

            // Botao Adicionar Elementos
            button1 = new Button();
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = 200;
            button1.Location = new Point(50, 200);
            button1.Text = "Calcular";
            button1.Font = new Font("Arial", 8, FontStyle.Bold);
            button1.Size = new Size(200, 30);
            button1.Click += new EventHandler(btnCalcular);

            // Criando a Lista  
            listBox1 = new ListBox();
            listBox1.Location = new Point(50, 250);
            listBox1.Size = new Size(200, 200);

            // Botao Sair Programa
            button2 = new Button();
            //button2.Left = (this.ClientSize.Width - button2.Width) / 2;
            button2.Top = 450;
            button2.Left = 50;
            //button2.Location = new Point(400, 300);
            button2.Size = new Size(200, 30);
            //button2.BackColor = Color.MediumVioletRed;
            button2.Text = "Sair";
            button2.Font = new Font("Arial", 8, FontStyle.Bold);
            button2.Click += new EventHandler(btnSair);

            // Adicionando os Controls
            this.Controls.Add(label1);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(listBox1);
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.BackColor = Color.LightBlue;
            this.AutoSize = true;
        }
        #endregion
    }
}

