namespace CNPM
{
    partial class New_Login_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Login_KH));
            panel3 = new Panel();
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_username = new TextBox();
            button1 = new Button();
            label6 = new Label();
            tb_pwd = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 75, 24);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 409);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tb_username);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tb_pwd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(567, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 409);
            panel1.TabIndex = 8;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.ControlLightLight;
            checkBox2.Location = new Point(103, 238);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 24);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Hiện mật khẩu";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(15, 37);
            label2.Name = "label2";
            label2.Size = new Size(211, 50);
            label2.TabIndex = 0;
            label2.Text = "Đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(24, 316);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 5;
            label3.Text = "Chưa có tài khoản?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(157, 316);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "Bấm đây!";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(15, 101);
            label5.Name = "label5";
            label5.Size = new Size(148, 28);
            label5.TabIndex = 2;
            label5.Text = "Tên đăng nhập";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(15, 133);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(215, 27);
            tb_username.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(132, 268);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(15, 173);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 3;
            label6.Text = "Mật khẩu";
            // 
            // tb_pwd
            // 
            tb_pwd.Location = new Point(15, 205);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PasswordChar = '*';
            tb_pwd.Size = new Size(215, 27);
            tb_pwd.TabIndex = 1;
            // 
            // New_Login_KH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(panel3);
            Name = "New_Login_KH";
            Text = "Đăng nhập";
            Load += New_Login_KH_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private CheckBox checkBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_username;
        private Button button1;
        private Label label6;
        private TextBox tb_pwd;
    }
}