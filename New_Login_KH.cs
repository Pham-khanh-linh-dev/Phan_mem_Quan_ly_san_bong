using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3;

namespace CNPM
{

    public partial class New_Login_KH : Form
    {

        public New_Login_KH()
        {
            InitializeComponent();
        }

        private void New_Login_KH_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
                this.Hide();
                var form2 = new RegisterPage();
                form2.Closed += (s, args) => this.Show();
                form2.Show();
        }

        private bool CheckLogin(string username, string password)
        {
            MySqlConnection cnn = new MySqlConnection("server=localhost;database=qlsb;uid=root");

            try
            {
                cnn.Open();
                string query = "SELECT * FROM `khách hàng` WHERE Username_KH = '" + username + "'";
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

        private bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, hashedPassword);
        }
        public static Khachhang_logged khachHang;
        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_pwd.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
                return;
            }

            if (CheckLogin(username, password))
            {
                khachHang = GetCustomerInfo(username);
                khachHang.pw = password;
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
        private Khachhang_logged GetCustomerInfo(string username)
        {
            MySqlConnection cnn = new MySqlConnection("server=localhost;database=qlsb;uid=root");
            Khachhang_logged khachHang = null;

            try
            {
                cnn.Open();
                string query = "SELECT `ID_KH`, `Username_KH`,`Tên`,`Email`,`SĐT`,`Số lần dùng DV`,`Loại KH` FROM `khách hàng` WHERE Username_KH = '" + username + "'";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    khachHang = new Khachhang_logged
                    {
                        ID_kh = Convert.ToString(reader["ID_KH"]),
                        Username = Convert.ToString(reader["Username_KH"]),
                        Ten = Convert.ToString(reader["Tên"]),
                        email = Convert.ToString(reader["Email"]),
                        sdt = Convert.ToString(reader["SĐT"]),
                        dungdv = Convert.ToInt32(reader["Số lần dùng DV"]),
                        Loai_kh = Convert.ToString(reader["Loại KH"]),
                    };
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

            return khachHang;
        }
    }
}
