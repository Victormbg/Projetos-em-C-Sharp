using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms
{
    public partial class Form1 : Form
    {
        private Button button1, button2;
        private ListBox listBox1;
        public Form1()
        {
            InitializeComponent();

            // Criando a Label
            Label label1 = new Label();
            label1.Text = "Clique em adicionar elemento para preencher a lista:";
            label1.Top = 20;
            label1.Left = 250;
            label1.Font = new Font("Arial", 12,FontStyle.Bold);
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Size = new Size(300, 60);

            // Botao Adicionar Elementos
            button1 = new Button();
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = 200;
            button1.Location = new Point(300, 200);
            button1.Text = "Adicionar Elementos";
            button1.Font = new Font("Arial", 8,FontStyle.Bold);
            button1.Size = new Size(175, 30);
            button1.Click += new EventHandler(btnAdd);

            // Botao Sair Programa
            button2 = new Button();
            button2.Left = (this.ClientSize.Width - button2.Width) / 2;
            button2.Top = 300;
            //button2.Location = new Point(400, 300);
            button2.Size = new Size(75, 30);
            button2.BackColor = Color.MediumVioletRed;
            button2.Text = "Sair";
            button2.Font = new Font("Arial", 8,FontStyle.Bold);
            button2.Click += new EventHandler(btnSair);

            // Criando a Lista  
            listBox1 = new ListBox();
            listBox1.Location = new Point(300, 100);
            listBox1.Size = new Size(200, 100);

            this.Controls.Add(label1);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(listBox1);
            this.BackColor = Color.LightBlue;
            this.AutoSize = true;

        }
        private void btnSair(object sender, EventArgs e)
        {
            while (MessageBox.Show("Sair do Programa", "",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Console.WriteLine("Saindo");
            }
            Application.Exit();
        }

        private void btnAdd(object sender, System.EventArgs e)
        {
            int count = 1;
            // Check to see whether the user wants to exit the application.
            // If not, add a number to the list box.
            while (MessageBox.Show("Adicionar Elemento?", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listBox1.Items.Add(count);
                count += 1;
            }
        }

    }
}
