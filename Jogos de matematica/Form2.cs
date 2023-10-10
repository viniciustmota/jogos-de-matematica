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
    public partial class Form2 : Form
    {

        private Random random = new Random();
        private int num1;
        private int num2;
        private int resultado;

        public Form2()
        {

        InitializeComponent();
        }
        private void novoJogo()
        {
            num1 = random.Next(1, 10);
            num2 = random.Next(1, 10);
            resultado = num1 + num2;

            lblNum1.Text = num1.ToString();
            lblOperacao.Text = "+";
            lblNum2.Text = num2.ToString();

            txtResposta.Clear();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            novoJogo();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            int respostaUsuario;
            if(int.TryParse.Text, out respostaUsuari)
        }
    }
}
