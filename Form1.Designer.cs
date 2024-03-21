namespace login
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.linkCreate = new System.Windows.Forms.LinkLabel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureMini = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMini)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 359);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Sienna;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(251, 107);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(311, 18);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "USER";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Sienna;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(251, 172);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(311, 18);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "PASSWORD";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(248, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "_________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(248, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "_________________________________________________";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Peru;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(251, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(298, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkPass
            // 
            this.linkPass.ActiveLinkColor = System.Drawing.Color.Chocolate;
            this.linkPass.AutoSize = true;
            this.linkPass.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPass.ForeColor = System.Drawing.Color.Black;
            this.linkPass.LinkColor = System.Drawing.Color.Black;
            this.linkPass.Location = new System.Drawing.Point(437, 321);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(112, 12);
            this.linkPass.TabIndex = 0;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "forgot password";
            // 
            // linkCreate
            // 
            this.linkCreate.ActiveLinkColor = System.Drawing.Color.Chocolate;
            this.linkCreate.AutoSize = true;
            this.linkCreate.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCreate.ForeColor = System.Drawing.Color.Black;
            this.linkCreate.LinkColor = System.Drawing.Color.Black;
            this.linkCreate.Location = new System.Drawing.Point(248, 321);
            this.linkCreate.Name = "linkCreate";
            this.linkCreate.Size = new System.Drawing.Size(143, 12);
            this.linkCreate.TabIndex = 1;
            this.linkCreate.TabStop = true;
            this.linkCreate.Text = "Don\'t have an account";
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(583, 12);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(17, 18);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 9;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // pictureMini
            // 
            this.pictureMini.Image = ((System.Drawing.Image)(resources.GetObject("pictureMini.Image")));
            this.pictureMini.Location = new System.Drawing.Point(560, 12);
            this.pictureMini.Name = "pictureMini";
            this.pictureMini.Size = new System.Drawing.Size(17, 18);
            this.pictureMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMini.TabIndex = 10;
            this.pictureMini.TabStop = false;
            this.pictureMini.Click += new System.EventHandler(this.pictureMini_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(612, 359);
            this.Controls.Add(this.pictureMini);
            this.Controls.Add(this.pictureClose);
            this.Controls.Add(this.linkCreate);
            this.Controls.Add(this.linkPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkPass;
        private System.Windows.Forms.LinkLabel linkCreate;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureMini;
    }
}

