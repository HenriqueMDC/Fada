using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaFada
{
    public partial class CadastroDeFada : Form
    {
        string nomeAntigo = string.Empty;
        List<Fadas2> fadas = new List<Fadas2>();
        List<Fadas2> fadas2 = new List<Fadas2>();

        public CadastroDeFada()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fadas2 fada = new Fadas2(txtNome.Text, txtFamilia.Text, cbCor.Text, rbSim1.Checked);
                {
                    fada.Nome = txtNome.Text;
                    fada.Familia = txtFamilia.Text;
                    fada.Cor = cbCor.Text;
                    fada.CorAsa = cbCorAsa.Text;
                    fada.TamanhoAsa = Convert.ToDecimal(txtTamanhoAsa.Text);
                    if (rbSim1.Checked)
                    {
                        rbSim1.Checked = true;
                    }

                    else if (rbNao1.Checked)
                    {
                        rbNao1.Checked = false;
                    }
                    if (rbSim2.Checked)
                    {
                        rbSim2.Checked = true;
                    }

                    else if (rbNao2.Checked)
                    {
                        rbNao2.Checked = false;
                    }
                    if (rbSim3.Checked)
                    {
                        rbSim3.Checked = true;
                    }

                    else if (rbNao3.Checked)
                    {
                        rbNao3.Checked = false;
                    }
                    fada.Elemento = cbElemento.Text;
                }
                if (nomeAntigo == "")
                {
                    fadas.Add(fada);
                    AdicionarFadaATabela(fada);
                }
                else
                {
                    int linha = fadas.FindIndex(x => x.Nome == nomeAntigo);
                    fadas[linha] = fada;
                    EditarFadaNaTabela(fada, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                }
                tabControl1.SelectedIndex = 0;
                LimparCampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditarFadaNaTabela(Fadas2 fada, int linha)
        {
            dataGridView1.Rows[linha].Cells[0].Value = fada.Nome;
            dataGridView1.Rows[linha].Cells[1].Value = fada.Nome2;
            dataGridView1.Rows[linha].Cells[2].Value = fada.Nome3;
            dataGridView1.Rows[linha].Cells[3].Value = fada.Familia;
            dataGridView1.Rows[linha].Cells[4].Value = fada.Familia2;
            dataGridView1.Rows[linha].Cells[5].Value = fada.Cor;
            dataGridView1.Rows[linha].Cells[6].Value = fada.Cor2;
            dataGridView1.Rows[linha].Cells[7].Value = fada.CorAsa;
            dataGridView1.Rows[linha].Cells[8].Value = fada.TamanhoAsa;
            dataGridView1.Rows[linha].Cells[9].Value = fada.AsaQuebrada;
            dataGridView1.Rows[linha].Cells[10].Value = fada.EhMulher;
            dataGridView1.Rows[linha].Cells[11].Value = fada.Barulho;
            dataGridView1.Rows[linha].Cells[12].Value = fada.Elemento;
        }

        private void AdicionarFadaATabela(Fadas2 fada)
        {
            dataGridView1.Rows.Add(new Object[]{
                fada.Nome, fada.Nome2, fada.Familia2, fada.Cor2, fada.Familia, fada.Cor, fada.CorAsa, fada.TamanhoAsa, fada.AsaQuebrada, fada.EhMulher, fada.Barulho, fada.Elemento
            });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNome2.Text = "";
            txtNome3.Text = "";
            txtFamilia.Text = "";
            txtFamilia2.Text = "";
            cbCor.Text = "";
            cbCor2.Text = "";
            cbCor3.Text = "";
            cbCorAsa.Text = "";
            txtTamanhoAsa.Text = "";
            rbSim1.Checked = false;
            rbSim2.Checked = false;
            rbSim3.Checked = false;
            rbSim4.Checked = false;
            cbElemento.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada");
                tabControl1.SelectedIndex = 1;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha");
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            for (int i = 0; i < fadas.Count(); i++)
            {
                Fadas2 fada = fadas[i];
                if (fada.Nome == nome)
                {
                    fadas.RemoveAt(i);
                }

                if (fada.Nome2 == nome)
                {
                    fadas2.RemoveAt(i);
                }
            }

            dataGridView1.Rows.RemoveAt(linhaSelecionada);
        }

        private void btnEditrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada");
                tabControl1.SelectedIndex = 1;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha");
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();

            foreach (Fadas2 fada in fadas)
            {
                txtNome.Text = fada.Nome;
                txtNome2.Text = fada.Nome2;
                txtNome3.Text = fada.Nome3;
                txtFamilia.Text = fada.Familia;
                txtFamilia2.Text = fada.Familia2;
                cbCor.Text = fada.Cor;
                cbCor2.Text = fada.Cor2;
                cbCorAsa.Text = fada.CorAsa;
                txtTamanhoAsa.Text = Convert.ToString(fada.AsaQuebrada);
                rbSim1.Checked = fada.EhMulher;
                rbSim2.Checked = fada.AsaQuebrada;
                rbSim3.Checked = fada.Barulho;
                cbElemento.Text = fada.Elemento;
                tabControl1.SelectedIndex = 1;
                nomeAntigo = fada.Nome;
                break;
            }
        }

        private void mtbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFamilia.Focus();
            }
        }

        private void txtFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCor.Focus();
            }
        }

        private void txtCorAsa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTamanhoAsa.Focus();
            }
        }

        private void txtTamanhoAsa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTamanhoAsa.Focus();
            }
        }

        private void txtBarulho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbElemento.Focus();
            }
        }

        private void txtElemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            try
            {
                Fadas2 fadas = new Fadas2(txtNome2.Text, txtFamilia2.Text, cbCor2.Text);
                {
                    fadas.Nome2 = txtNome2.Text;
                    fadas.Familia2 = txtFamilia2.Text;
                    fadas.Cor2 = cbCor2.Text;
                }
                if (nomeAntigo == "")
                {
                    fadas2.Add(fadas);
                }

                else
                {
                    int linha = fadas2.FindIndex(x => x.Nome2 == nomeAntigo);
                    fadas2[linha] = fadas;
                    EditarFadaNaTabela(fadas, linha);
                    MessageBox.Show("Alterado com sucesso");
                    nomeAntigo = string.Empty;
                }
                tabControl1.SelectedIndex = 0;
                LimparCampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}