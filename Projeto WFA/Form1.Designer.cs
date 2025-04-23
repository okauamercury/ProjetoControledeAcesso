namespace Projeto_WFA
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            txtId = new Label();
            txtSenha = new Label();
            txtTipodeUsuário = new Label();
            txtCpf = new Label();
            txtNome = new Label();
            btnEntrar = new Button();
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            entrarToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            registroDeAcessoToolStripMenuItem = new ToolStripMenuItem();
            realizarRegistroToolStripMenuItem = new ToolStripMenuItem();
            consultaDeAcessosToolStripMenuItem = new ToolStripMenuItem();
            consulteOsAcessosToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtTipodeUsuário);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnEntrar);
            panel1.Location = new Point(176, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 306);
            panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(26, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(48, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(74, 23);
            textBox3.TabIndex = 9;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(74, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Funcionário", "Visitante" });
            comboBox1.Location = new Point(47, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(105, 23);
            comboBox1.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(135, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(17, 15);
            txtId.TabIndex = 5;
            txtId.Text = "Id";
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Location = new Point(33, 195);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(39, 15);
            txtSenha.TabIndex = 4;
            txtSenha.Text = "Senha";
            // 
            // txtTipodeUsuário
            // 
            txtTipodeUsuário.AutoSize = true;
            txtTipodeUsuário.Location = new Point(32, 151);
            txtTipodeUsuário.Name = "txtTipodeUsuário";
            txtTipodeUsuário.Size = new Size(90, 15);
            txtTipodeUsuário.TabIndex = 3;
            txtTipodeUsuário.Text = "Tipo de Usuário";
            // 
            // txtCpf
            // 
            txtCpf.AutoSize = true;
            txtCpf.Location = new Point(33, 104);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(26, 15);
            txtCpf.TabIndex = 2;
            txtCpf.Text = "Cpf";
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(33, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(40, 15);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(96, 244);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastroDeUsuáriosToolStripMenuItem, registroDeAcessoToolStripMenuItem, consultaDeAcessosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entrarToolStripMenuItem });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "L&ogin";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // entrarToolStripMenuItem
            // 
            entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            entrarToolStripMenuItem.Size = new Size(105, 22);
            entrarToolStripMenuItem.Text = "E&ntrar";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            cadastroDeUsuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarUsuariosToolStripMenuItem });
            cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            cadastroDeUsuáriosToolStripMenuItem.Size = new Size(130, 20);
            cadastroDeUsuáriosToolStripMenuItem.Text = "Cad&astro de Usuários";
            // 
            // cadastrarUsuariosToolStripMenuItem
            // 
            cadastrarUsuariosToolStripMenuItem.Name = "cadastrarUsuariosToolStripMenuItem";
            cadastrarUsuariosToolStripMenuItem.Size = new Size(172, 22);
            cadastrarUsuariosToolStripMenuItem.Text = "Cad&astrar Usuarios";
            // 
            // registroDeAcessoToolStripMenuItem
            // 
            registroDeAcessoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { realizarRegistroToolStripMenuItem });
            registroDeAcessoToolStripMenuItem.Name = "registroDeAcessoToolStripMenuItem";
            registroDeAcessoToolStripMenuItem.Size = new Size(118, 20);
            registroDeAcessoToolStripMenuItem.Text = "Reg&istro de Acesso";
            // 
            // realizarRegistroToolStripMenuItem
            // 
            realizarRegistroToolStripMenuItem.Name = "realizarRegistroToolStripMenuItem";
            realizarRegistroToolStripMenuItem.Size = new Size(160, 22);
            realizarRegistroToolStripMenuItem.Text = "Re&alizar Registro";
            // 
            // consultaDeAcessosToolStripMenuItem
            // 
            consultaDeAcessosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consulteOsAcessosToolStripMenuItem });
            consultaDeAcessosToolStripMenuItem.Name = "consultaDeAcessosToolStripMenuItem";
            consultaDeAcessosToolStripMenuItem.Size = new Size(127, 20);
            consultaDeAcessosToolStripMenuItem.Text = "Consu&lta de Acessos";
            // 
            // consulteOsAcessosToolStripMenuItem
            // 
            consulteOsAcessosToolStripMenuItem.Name = "consulteOsAcessosToolStripMenuItem";
            consulteOsAcessosToolStripMenuItem.Size = new Size(181, 22);
            consulteOsAcessosToolStripMenuItem.Text = "Consul&te os Acessos";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem entrarToolStripMenuItem;
        private ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem registroDeAcessoToolStripMenuItem;
        private ToolStripMenuItem consultaDeAcessosToolStripMenuItem;
        private Button btnEntrar;
        private ToolStripMenuItem realizarRegistroToolStripMenuItem;
        private ToolStripMenuItem consulteOsAcessosToolStripMenuItem;
        private Label txtId;
        private Label txtSenha;
        private Label txtTipodeUsuário;
        private Label txtCpf;
        private Label txtNome;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}
