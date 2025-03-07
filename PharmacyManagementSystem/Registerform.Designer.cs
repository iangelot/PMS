
namespace PharmacyManagementSystem
{
    partial class Registerform
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
            this.register_btn = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.login_showpass = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.register_loginbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_showpass = new System.Windows.Forms.CheckBox();
            this.register_confirmpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(349, 364);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(333, 35);
            this.register_btn.TabIndex = 19;
            this.register_btn.Text = "Sign Up";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(353, 250);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(333, 26);
            this.register_password.TabIndex = 18;
            this.register_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(353, 189);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(333, 26);
            this.register_username.TabIndex = 16;
            this.register_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 479);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "PHARMACY MANAGEMENT SYSTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "KEDY";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(678, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 25;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // login_showpass
            // 
            this.login_showpass.AutoSize = true;
            this.login_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showpass.Location = new System.Drawing.Point(216, 296);
            this.login_showpass.Name = "login_showpass";
            this.login_showpass.Size = new System.Drawing.Size(120, 20);
            this.login_showpass.TabIndex = 24;
            this.login_showpass.Text = "show password";
            this.login_showpass.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Already have an account ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "REGISTER ACCOUNT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // register_loginbtn
            // 
            this.register_loginbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.register_loginbtn.FlatAppearance.BorderSize = 0;
            this.register_loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.register_loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.register_loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginbtn.ForeColor = System.Drawing.Color.White;
            this.register_loginbtn.Location = new System.Drawing.Point(349, 435);
            this.register_loginbtn.Name = "register_loginbtn";
            this.register_loginbtn.Size = new System.Drawing.Size(333, 35);
            this.register_loginbtn.TabIndex = 21;
            this.register_loginbtn.Text = "Login";
            this.register_loginbtn.UseVisualStyleBackColor = false;
            this.register_loginbtn.Click += new System.EventHandler(this.register_loginbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmacyManagementSystem.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(454, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 134);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // register_showpass
            // 
            this.register_showpass.AutoSize = true;
            this.register_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showpass.Location = new System.Drawing.Point(353, 338);
            this.register_showpass.Name = "register_showpass";
            this.register_showpass.Size = new System.Drawing.Size(120, 20);
            this.register_showpass.TabIndex = 26;
            this.register_showpass.Text = "show password";
            this.register_showpass.UseVisualStyleBackColor = true;
            this.register_showpass.CheckedChanged += new System.EventHandler(this.register_showpass_CheckedChanged);
            // 
            // register_confirmpassword
            // 
            this.register_confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_confirmpassword.Location = new System.Drawing.Point(353, 306);
            this.register_confirmpassword.Name = "register_confirmpassword";
            this.register_confirmpassword.PasswordChar = '*';
            this.register_confirmpassword.Size = new System.Drawing.Size(333, 26);
            this.register_confirmpassword.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Confirm Password";
            // 
            // Registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 479);
            this.Controls.Add(this.register_confirmpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_showpass);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.login_showpass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register_loginbtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registerform";
            this.Load += new System.EventHandler(this.Registerform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.CheckBox login_showpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button register_loginbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox register_showpass;
        private System.Windows.Forms.TextBox register_confirmpassword;
        private System.Windows.Forms.Label label1;
    }
}