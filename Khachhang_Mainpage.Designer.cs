namespace CNPM
{
    partial class Khachhang_Mainpage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang_Mainpage));
            pn_main = new Panel();
            dgv_calendar_main = new DGV();
            pn_control = new Panel();
            ibt_dangxuat = new FontAwesome.Sharp.IconButton();
            ibt_doimatkhau = new FontAwesome.Sharp.IconButton();
            ibt_lichcanhan = new FontAwesome.Sharp.IconButton();
            ibt_account = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            pn_Thongtintaikhoan = new Panel();
            tb_username_logged = new TextBox();
            tb_loaikh = new TextBox();
            tb_slddv = new TextBox();
            tb_sdt = new TextBox();
            tb_id = new TextBox();
            tb_email = new TextBox();
            tb_fullname = new TextBox();
            bt_update_infor = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pn_doimatkhau = new Panel();
            bt_luu_mk = new Button();
            label11 = new Label();
            tb_newpw = new TextBox();
            tb_xacnhan_newpw = new TextBox();
            tb_oldpw = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            pn_lichdatsan = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_calendar_main).BeginInit();
            pn_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pn_Thongtintaikhoan.SuspendLayout();
            pn_doimatkhau.SuspendLayout();
            pn_lichdatsan.SuspendLayout();
            SuspendLayout();
            // 
            // pn_main
            // 
            pn_main.Dock = DockStyle.Fill;
            pn_main.ImeMode = ImeMode.NoControl;
            pn_main.Location = new Point(180, 0);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(665, 450);
            pn_main.TabIndex = 0;
            // 
            // dgv_calendar_main
            // 
            dgv_calendar_main.BorderStyle = BorderStyle.Fixed3D;
            dgv_calendar_main.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 0, 0, 0);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_calendar_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_calendar_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_calendar_main.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_calendar_main.Dock = DockStyle.Fill;
            dgv_calendar_main.EnableHeadersVisualStyles = false;
            dgv_calendar_main.Location = new Point(0, 0);
            dgv_calendar_main.Margin = new Padding(3, 4, 3, 4);
            dgv_calendar_main.Name = "dgv_calendar_main";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(100, 0, 0, 0);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_calendar_main.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_calendar_main.RowHeadersWidth = 51;
            dgv_calendar_main.RowTemplate.Height = 25;
            dgv_calendar_main.Size = new Size(665, 450);
            dgv_calendar_main.TabIndex = 3;
            // 
            // pn_control
            // 
            pn_control.Controls.Add(ibt_dangxuat);
            pn_control.Controls.Add(ibt_doimatkhau);
            pn_control.Controls.Add(ibt_lichcanhan);
            pn_control.Controls.Add(ibt_account);
            pn_control.Controls.Add(pictureBox1);
            pn_control.Dock = DockStyle.Left;
            pn_control.Location = new Point(0, 0);
            pn_control.Name = "pn_control";
            pn_control.Size = new Size(180, 450);
            pn_control.TabIndex = 0;
            // 
            // ibt_dangxuat
            // 
            ibt_dangxuat.BackColor = SystemColors.ControlDark;
            ibt_dangxuat.Dock = DockStyle.Top;
            ibt_dangxuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ibt_dangxuat.IconChar = FontAwesome.Sharp.IconChar.None;
            ibt_dangxuat.IconColor = Color.Black;
            ibt_dangxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibt_dangxuat.Location = new Point(0, 370);
            ibt_dangxuat.Name = "ibt_dangxuat";
            ibt_dangxuat.Size = new Size(180, 80);
            ibt_dangxuat.TabIndex = 4;
            ibt_dangxuat.Text = "Đăng xuất";
            ibt_dangxuat.UseVisualStyleBackColor = false;
            ibt_dangxuat.Click += iconButton3_Click;
            // 
            // ibt_doimatkhau
            // 
            ibt_doimatkhau.BackColor = SystemColors.ControlDark;
            ibt_doimatkhau.Dock = DockStyle.Top;
            ibt_doimatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ibt_doimatkhau.IconChar = FontAwesome.Sharp.IconChar.None;
            ibt_doimatkhau.IconColor = Color.Black;
            ibt_doimatkhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibt_doimatkhau.Location = new Point(0, 290);
            ibt_doimatkhau.Name = "ibt_doimatkhau";
            ibt_doimatkhau.Size = new Size(180, 80);
            ibt_doimatkhau.TabIndex = 3;
            ibt_doimatkhau.Text = "Đổi mật khẩu";
            ibt_doimatkhau.UseVisualStyleBackColor = false;
            ibt_doimatkhau.Click += iconButton1_Click;
            // 
            // ibt_lichcanhan
            // 
            ibt_lichcanhan.BackColor = SystemColors.ControlDark;
            ibt_lichcanhan.Dock = DockStyle.Top;
            ibt_lichcanhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ibt_lichcanhan.IconChar = FontAwesome.Sharp.IconChar.None;
            ibt_lichcanhan.IconColor = Color.Black;
            ibt_lichcanhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibt_lichcanhan.Location = new Point(0, 210);
            ibt_lichcanhan.Name = "ibt_lichcanhan";
            ibt_lichcanhan.Size = new Size(180, 80);
            ibt_lichcanhan.TabIndex = 2;
            ibt_lichcanhan.Text = "Lịch sử đặt sân cá nhân";
            ibt_lichcanhan.UseVisualStyleBackColor = false;
            ibt_lichcanhan.Click += iconButton2_Click;
            // 
            // ibt_account
            // 
            ibt_account.BackColor = SystemColors.ControlDark;
            ibt_account.Dock = DockStyle.Top;
            ibt_account.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ibt_account.IconChar = FontAwesome.Sharp.IconChar.User;
            ibt_account.IconColor = Color.Black;
            ibt_account.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibt_account.IconSize = 40;
            ibt_account.ImageAlign = ContentAlignment.MiddleLeft;
            ibt_account.Location = new Point(0, 130);
            ibt_account.Name = "ibt_account";
            ibt_account.Size = new Size(180, 80);
            ibt_account.TabIndex = 0;
            ibt_account.Text = "ibt_account";
            ibt_account.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibt_account.UseVisualStyleBackColor = false;
            ibt_account.Click += ibt_account_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pn_Thongtintaikhoan
            // 
            pn_Thongtintaikhoan.BackColor = Color.Transparent;
            pn_Thongtintaikhoan.Controls.Add(tb_username_logged);
            pn_Thongtintaikhoan.Controls.Add(tb_loaikh);
            pn_Thongtintaikhoan.Controls.Add(tb_slddv);
            pn_Thongtintaikhoan.Controls.Add(tb_sdt);
            pn_Thongtintaikhoan.Controls.Add(tb_id);
            pn_Thongtintaikhoan.Controls.Add(tb_email);
            pn_Thongtintaikhoan.Controls.Add(tb_fullname);
            pn_Thongtintaikhoan.Controls.Add(bt_update_infor);
            pn_Thongtintaikhoan.Controls.Add(label7);
            pn_Thongtintaikhoan.Controls.Add(label6);
            pn_Thongtintaikhoan.Controls.Add(label5);
            pn_Thongtintaikhoan.Controls.Add(label4);
            pn_Thongtintaikhoan.Controls.Add(label3);
            pn_Thongtintaikhoan.Controls.Add(label2);
            pn_Thongtintaikhoan.Controls.Add(label1);
            pn_Thongtintaikhoan.Dock = DockStyle.Fill;
            pn_Thongtintaikhoan.Location = new Point(180, 0);
            pn_Thongtintaikhoan.Name = "pn_Thongtintaikhoan";
            pn_Thongtintaikhoan.Size = new Size(665, 450);
            pn_Thongtintaikhoan.TabIndex = 0;
            // 
            // tb_username_logged
            // 
            tb_username_logged.BorderStyle = BorderStyle.FixedSingle;
            tb_username_logged.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_username_logged.Location = new Point(276, 69);
            tb_username_logged.Name = "tb_username_logged";
            tb_username_logged.ReadOnly = true;
            tb_username_logged.Size = new Size(273, 34);
            tb_username_logged.TabIndex = 15;
            // 
            // tb_loaikh
            // 
            tb_loaikh.BorderStyle = BorderStyle.FixedSingle;
            tb_loaikh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_loaikh.Location = new Point(276, 336);
            tb_loaikh.Name = "tb_loaikh";
            tb_loaikh.ReadOnly = true;
            tb_loaikh.Size = new Size(273, 34);
            tb_loaikh.TabIndex = 14;
            // 
            // tb_slddv
            // 
            tb_slddv.BorderStyle = BorderStyle.FixedSingle;
            tb_slddv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_slddv.Location = new Point(276, 280);
            tb_slddv.Name = "tb_slddv";
            tb_slddv.ReadOnly = true;
            tb_slddv.Size = new Size(273, 34);
            tb_slddv.TabIndex = 13;
            // 
            // tb_sdt
            // 
            tb_sdt.BorderStyle = BorderStyle.FixedSingle;
            tb_sdt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_sdt.Location = new Point(276, 225);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(273, 34);
            tb_sdt.TabIndex = 12;
            // 
            // tb_id
            // 
            tb_id.BorderStyle = BorderStyle.FixedSingle;
            tb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id.Location = new Point(276, 20);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(273, 34);
            tb_id.TabIndex = 11;
            // 
            // tb_email
            // 
            tb_email.BorderStyle = BorderStyle.FixedSingle;
            tb_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_email.Location = new Point(276, 172);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(273, 34);
            tb_email.TabIndex = 10;
            // 
            // tb_fullname
            // 
            tb_fullname.BorderStyle = BorderStyle.FixedSingle;
            tb_fullname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_fullname.Location = new Point(276, 120);
            tb_fullname.Name = "tb_fullname";
            tb_fullname.Size = new Size(273, 34);
            tb_fullname.TabIndex = 9;
            // 
            // bt_update_infor
            // 
            bt_update_infor.BackColor = Color.Transparent;
            bt_update_infor.Cursor = Cursors.Hand;
            bt_update_infor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_update_infor.ForeColor = Color.Black;
            bt_update_infor.Location = new Point(405, 389);
            bt_update_infor.Name = "bt_update_infor";
            bt_update_infor.Size = new Size(144, 42);
            bt_update_infor.TabIndex = 7;
            bt_update_infor.Text = "Lưu thay đổi";
            bt_update_infor.UseVisualStyleBackColor = false;
            bt_update_infor.Click += bt_update_infor_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(57, 342);
            label7.Name = "label7";
            label7.Size = new Size(158, 28);
            label7.TabIndex = 6;
            label7.Text = "Loại Khách Hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(57, 286);
            label6.Name = "label6";
            label6.Size = new Size(195, 28);
            label6.TabIndex = 5;
            label6.Text = "Số Lần Dùng Dịch Vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 231);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 4;
            label5.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(57, 178);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 122);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 75);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 26);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // pn_doimatkhau
            // 
            pn_doimatkhau.BackColor = SystemColors.ControlDark;
            pn_doimatkhau.Controls.Add(bt_luu_mk);
            pn_doimatkhau.Controls.Add(label11);
            pn_doimatkhau.Controls.Add(tb_newpw);
            pn_doimatkhau.Controls.Add(tb_xacnhan_newpw);
            pn_doimatkhau.Controls.Add(tb_oldpw);
            pn_doimatkhau.Controls.Add(label10);
            pn_doimatkhau.Controls.Add(label9);
            pn_doimatkhau.Controls.Add(label8);
            pn_doimatkhau.Dock = DockStyle.Fill;
            pn_doimatkhau.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            pn_doimatkhau.Location = new Point(180, 0);
            pn_doimatkhau.Name = "pn_doimatkhau";
            pn_doimatkhau.Size = new Size(665, 450);
            pn_doimatkhau.TabIndex = 0;
            pn_doimatkhau.Visible = false;
            // 
            // bt_luu_mk
            // 
            bt_luu_mk.Location = new Point(474, 354);
            bt_luu_mk.Name = "bt_luu_mk";
            bt_luu_mk.Size = new Size(94, 62);
            bt_luu_mk.TabIndex = 8;
            bt_luu_mk.Text = "Lưu";
            bt_luu_mk.UseVisualStyleBackColor = true;
            bt_luu_mk.Click += bt_luu_mk_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLight;
            label11.Location = new Point(167, 20);
            label11.Name = "label11";
            label11.Size = new Size(321, 54);
            label11.TabIndex = 7;
            label11.Text = "ĐỔI MẬT KHẨU";
            // 
            // tb_newpw
            // 
            tb_newpw.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_newpw.Location = new Point(276, 199);
            tb_newpw.Name = "tb_newpw";
            tb_newpw.Size = new Size(292, 38);
            tb_newpw.TabIndex = 5;
            // 
            // tb_xacnhan_newpw
            // 
            tb_xacnhan_newpw.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_xacnhan_newpw.Location = new Point(276, 265);
            tb_xacnhan_newpw.Name = "tb_xacnhan_newpw";
            tb_xacnhan_newpw.Size = new Size(292, 38);
            tb_xacnhan_newpw.TabIndex = 4;
            // 
            // tb_oldpw
            // 
            tb_oldpw.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_oldpw.Location = new Point(276, 120);
            tb_oldpw.Name = "tb_oldpw";
            tb_oldpw.Size = new Size(292, 38);
            tb_oldpw.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(34, 272);
            label10.Name = "label10";
            label10.Size = new Size(219, 31);
            label10.TabIndex = 2;
            label10.Text = "Xác nhận mật khẩu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(34, 206);
            label9.Name = "label9";
            label9.Size = new Size(167, 29);
            label9.TabIndex = 1;
            label9.Text = "Mật khẩu mới";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(34, 127);
            label8.Name = "label8";
            label8.Size = new Size(151, 29);
            label8.TabIndex = 0;
            label8.Text = "Mật khẩu cũ";
            // 
            // pn_lichdatsan
            // 
            pn_lichdatsan.Controls.Add(dgv_calendar_main);
            pn_lichdatsan.Dock = DockStyle.Fill;
            pn_lichdatsan.Location = new Point(180, 0);
            pn_lichdatsan.Name = "pn_lichdatsan";
            pn_lichdatsan.Size = new Size(665, 450);
            pn_lichdatsan.TabIndex = 0;
            pn_lichdatsan.Visible = false;
            // 
            // Khachhang_Mainpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 450);
            Controls.Add(pn_Thongtintaikhoan);
            Controls.Add(pn_lichdatsan);
            Controls.Add(pn_doimatkhau);
            Controls.Add(pn_main);
            Controls.Add(pn_control);
            Name = "Khachhang_Mainpage";
            Text = "Trang chủ Hoàng Kim FC";
            Load += Khachhang_Mainfage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_calendar_main).EndInit();
            pn_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pn_Thongtintaikhoan.ResumeLayout(false);
            pn_Thongtintaikhoan.PerformLayout();
            pn_doimatkhau.ResumeLayout(false);
            pn_doimatkhau.PerformLayout();
            pn_lichdatsan.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pn_control;
        private Panel pn_main;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibt_account;
        private FontAwesome.Sharp.IconButton ibt_lichcanhan;
        private FontAwesome.Sharp.IconButton ibt_dangxuat;
        private FontAwesome.Sharp.IconButton ibt_doimatkhau;
        private Panel pn_Thongtintaikhoan;
        private Panel pn_doimatkhau;
        private DGV dgv_calendar_main;
        private Panel pn_lichdatsan;
        private TextBox tb_loaikh;
        private TextBox tb_slddv;
        private TextBox tb_sdt;
        private TextBox tb_id;
        private TextBox tb_email;
        private TextBox tb_fullname;
        private Button bt_update_infor;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_newpw;
        private TextBox tb_xacnhan_newpw;
        private TextBox tb_oldpw;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox tb_username_logged;
        private Label label11;
        private Button bt_luu_mk;
    }
}