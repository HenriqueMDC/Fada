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
                Fadas2 fada = new Fadas2(mtbNome.Text, txtFamilia.Text, txtCor.Text, txtSexo.Text);
                {
                    fada.Nome = mtbNome.Text;
                    fada.Familia = txtFamilia.Text;
                    fada.Cor = txtCor.Text;
                    fada.CorAsa = txtCorAsa.Text;
                    fada.TamanhoAsa = txtTamanhoAsa.Text;
                    fada.AsaQuebrada = txtAsaQuebrada.Text;
                    fada.Sexo = txtSexo.Text;
                    fada.Barulho = txtBarulho.Text;
                    fada.Elemento = txtElemento.Text;
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
            dataGridView1.Rows[linha].Cells[1].Value = fada.Familia;
            dataGridView1.Rows[linha].Cells[2].Value = fada.Cor;
            dataGridView1.Rows[linha].Cells[3].Value = fada.CorAsa;
            dataGridView1.Rows[linha].Cells[4].Value = fada.TamanhoAsa;
            dataGridView1.Rows[linha].Cells[5].Value = fada.AsaQuebrada;
            dataGridView1.Rows[linha].Cells[6].Value = fada.Sexo;
            dataGridView1.Rows[linha].Cells[7].Value = fada.Barulho;
            dataGridView1.Rows[linha].Cells[8].Value = fada.Elemento;
        }

        private void AdicionarFadaATabela(Fadas2 fada)
        {
            dataGridView1.Rows.Add(new Object[]{
                fada.Nome, fada.Familia, fada.Cor, fada.CorAsa, fada.TamanhoAsa, fada.AsaQuebrada, fada.Sexo, fada.Barulho, fada.Elemento
            });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            mtbNome.Text = "";
            txtFamilia.Text = "";
            txtCor.Text = "";
            txtCorAsa.Text = "";
            txtTamanhoAsa.Text = "";
            txtAsaQuebrada.Text = "";
            txtSexo.Text = "";
            txtBarulho.Text = "";
            txtElemento.Text = "";
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
                mtbNome.Text = fada.Nome;
                txtFamilia.Text = fada.Familia;
                txtCor.Text = fada.Cor;
                txtCorAsa.Text = fada.CorAsa;
                txtTamanhoAsa.Text = Convert.ToString(fada.TamanhoAsa);
                txtAsaQuebrada.Text = fada.AsaQuebrada;
                txtSexo.Text = fada.Sexo;
                txtBarulho.Text = fada.Barulho;
                txtElemento.Text = fada.Elemento;
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
                txtCor.Focus();
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
                txtAsaQuebrada.Focus();
            }
        }

        private void txtAsaQuebrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSexo.Focus();
            }
        }

        private void txtSexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBarulho.Focus();
            }
        }

        private void txtBarulho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtElemento.Focus();
            }
        }

        private void txtElemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void txtCor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCorAsa.Focus();
            }
        }

    }
}
