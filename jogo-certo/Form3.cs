using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogos_de_matematica
{
    public partial class Form3 : Form
    {
        private Random random = new Random();
        private int num1;
        private int num2;
        private int resultado;
        public Form3()
        {
            InitializeComponent();
        }
        private void novoJogo()
        {
            num1 = random.Next(1, 10);
            num2 = random.Next(1, 10);
            resultado = num1 - num2;

            lblNum1.Text = num1.ToString();
            lblOperacao.Text = "-";
            lblNum2.Text = num2.ToString();

            txtResposta.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            novoJogo();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int respostaUsuario;
            if (int.TryParse(txtResposta.Text, out respostaUsuario))
            {
                if (respostaUsuario == resultado)
                {
                    MessageBox.Show("Correto!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Errado! Tente novamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Digite uma resposta válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
