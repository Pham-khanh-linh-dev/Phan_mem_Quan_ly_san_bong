namespace WinFormsApp3
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            lb_reg = new Label();
            lb_regHi = new Label();
            lb_username = new Label();
            tb_username = new TextBox();
            bt_login = new Button();
            lb_pwd = new Label();
            tb_pwd = new TextBox();
            checkBox1 = new CheckBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 75, 24);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 451);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lb_reg);
            panel2.Controls.Add(lb_regHi);
            panel2.Controls.Add(lb_username);
            panel2.Controls.Add(tb_username);
            panel2.Controls.Add(bt_login);
            panel2.Controls.Add(lb_pwd);
            panel2.Controls.Add(tb_pwd);
            panel2.Location = new Point(536, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 451);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(15, 37);
            label1.Name = "label1";
            label1.Size = new Size(211, 50);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // lb_reg
            // 
            lb_reg.AutoSize = true;
            lb_reg.BackColor = Color.Transparent;
            lb_reg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_reg.ForeColor = SystemColors.ControlLight;
            lb_reg.Location = new Point(24, 316);
            lb_reg.Name = "lb_reg";
            lb_reg.Size = new Size(139, 20);
            lb_reg.TabIndex = 5;
            lb_reg.Text = "Chưa có tài khoản?";
            lb_reg.Click += lb_reg_Click;
            // 
            // lb_regHi
            // 
            lb_regHi.AutoSize = true;
            lb_regHi.BackColor = Color.Transparent;
            lb_regHi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_regHi.ForeColor = SystemColors.HotTrack;
            lb_regHi.Location = new Point(157, 316);
            lb_regHi.Name = "lb_regHi";
            lb_regHi.Size = new Size(73, 20);
            lb_regHi.TabIndex = 6;
            lb_regHi.Text = "Bấm đây!";
            lb_regHi.Click += lb_regHi_Click;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.BackColor = Color.Transparent;
            lb_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_username.ForeColor = SystemColors.ControlLight;
            lb_username.Location = new Point(15, 101);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(148, 28);
            lb_username.TabIndex = 2;
            lb_username.Text = "Tên đăng nhập";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(15, 133);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(215, 27);
            tb_username.TabIndex = 0;
            // 
            // bt_login
            // 
            bt_login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_login.Location = new Point(132, 268);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(94, 29);
            bt_login.TabIndex = 4;
            bt_login.Text = "Đăng nhập";
            bt_login.UseVisualStyleBackColor = true;
            bt_login.Click += bt_login_Click;
            // 
            // lb_pwd
            // 
            lb_pwd.AutoSize = true;
            lb_pwd.BackColor = Color.Transparent;
            lb_pwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pwd.ForeColor = SystemColors.ControlLight;
            lb_pwd.Location = new Point(15, 173);
            lb_pwd.Name = "lb_pwd";
            lb_pwd.Size = new Size(98, 28);
            lb_pwd.TabIndex = 3;
            lb_pwd.Text = "Mật khẩu";
            // 
            // tb_pwd
            // 
            tb_pwd.Location = new Point(15, 205);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PasswordChar = '*';
            tb_pwd.Size = new Size(215, 27);
            tb_pwd.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(103, 238);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel3);
            Name = "LoginPage";
            Text = "Đăng nhập Hoàng Kim";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button bt_login;
        private Label lb_pwd;
        private Label lb_username;
        private TextBox tb_username;
        private TextBox tb_pwd;
        private Label lb_reg;
        private Label label1;
        private Label lb_regHi;
        private Panel panel2;
        private CheckBox checkBox1;
    }
}