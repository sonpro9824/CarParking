namespace CarParking
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_pass_fake = new System.Windows.Forms.TextBox();
            this.button_sign = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_sign = new System.Windows.Forms.Panel();
            this.button_signS = new System.Windows.Forms.Button();
            this.text_passS2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_passS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_userS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_mailS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_sign.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(376, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(319, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 98);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(452, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.text_pass_fake);
            this.panel1.Controls.Add(this.button_sign);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.text_pass);
            this.panel1.Controls.Add(this.text_user);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(247, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 214);
            this.panel1.TabIndex = 3;
            // 
            // text_pass_fake
            // 
            this.text_pass_fake.Location = new System.Drawing.Point(116, 74);
            this.text_pass_fake.Name = "text_pass_fake";
            this.text_pass_fake.Size = new System.Drawing.Size(192, 22);
            this.text_pass_fake.TabIndex = 6;
            this.text_pass_fake.TextChanged += new System.EventHandler(this.text_pass_fake_TextChanged);
            // 
            // button_sign
            // 
            this.button_sign.BackColor = System.Drawing.Color.Teal;
            this.button_sign.FlatAppearance.BorderSize = 0;
            this.button_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sign.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_sign.Location = new System.Drawing.Point(52, 132);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(87, 37);
            this.button_sign.TabIndex = 5;
            this.button_sign.Text = "Sign up";
            this.button_sign.UseVisualStyleBackColor = false;
            this.button_sign.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Red;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_login.Location = new System.Drawing.Point(192, 132);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(87, 37);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(116, 74);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(192, 22);
            this.text_pass.TabIndex = 3;
            this.text_pass.TextChanged += new System.EventHandler(this.text_pass_TextChanged);
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(116, 30);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(192, 22);
            this.text_user.TabIndex = 2;
            this.text_user.TextChanged += new System.EventHandler(this.text_user_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(21, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username: ";
            // 
            // panel_sign
            // 
            this.panel_sign.BackColor = System.Drawing.Color.Transparent;
            this.panel_sign.Controls.Add(this.button_signS);
            this.panel_sign.Controls.Add(this.text_passS2);
            this.panel_sign.Controls.Add(this.label9);
            this.panel_sign.Controls.Add(this.text_passS);
            this.panel_sign.Controls.Add(this.label8);
            this.panel_sign.Controls.Add(this.text_userS);
            this.panel_sign.Controls.Add(this.label7);
            this.panel_sign.Controls.Add(this.text_mailS);
            this.panel_sign.Controls.Add(this.label6);
            this.panel_sign.Location = new System.Drawing.Point(225, 189);
            this.panel_sign.Name = "panel_sign";
            this.panel_sign.Size = new System.Drawing.Size(359, 290);
            this.panel_sign.TabIndex = 4;
            // 
            // button_signS
            // 
            this.button_signS.BackColor = System.Drawing.Color.Teal;
            this.button_signS.FlatAppearance.BorderSize = 0;
            this.button_signS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signS.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_signS.Location = new System.Drawing.Point(243, 206);
            this.button_signS.Name = "button_signS";
            this.button_signS.Size = new System.Drawing.Size(87, 37);
            this.button_signS.TabIndex = 11;
            this.button_signS.Text = "Sign up";
            this.button_signS.UseVisualStyleBackColor = false;
            this.button_signS.Click += new System.EventHandler(this.button_signS_Click);
            // 
            // text_passS2
            // 
            this.text_passS2.Location = new System.Drawing.Point(138, 147);
            this.text_passS2.Name = "text_passS2";
            this.text_passS2.PasswordChar = '*';
            this.text_passS2.Size = new System.Drawing.Size(192, 22);
            this.text_passS2.TabIndex = 10;
            this.text_passS2.TextChanged += new System.EventHandler(this.text_passS2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(21, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "ComfirmPass: ";
            // 
            // text_passS
            // 
            this.text_passS.Location = new System.Drawing.Point(138, 102);
            this.text_passS.Name = "text_passS";
            this.text_passS.PasswordChar = '*';
            this.text_passS.Size = new System.Drawing.Size(192, 22);
            this.text_passS.TabIndex = 8;
            this.text_passS.TextChanged += new System.EventHandler(this.text_passS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(21, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password: ";
            // 
            // text_userS
            // 
            this.text_userS.Location = new System.Drawing.Point(138, 57);
            this.text_userS.Name = "text_userS";
            this.text_userS.Size = new System.Drawing.Size(192, 22);
            this.text_userS.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(21, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Username: ";
            // 
            // text_mailS
            // 
            this.text_mailS.Location = new System.Drawing.Point(138, 19);
            this.text_mailS.Name = "text_mailS";
            this.text_mailS.Size = new System.Drawing.Size(192, 22);
            this.text_mailS.TabIndex = 4;
            this.text_mailS.TextChanged += new System.EventHandler(this.text_mailS_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(21, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email: ";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarParking.Properties.Resources.parking_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_sign);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_sign.ResumeLayout(false);
            this.panel_sign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_sign;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Panel panel_sign;
        private System.Windows.Forms.Button button_signS;
        private System.Windows.Forms.TextBox text_passS2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_passS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_userS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_mailS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_pass_fake;
    }
}

