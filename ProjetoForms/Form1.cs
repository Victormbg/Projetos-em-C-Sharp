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
    public partial class Form1 : Form
    {
        private PictureBox pictureBox1 = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }
        private void Limpar(object sender, EventArgs e)
        {
            const string message = "Você deseja limpar a lista?";
            const string caption = "Limpando...";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                // NAO FUNCIONA REVER ESSA PARTE
                for (int i = listBox1.Items.Count - 1; i > -1; i--)
                {
                    {
                        if (listBox1.Items[i].ToString().Contains("OBJECT"))
                        {
                            listBox1.Items.RemoveAt(i);
                        }
                    }
                }
            }
        }
        private void Sair(object sender, EventArgs e)
        {
            const string message = "Você deseja sair do Programa?";
            const string caption = "Fechando...";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Calcular(object sender, EventArgs e)
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

                // Remover todos os itens
                listBox1.Items.Clear();
                // Adicionar itens
                listBox1.Items.Add("A soma é " + resSoma);
                listBox1.Items.Add("A subtração é " + resSubtracao);
                listBox1.Items.Add("A multiplicação é " + resMultiplicacao);
                listBox1.Items.Add("A divição é " + resDivisao);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Codigo de erro: " + ex.GetType());
                const string message = "Valor Inválido";
                const string caption = "ERRO";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine("Codigo de erro: " + ex.GetType());
                const string message = "Erro Desconhecido";
                const string caption = "ERRO";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }
    }
}
