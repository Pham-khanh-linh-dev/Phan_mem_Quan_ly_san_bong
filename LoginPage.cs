using System.Text;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace WinFormsApp3
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }
        public bool UserAuthen { get; private set; }
        public string UserAuthenAdmin { get; private set; }
        public string userInfoUsername { get; private set; }
        private void lb_reg_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserAuthenAdmin = "";
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string pwd = tb_pwd.Text;
            int check = 0;
            int checkadmin = 0;
            string myConnectionString = "server=localhost;database=qlsb;uid=root";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            List<string> stringsAdmin = new List<string>();
            try
            {
                cnn.Open();
                string query = "select * from `quản lý`  where Username_QL = '" + username + "' and Password ='" + pwd + "'";
                MySqlCommand cmd_check = new MySqlCommand(query, cnn);
                MySqlDataReader myreader = cmd_check.ExecuteReader();
                while (myreader.Read())
                {
                    stringsAdmin.Add(Convert.ToString(myreader["ID_QL"]));
                }
                if (stringsAdmin.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công! Administrator");
                    checkadmin = 1;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
                MessageBox.Show(message);
            }
            if (checkadmin == 1)
            {
                userInfoUsername = username;
                UserAuthenAdmin = stringsAdmin[0];
                Close();
            }
            List<string> strings = new List<string>();
            if (checkadmin != 1)
            {
                try
                {
                    cnn.Open();
                    string query = "select * from `nhân viên`  where Username_NV = '" + username + "' and Password ='" + pwd + "'";
                    MySqlCommand cmd_check = new MySqlCommand(query, cnn);
                    MySqlDataReader myreader = cmd_check.ExecuteReader();
                    while (myreader.Read())
                    {
                        strings.Add(Convert.ToString(myreader["ID_NV"]));
                    }
                    if (strings.Count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");

                        check = 1;
                    }
                    else
                    {
                        MessageBox.Show("Chưa có tài khoản với thông tin này trong hệ thống!");
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    string message = ex.ToString();
                    MessageBox.Show(message);
                }
            }
            if (check == 1 && checkadmin == 0)
            {
                userInfoUsername = strings[0];
                UserAuthen = true;
                Close();
            }

        }

        private void lb_regHi_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage form2 = new RegisterPage();
            form2.ShowDialog();
            form2.Closed += (s, args) => this.Show();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_pwd.PasswordChar == '*')
            {
                tb_pwd.PasswordChar = '\0';
            }
            else
            {
                tb_pwd.PasswordChar = '*';
            }
        }
    }
}