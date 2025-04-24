namespace Projeto_WFA
{
    partial class ConsultaAcesso
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
            dgvConsultar = new DataGridView();
            clnNome = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnTipoOperação = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultar
            // 
            dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultar.Columns.AddRange(new DataGridViewColumn[] { clnNome, clnData, clnTipoOperação });
            dgvConsultar.Location = new Point(238, 155);
            dgvConsultar.Name = "dgvConsultar";
            dgvConsultar.RowHeadersVisible = false;
            dgvConsultar.Size = new Size(304, 150);
            dgvConsultar.TabIndex = 0;
            dgvConsultar.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            // 
            // clnData
            // 
            clnData.HeaderText = "Data";
            clnData.Name = "clnData";
            // 
            // clnTipoOperação
            // 
            clnTipoOperação.HeaderText = "Tipo Operação";
            clnTipoOperação.Name = "clnTipoOperação";
            // 
            // ConsultaAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultar);
            Name = "ConsultaAcesso";
            Text = "ConsultaAcesso";
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultar;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnTipoOperação;
    }
}