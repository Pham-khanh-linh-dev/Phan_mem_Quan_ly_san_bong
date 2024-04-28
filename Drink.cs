using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CNPM;
using WinFormsApp3;
using static System.Windows.Forms.LinkLabel;


namespace Drink_Manager
{
    public partial class Drink : Form
    {
        private DataTable dataTable;
        Dictionary<string, DataTable> dateTables = new Dictionary<string, DataTable>();
        string connectionString = "Server=localhost;database=qlsb;port=3306;user id = root;password=;";
        ArrayList drinkList = new ArrayList();
        public Drink()
        {
            InitializeComponent();

        }
        private void load_data()
        {
            this.BackgroundImage = CNPM.Properties.Resources.drink_service;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM `đồ uống`";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                con.Close();
                foreach (DataRow row in dataTable.Rows)
                {
                    CNPM.DrinkItem drink = new CNPM.DrinkItem(
                        row["Tên"].ToString(),
                        int.Parse(row["Giá mua"].ToString()),
                        int.Parse(row["Giá bán"].ToString()),
                        row["ID_DU"].ToString()
                        );
                    drinkList.Add(drink);
                }


            }
            listViewDrink.View = View.Details;
            listViewDrink.FullRowSelect = true;

            listViewDrink.Columns.Add("ID", 200);
            listViewDrink.Columns.Add("Tên Đồ Uống", 295);
            listViewDrink.Columns.Add("Giá mua", 150);
            listViewDrink.Columns.Add("Giá bán", 150);

    
            foreach (CNPM.DrinkItem drink in drinkList)
            {
                showItem(drink);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data();
            panel1.BackColor     = Color.FromArgb(175, 255, 255, 255);
            groupBox1.BackColor  = Color.FromArgb(175, 255, 255, 255);
            groupBox2.BackColor  = Color.FromArgb(175, 255, 255, 255);
            btn_add.BackColor    = Color.FromArgb(195, 255, 255, 255);
            btn_edit.BackColor   = Color.FromArgb(195, 255, 255, 255);
            btn_remove.BackColor = Color.FromArgb(195, 255, 255, 255); 
        }
        private void showItem(CNPM.DrinkItem drink)
        {
            ListViewItem list = new ListViewItem(drink.getId());
            list.SubItems.Add(drink.getName());
            list.SubItems.Add(drink.getGiaMua().ToString());
            list.SubItems.Add(drink.getGiaban().ToString());
            listViewDrink.Items.Add(list);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (txt_id.Text.Length == 0 || txt_name.Text.Length == 0 || txt_mua.Text.Length == 0 || txt_ban.Text.Length == 0)
            {
                check = 0;
            }
            try
            {
                string query = string.Format("insert into `đồ uống` values('{0}','{1}','{2}','{3}')", txt_id.Text, txt_name.Text, txt_mua.Text, txt_ban.Text);
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1 && check == 1)
                    {
                        CNPM.DrinkItem drink = new CNPM.DrinkItem(txt_name.Text,
                            int.Parse(txt_mua.Text),
                            int.Parse(txt_ban.Text),
                            txt_id.Text);
                        showItem(drink);
                        MessageBox.Show("Thêm thành công");
                        txt_id.Clear();
                        txt_name.Clear();
                        txt_mua.Clear();
                        txt_ban.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "") {
                MessageBox.Show("Chưa có thông tin");
            }
            else {
                string query = string.Format("delete from `đồ uống` where ID_DU='{0}'", txt_id.Text);
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa thành công");
                        listViewDrink.Items.Remove(listViewDrink.SelectedItems[0]);
                        txt_id.Clear();
                        txt_name.Clear();
                        txt_mua.Clear();
                        txt_ban.Clear();
                    }
                }
            }
        }
        private void editListview() {
            listViewDrink.SelectedItems[0].SubItems[0].Text = txt_id.Text;
            listViewDrink.SelectedItems[0].SubItems[1].Text = txt_name.Text;
            listViewDrink.SelectedItems[0].SubItems[2].Text = txt_mua.Text;
            listViewDrink.SelectedItems[0].SubItems[3].Text = txt_ban.Text;

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string mua = txt_mua.Text;  
            string ban = txt_ban.Text;
            if (id == "" || name == ""|| mua == "" || ban == "")
            {
                MessageBox.Show("Chưa có thông tin");
            }
            else
            {
                string query = string.Format("update `đồ uống` set `Tên`='{0}', `Giá mua`='{1}', `Giá bán`='{2}' where ID_DU='{3}'", name, mua, ban, id);
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Sửa thành công");
                        editListview();
                        txt_id.Clear();
                        txt_name.Clear();
                        txt_mua.Clear();
                        txt_ban.Clear();
                        //load_data();
                    }
                }
            }

        }

        private void drink_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void drink_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ban_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mua_TextChanged(object sender, EventArgs e)
        {

        }

        private void drink_list_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
           
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_click(object sender, EventArgs e)
        {
            if (listViewDrink.SelectedItems.Count > 0) {
                String id = listViewDrink.SelectedItems[0].SubItems[0].Text;
                String name = listViewDrink.SelectedItems[0].SubItems[1].Text;
                String giaban = listViewDrink.SelectedItems[0].SubItems[2].Text;
                String giamua = listViewDrink.SelectedItems[0].SubItems[3].Text;

                txt_id.Text = id;
                txt_name.Text = name;
                txt_mua.Text = giamua;
                txt_ban.Text = giaban;
                MessageBox.Show(id + "  " + name + "  " + giaban + "  " + giamua);
            }
        }
    }
}
