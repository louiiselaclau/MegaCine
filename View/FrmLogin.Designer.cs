
namespace View
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
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.btnusuario = new System.Windows.Forms.Label();
            this.btnsenha = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AccessibleName = "Login";
            this.Usuario.Location = new System.Drawing.Point(181, 241);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(100, 20);
            this.Usuario.TabIndex = 0;
            // 
            // Senha
            // 
            this.Senha.AccessibleName = "Senha";
            this.Senha.Location = new System.Drawing.Point(181, 286);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(100, 20);
            this.Senha.TabIndex = 1;
            this.Senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnusuario
            // 
            this.btnusuario.AutoSize = true;
            this.btnusuario.Location = new System.Drawing.Point(120, 244);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(46, 13);
            this.btnusuario.TabIndex = 2;
            this.btnusuario.Text = "Usuario:";
            this.btnusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsenha
            // 
            this.btnsenha.AutoSize = true;
            this.btnsenha.Location = new System.Drawing.Point(125, 289);
            this.btnsenha.Name = "btnsenha";
            this.btnsenha.Size = new System.Drawing.Size(41, 13);
            this.btnsenha.TabIndex = 3;
            this.btnsenha.Text = "Senha:";
            // 
            // Login
            // 
            this.Login.AccessibleName = "Acessar";
            this.Login.Location = new System.Drawing.Point(193, 324);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(168, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha ou usuario invalida!";
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.megacineee;
            this.pictureBox1.Location = new System.Drawing.Point(58, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 180);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.btnsenha);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Name = "FrmLogin";
            this.Text = "MegaCine Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Label btnusuario;
        private System.Windows.Forms.Label btnsenha;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}