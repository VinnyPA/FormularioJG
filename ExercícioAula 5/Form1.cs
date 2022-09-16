using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercícioAula_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jogador jgd;
        Jogador[] v = new Jogador[10];
        int i = 0;
        private void btmGravar_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                jgd = new Jogador();
                jgd.Nome = txtNome.Text;
                jgd.Peso = Convert.ToDouble(txtPeso.Text);
                jgd.Altura = Convert.ToDouble(txtAltura.Text);
                jgd.Idade = Convert.ToInt32(txtIdade.Text);
                jgd.NumCamisa = Convert.ToInt32(txtNumCamisa.Text);
                jgd.Time = txtTime.Text;
                v[i] = jgd;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possível gravar!");
            }
        }

        private void btmPesquisar_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                if (v[j].Nome.Equals(txtNome.Text))
                {
                    txtNome.Text = v[j].Nome;
                    txtPeso.Text = v[j].Peso.ToString();
                    txtAltura.Text = v[j].Altura.ToString();
                    txtIdade.Text = v[j].Idade.ToString();
                    txtNumCamisa.Text = v[j].NumCamisa.ToString();
                    txtTime.Text = v[j].Time.ToString();
                    j = 9;
                }
                else
                {
                    if (j == 9) MessageBox.Show("Jogador não encontrado!");
                }
            }
        }
    }
}
