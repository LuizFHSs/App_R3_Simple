using Regra_de_Tres.Classes;

namespace Regra_de_Tres
{
    public partial class Form1 : Form
    {
        Calcular calcular = new Calcular();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Defina Uma Regra para Poder Realizar o Calculo Correto!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtD1.Text == "" || txtD2.Text == "" || txtD3.Text == "" || txtD4.Text == "")
                {
                    MessageBox.Show("Preencha as Caixas de Textos para Validar o Calculo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string regra = comboBox1.SelectedItem.ToString();
                    calcular.DefinirRegra(regra, txtD1.Text, txtD2.Text, txtD3.Text, txtD4.Text);

                }
            }
            label5.Text = calcular.regraDefinida;
        }

        private void btnAddGrandeza_Click(object sender, EventArgs e)
        {
            label3.Text = txtG1.Text;
            label6.Text = txtG2.Text;

            txtG1.Clear();
            txtG2.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtD1.Clear();
            txtD2.Clear();
            txtD3.Clear();
            txtD4.Clear();

            label3.Text = "----";
            label6.Text = "----";

            label5.Text = "0";
        }
    }
}
