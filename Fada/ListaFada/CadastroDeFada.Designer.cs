namespace ListaFada
{
    partial class CadastroDeFada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.btnEditrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamiliaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorAsaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamanhoAsaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsaQuebradaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FazBarulhoColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementoColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.mtbNome = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBarulho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAsaQuebrada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTamanhoAsa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorAsa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLista);
            this.tabControl1.Controls.Add(this.tabPageCadastro);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 211);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.btnEditrar);
            this.tabPageLista.Controls.Add(this.btnApagar);
            this.tabPageLista.Controls.Add(this.btnAdicionar);
            this.tabPageLista.Controls.Add(this.dataGridView1);
            this.tabPageLista.Location = new System.Drawing.Point(4, 22);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(966, 185);
            this.tabPageLista.TabIndex = 0;
            this.tabPageLista.Text = "Lista";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnEditrar
            // 
            this.btnEditrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditrar.Location = new System.Drawing.Point(712, 7);
            this.btnEditrar.Name = "btnEditrar";
            this.btnEditrar.Size = new System.Drawing.Size(68, 29);
            this.btnEditrar.TabIndex = 3;
            this.btnEditrar.Text = "Editar";
            this.btnEditrar.UseVisualStyleBackColor = true;
            this.btnEditrar.Click += new System.EventHandler(this.btnEditrar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(786, 6);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(76, 30);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(868, 6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(92, 30);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeColumn1,
            this.FamiliaColumn1,
            this.CorColumn1,
            this.CorAsaColumn1,
            this.TamanhoAsaColumn1,
            this.AsaQuebradaColumn1,
            this.SexoColumn1,
            this.FazBarulhoColumn1,
            this.ElementoColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(8, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(952, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // NomeColumn1
            // 
            this.NomeColumn1.HeaderText = "Nome";
            this.NomeColumn1.Name = "NomeColumn1";
            this.NomeColumn1.ReadOnly = true;
            // 
            // FamiliaColumn1
            // 
            this.FamiliaColumn1.HeaderText = "Família";
            this.FamiliaColumn1.Name = "FamiliaColumn1";
            this.FamiliaColumn1.ReadOnly = true;
            // 
            // CorColumn1
            // 
            this.CorColumn1.HeaderText = "Cor";
            this.CorColumn1.Name = "CorColumn1";
            this.CorColumn1.ReadOnly = true;
            // 
            // CorAsaColumn1
            // 
            this.CorAsaColumn1.HeaderText = "Cor da Asa";
            this.CorAsaColumn1.Name = "CorAsaColumn1";
            this.CorAsaColumn1.ReadOnly = true;
            // 
            // TamanhoAsaColumn1
            // 
            this.TamanhoAsaColumn1.HeaderText = "Tamanho da Asa";
            this.TamanhoAsaColumn1.Name = "TamanhoAsaColumn1";
            this.TamanhoAsaColumn1.ReadOnly = true;
            // 
            // AsaQuebradaColumn1
            // 
            this.AsaQuebradaColumn1.HeaderText = "Asa Quebrada";
            this.AsaQuebradaColumn1.Name = "AsaQuebradaColumn1";
            this.AsaQuebradaColumn1.ReadOnly = true;
            // 
            // SexoColumn1
            // 
            this.SexoColumn1.HeaderText = "Sexo";
            this.SexoColumn1.Name = "SexoColumn1";
            this.SexoColumn1.ReadOnly = true;
            // 
            // FazBarulhoColumn1
            // 
            this.FazBarulhoColumn1.HeaderText = "Faz Barulho";
            this.FazBarulhoColumn1.Name = "FazBarulhoColumn1";
            this.FazBarulhoColumn1.ReadOnly = true;
            // 
            // ElementoColumn1
            // 
            this.ElementoColumn1.HeaderText = "Elemento";
            this.ElementoColumn1.Name = "ElementoColumn1";
            this.ElementoColumn1.ReadOnly = true;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.mtbNome);
            this.tabPageCadastro.Controls.Add(this.btnCancelar);
            this.tabPageCadastro.Controls.Add(this.btnSalvar);
            this.tabPageCadastro.Controls.Add(this.txtElemento);
            this.tabPageCadastro.Controls.Add(this.label9);
            this.tabPageCadastro.Controls.Add(this.txtBarulho);
            this.tabPageCadastro.Controls.Add(this.label8);
            this.tabPageCadastro.Controls.Add(this.txtSexo);
            this.tabPageCadastro.Controls.Add(this.label7);
            this.tabPageCadastro.Controls.Add(this.txtAsaQuebrada);
            this.tabPageCadastro.Controls.Add(this.label6);
            this.tabPageCadastro.Controls.Add(this.txtTamanhoAsa);
            this.tabPageCadastro.Controls.Add(this.label5);
            this.tabPageCadastro.Controls.Add(this.txtCorAsa);
            this.tabPageCadastro.Controls.Add(this.label4);
            this.tabPageCadastro.Controls.Add(this.txtCor);
            this.tabPageCadastro.Controls.Add(this.label3);
            this.tabPageCadastro.Controls.Add(this.txtFamilia);
            this.tabPageCadastro.Controls.Add(this.label2);
            this.tabPageCadastro.Controls.Add(this.label1);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(966, 185);
            this.tabPageCadastro.TabIndex = 1;
            this.tabPageCadastro.Text = "Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // mtbNome
            // 
            this.mtbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNome.Location = new System.Drawing.Point(156, 15);
            this.mtbNome.Name = "mtbNome";
            this.mtbNome.Size = new System.Drawing.Size(148, 26);
            this.mtbNome.TabIndex = 1;
            this.mtbNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbNome_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(673, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(273, 72);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(673, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(273, 72);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento.Location = new System.Drawing.Point(502, 111);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(148, 26);
            this.txtElemento.TabIndex = 9;
            this.txtElemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtElemento_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Elemento";
            // 
            // txtBarulho
            // 
            this.txtBarulho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarulho.Location = new System.Drawing.Point(502, 79);
            this.txtBarulho.Name = "txtBarulho";
            this.txtBarulho.Size = new System.Drawing.Size(148, 26);
            this.txtBarulho.TabIndex = 8;
            this.txtBarulho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarulho_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Faz Barulho";
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(502, 47);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(148, 26);
            this.txtSexo.TabIndex = 7;
            this.txtSexo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSexo_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sexo";
            // 
            // txtAsaQuebrada
            // 
            this.txtAsaQuebrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsaQuebrada.Location = new System.Drawing.Point(502, 15);
            this.txtAsaQuebrada.Name = "txtAsaQuebrada";
            this.txtAsaQuebrada.Size = new System.Drawing.Size(148, 26);
            this.txtAsaQuebrada.TabIndex = 6;
            this.txtAsaQuebrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAsaQuebrada_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Asa Qubrada";
            // 
            // txtTamanhoAsa
            // 
            this.txtTamanhoAsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanhoAsa.Location = new System.Drawing.Point(156, 142);
            this.txtTamanhoAsa.Name = "txtTamanhoAsa";
            this.txtTamanhoAsa.Size = new System.Drawing.Size(148, 26);
            this.txtTamanhoAsa.TabIndex = 5;
            this.txtTamanhoAsa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTamanhoAsa_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tamanho da Asa";
            // 
            // txtCorAsa
            // 
            this.txtCorAsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorAsa.Location = new System.Drawing.Point(156, 111);
            this.txtCorAsa.Name = "txtCorAsa";
            this.txtCorAsa.Size = new System.Drawing.Size(148, 26);
            this.txtCorAsa.TabIndex = 4;
            this.txtCorAsa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCorAsa_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cor da Asa";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(156, 79);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(148, 26);
            this.txtCor.TabIndex = 3;
            this.txtCor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCor_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cor";
            // 
            // txtFamilia
            // 
            this.txtFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilia.Location = new System.Drawing.Point(156, 47);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(148, 26);
            this.txtFamilia.TabIndex = 2;
            this.txtFamilia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFamilia_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Família";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // CadastroDeFada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 223);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadastroDeFada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fada";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.Button btnEditrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamiliaColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorAsaColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamanhoAsaColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsaQuebradaColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FazBarulhoColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementoColumn1;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBarulho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAsaQuebrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamanhoAsa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorAsa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtbNome;

    }
}

