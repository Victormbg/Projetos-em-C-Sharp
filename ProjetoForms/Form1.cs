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
    class Valores
    {
        private string valor1;
        private string valor2;

        public string Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        public string Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        public int soma(int a, int b)
        {
            return a + b;
        }
        public int subtracao(int a, int b)
        {
            return a - b;
        }
        public int multiplicacao(int a, int b)
        {
            return a * b;
        }
        public int divisao(int a, int b)
        {
            return a / b;
        }
    }
    public partial class Form1 : Form
    {
        private Button button1, button2;
        private ListBox listBox1;
        private TextBox textBox1, textBox2;
        public Form1()
        {
            InitializeComponent();

            // Criando a Label
            Label label1 = new Label();
            label1.Text = "Calculadora";
            label1.Top = 20;
            label1.Left = 250;
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Size = new Size(300, 60);

            // INPUT VALOR1
            textBox1 = new TextBox();
            textBox1.Location = new Point(300, 100);
            textBox1.Name = "txtInput";
            textBox1.Size = new Size(200, 20);
            textBox1.TabIndex = 0;

            // INPUT VALOR2
            textBox2 = new TextBox();
            textBox2.Location = new Point(300, 150);
            textBox2.Name = "txtInput";
            textBox2.Size = new Size(200, 20);
            textBox2.TabIndex = 0;

            // Botao Adicionar Elementos
            button1 = new Button();
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = 200;
            button1.Location = new Point(300, 200);
            button1.Text = "Calcular";
            button1.Font = new Font("Arial", 8, FontStyle.Bold);
            button1.Size = new Size(175, 30);
            button1.Click += new EventHandler(btnCalcular);

            // Criando a Lista  
            listBox1 = new ListBox();
            listBox1.Location = new Point(300, 250);
            listBox1.Size = new Size(200, 200);

            // Botao Sair Programa
            button2 = new Button();
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
            button2.Top = 450;
            //button2.Location = new Point(400, 300);
            button2.Size = new Size(75, 30);
            button2.BackColor = Color.MediumVioletRed;
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
        private void btnSair(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sair do Programa", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Console.WriteLine("Saindo...");
                Application.Exit();
            }
        }

        private void btnCalcular(object sender, EventArgs e)
        {
            try
            {
                var valor = new Valores();
                valor.Valor1 = textBox1.Text;
                valor.Valor2 = textBox2.Text;

                int resSoma = valor.soma(Convert.ToInt32(valor.Valor1), Convert.ToInt32(valor.Valor2));
                int resSubtracao = valor.subtracao(int.Parse(valor.Valor1), int.Parse(valor.Valor2));
                int resMultiplicacao = valor.multiplicacao(int.Parse(valor.Valor1), int.Parse(valor.Valor2));
                int resDivisao = valor.divisao(int.Parse(valor.Valor1), int.Parse(valor.Valor2));

                listBox1.Items.Add("A soma é " + resSoma);
                listBox1.Items.Add("A subtração é " + resSubtracao);
                listBox1.Items.Add("A multiplicação é " + resMultiplicacao);
                listBox1.Items.Add("A divição é " + resDivisao);
            }
            catch (System.FormatException ex)
            {
                // ERRO AINDA NAO FUNCIONA
                Console.WriteLine("Codigo de erro: " + ex.GetType() + "\nMensagem: Foi inserido um valor com caractere no formato errado.");
                /*
                Label label2 = new Label();
                label2.Text = "Codigo de erro: " + ex.GetType() + "\nMensagem: Foi inserido um valor com caractere no formato errado.";
                label2.Top = 20;
                label2.Left = 250;
                label2.Font = new Font("Arial", 12, FontStyle.Bold);
                label2.ForeColor = Color.Red;
                label2.TextAlign = ContentAlignment.TopCenter;
                label2.Size = new Size(400, 60);
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine("Erro ao executar: " + ex.Message);
            }
        }
    }
}
