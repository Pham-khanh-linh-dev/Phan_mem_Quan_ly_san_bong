using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Paddings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CNPM
{

    public partial class Khachhang_Mainpage : Form
    {

        public Khachhang_Mainpage(Khachhang_logged kh)
        {
            InitializeComponent();
            kh_logged = kh;
        }
        static Khachhang_logged kh_logged;


        String strcon = "server=localhost;database=qlsb;uid=root";
        MySqlConnection con = null;

        private void Moketnoi()
        {
            if (con == null)
            {
                con = new MySqlConnection(strcon);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void Dongketnoi()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private void Khachhang_Mainfage_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.mainmenu;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //Load_menu_graphic
            pn_main.Visible = true;
            pn_lichdatsan.Visible = false;
            pn_doimatkhau.Visible = false;
            pn_Thongtintaikhoan.Visible = false;
            DateTime now = DateTime.Now;
            pn_main.BackColor = Color.FromArgb(100, 0, 0, 0);
            pn_lichdatsan.BackColor = Color.FromArgb(100, 0, 0, 0);
            pn_doimatkhau.BackColor = Color.FromArgb(100, 0, 0, 0);
            pn_Thongtintaikhoan.BackColor = Color.FromArgb(100, 0, 0, 0);

            ibt_account.Text = kh_logged.Username;

            //System_config_datetime_sqlConnection
            string date = now.Month + "/" + now.Day + "/" + now.Year;
            string date_tmp = "STR_TO_DATE('" + date + "','%m/%d/%Y')";
            //day_show_btn.Text = now.Day + "/" + now.Month + "/" + now.Year;
            string myConnectionString = "server=localhost;database=qlsb;uid=root";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            try
            {
                cnn.Open();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
            //////////////////////////////////////////////////////////////////////////////////////
            //get schedule for the mainmenu
            BindingSource bindingSource1 = new BindingSource();
            string selectCommand = "Select `ID_SB`, `Giờ bắt đầu`, `Thời gian`, `Username`, `Khách hàng`,`Status` from `lịch đặt sân` where `Khách hàng` = '" + kh_logged.ID_kh + "'";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter = new MySqlDataAdapter(selectCommand, myConnectionString);
            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };
            myDataAdapter.Fill(table);
            bindingSource1.DataSource = table;
            dgv_calendar_main.DataSource = bindingSource1;
            dgv_calendar_main.AutoResizeColumns();

            dgv_calendar_main.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_calendar_main.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_calendar_main.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_calendar_main.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_calendar_main.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_calendar_main.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgv_calendar_main.Parent = pn_lichdatsan;
            /////////////////////////////////////////////////////////////////////////////////////


        }

        private void ibt_account_Click(object sender, EventArgs e)
        {
            pn_main.Visible = false;
            pn_doimatkhau.Visible = false;
            pn_Thongtintaikhoan.Visible = true;
            pn_lichdatsan.Visible = false;
            this.BackgroundImage = Properties.Resources.datsan;
            pn_Thongtintaikhoan.BackgroundImage = Properties.Resources.datsan;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            tb_id.Text = kh_logged.ID_kh;
            tb_username_logged.Text = kh_logged.Username;
            tb_fullname.Text = kh_logged.Ten;
            tb_email.Text = kh_logged.email;
            tb_sdt.Text = kh_logged.sdt;
            tb_slddv.Text = kh_logged.dungdv.ToString();
            tb_loaikh.Text = kh_logged.Loai_kh;
        }

        private void suathongtin(string id_kh)
        {
            Moketnoi();
            MySqlCommand cm = new MySqlCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Update `khách hàng` set Tên = @fullname, Email = @email, SĐT = @sdt where ID_KH = @id_kh ";
            cm.Connection = con;
            cm.Parameters.Add("@email", MySqlDbType.String).Value = tb_email.Text;
            cm.Parameters.Add("@fullname", MySqlDbType.String).Value = tb_fullname.Text;
            cm.Parameters.Add("@sdt", MySqlDbType.String).Value = tb_sdt.Text;

            cm.Parameters.Add("@id_kh", MySqlDbType.String).Value = kh_logged.ID_kh;

            int kq = cm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa thông tin thành công");
            }
        }
        private void bt_update_infor_Click(object sender, EventArgs e)
        {
            suathongtin(kh_logged.ID_kh);
        }

        //Hết phần thông tin khách hàng

        private void iconButton2_Click(object sender, EventArgs e)
        {
            pn_main.Visible = false;
            pn_doimatkhau.Visible = false;
            pn_lichdatsan.Visible = true;
            pn_Thongtintaikhoan.Visible = false;
            this.BackgroundImage = Properties.Resources.datsan;
            pn_lichdatsan.BackgroundImage = Properties.Resources.datsan;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        //////////////DOI MAT KHAU
        private void iconButton1_Click(object sender, EventArgs e)
        {
            pn_main.Visible = false;
            pn_doimatkhau.Visible = true;
            pn_lichdatsan.Visible = false;
            pn_Thongtintaikhoan.Visible = false;
            this.BackgroundImage = Properties.Resources.datsan;
            pn_doimatkhau.BackgroundImage = Properties.Resources.datsan;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private void DoiMatKhau(string username, string newPassword)
        {
            try
            {
                string myConnectionString = "server=localhost;database=qlsb;uid=root";
                using (MySqlConnection cnn = new MySqlConnection(myConnectionString))
                {
                    cnn.Open();

                    // Mã hóa mật khẩu mới
                    string hashedPassword = HashPassword(newPassword);

                    // Cập nhật mật khẩu trong cơ sở dữ liệu
                    string updateCommand = $"UPDATE `khách hàng` SET Password = '{hashedPassword}' WHERE Username_KH = '{username}'";
                    MySqlCommand cmd = new MySqlCommand(updateCommand, cnn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
                MessageBox.Show(message);
            }
        }
        // mã hóa mk
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, hashedPassword);
        }

        private bool CheckLogin(string username, string password)
        {
            MySqlConnection cnn = new MySqlConnection("server=localhost;database=qlsb;uid=root");

            try
            {
                cnn.Open();
                string query = "SELECT Password FROM `khách hàng` WHERE Username_KH = '" + username + "'";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string storedPassword = Convert.ToString(reader["Password"]);


                    // So sánh mật khẩu đã lưu với mật khẩu nhập vào sử dụng thư viện bảo mật hợp lý
                    if (VerifyPassword(password, storedPassword))
                    {

                        return true; // Đăng nhập thành công

                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

            return false; // Đăng nhập thất bại
        }
        private void bt_luu_mk_Click(object sender, EventArgs e)
        {
            string old_pw = tb_oldpw.Text;
            string new_pw = tb_newpw.Text;
            string pw_confirm = tb_xacnhan_newpw.Text;

            if (string.IsNullOrEmpty(new_pw) || new_pw != pw_confirm || new_pw == old_pw)
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ hoặc không khớp. Vui lòng nhập lại.");
                return;
            }
            if (string.IsNullOrEmpty(old_pw) || CheckLogin(kh_logged.Username, old_pw) == false)
            {
                MessageBox.Show("Mật khẩu cũ không hợp lệ hoặc không khớp. Vui lòng nhập lại.");
                return;
            }
            DoiMatKhau(kh_logged.Username, new_pw);
            tb_oldpw.Clear();
            tb_newpw.Clear();
            tb_xacnhan_newpw.Clear();
        }
        // hết phần đổi mk
        /// đăng xuất
        private void iconButton3_Click(object sender, EventArgs e)
        {
            New_Login_KH dangnhap = new New_Login_KH();
            dangnhap.ShowDialog();
            this.Close();
            this.Hide();
        }


    }
}
