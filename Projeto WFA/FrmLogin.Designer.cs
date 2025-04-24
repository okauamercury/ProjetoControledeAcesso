namespace Projeto_WFA
{
    partial class FrmLogin
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
            panel1 = new Panel();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(161, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 255);
            panel1.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(88, 182);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(74, 143);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 101);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 125);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 83);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.World);
            label1.Location = new Point(63, 12);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 0;
            label1.Text = "Login de Usuário";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtNome;
    }
}