namespace Projeto_WFA
{
    partial class CadastrodeUsuarios
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
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
            btnInserir = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
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
            panel1.Controls.Add(btnInserir);
            panel1.Location = new Point(177, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 306);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nemo;
            pictureBox1.Location = new Point(281, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 97);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.World);
            label1.Location = new Point(132, 17);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 11;
            label1.Text = "Cadastro de Usuários";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(281, 72);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(26, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(74, 23);
            textBox3.TabIndex = 9;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(74, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Funcionário", "Visitante" });
            comboBox1.Location = new Point(78, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(105, 23);
            comboBox1.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(258, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(17, 15);
            txtId.TabIndex = 5;
            txtId.Text = "Id";
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Location = new Point(48, 195);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(39, 15);
            txtSenha.TabIndex = 4;
            txtSenha.Text = "Senha";
            // 
            // txtTipodeUsuário
            // 
            txtTipodeUsuário.AutoSize = true;
            txtTipodeUsuário.Location = new Point(47, 148);
            txtTipodeUsuário.Name = "txtTipodeUsuário";
            txtTipodeUsuário.Size = new Size(90, 15);
            txtTipodeUsuário.TabIndex = 3;
            txtTipodeUsuário.Text = "Tipo de Usuário";
            // 
            // txtCpf
            // 
            txtCpf.AutoSize = true;
            txtCpf.Location = new Point(48, 104);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(26, 15);
            txtCpf.TabIndex = 2;
            txtCpf.Text = "Cpf";
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(47, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(40, 15);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(177, 256);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // CadastrodeUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CadastrodeUsuarios";
            Text = "Form1";
            Load += CadastrodeUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInserir;
        private Label txtSenha;
        private Label txtNome;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label txtId;
        private Label txtTipodeUsuário;
        private Label txtCpf;
    }
}
