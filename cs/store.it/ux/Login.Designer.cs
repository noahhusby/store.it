namespace store.it.ux
{
    partial class Login
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
            this.overpanel = new System.Windows.Forms.Panel();
            this.input_password = new store.it.ux.cust.TextBox();
            this.input_email = new store.it.ux.cust.TextBox();
            this.ic = new System.Windows.Forms.Label();
            this.button_login = new MaterialSkin.Controls.MaterialFlatButton();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.overpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // overpanel
            // 
            this.overpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.overpanel.Controls.Add(this.input_password);
            this.overpanel.Controls.Add(this.input_email);
            this.overpanel.Controls.Add(this.ic);
            this.overpanel.Controls.Add(this.button_login);
            this.overpanel.Controls.Add(this.title);
            this.overpanel.Controls.Add(this.pictureBox1);
            this.overpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overpanel.Location = new System.Drawing.Point(0, 0);
            this.overpanel.Name = "overpanel";
            this.overpanel.Size = new System.Drawing.Size(474, 823);
            this.overpanel.TabIndex = 12;
            this.overpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // input_password
            // 
            this.input_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_password.BoxText = null;
            this.input_password.Location = new System.Drawing.Point(63, 448);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(361, 50);
            this.input_password.TabIndex = 12;
            // 
            // input_email
            // 
            this.input_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_email.BoxText = null;
            this.input_email.Location = new System.Drawing.Point(63, 356);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(361, 50);
            this.input_email.TabIndex = 11;
            // 
            // ic
            // 
            this.ic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ic.AutoSize = true;
            this.ic.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.ic.ForeColor = System.Drawing.Color.Red;
            this.ic.Location = new System.Drawing.Point(44, 617);
            this.ic.Name = "ic";
            this.ic.Size = new System.Drawing.Size(352, 29);
            this.ic.TabIndex = 10;
            this.ic.Text = "Email or password was incorrect";
            this.ic.Visible = false;
            // 
            // button_login
            // 
            this.button_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_login.AutoSize = true;
            this.button_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_login.Depth = 0;
            this.button_login.Location = new System.Drawing.Point(191, 672);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_login.Name = "button_login";
            this.button_login.Primary = false;
            this.button_login.Size = new System.Drawing.Size(96, 36);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "Login";
            this.button_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_login.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(170, 220);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(135, 46);
            this.title.TabIndex = 2;
            this.title.Text = "store.it";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::store.it.Properties.Resources.ic_white;
            this.pictureBox1.Location = new System.Drawing.Point(187, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 823);
            this.Controls.Add(this.overpanel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.overpanel.ResumeLayout(false);
            this.overpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel overpanel;
        private System.Windows.Forms.Label ic;
        private MaterialSkin.Controls.MaterialFlatButton button_login;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private cust.TextBox input_password;
        private cust.TextBox input_email;
    }
}