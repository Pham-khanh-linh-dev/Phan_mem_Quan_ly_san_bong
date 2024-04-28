namespace Drink_Manager
{
    partial class Drink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drink));
            btn_add = new Button();
            btn_remove = new Button();
            btn_edit = new Button();
            txt_id = new TextBox();
            txt_ban = new TextBox();
            txt_mua = new TextBox();
            txt_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listViewDrink = new ListView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Orange;
            btn_add.FlatAppearance.BorderColor = Color.Black;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = Color.Black;
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(1, 62);
            btn_add.Margin = new Padding(4, 5, 4, 5);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(163, 70);
            btn_add.TabIndex = 1;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Orange;
            btn_remove.FlatAppearance.BorderColor = Color.Black;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_remove.ForeColor = Color.Black;
            btn_remove.Location = new Point(0, 222);
            btn_remove.Margin = new Padding(4, 5, 4, 5);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(163, 70);
            btn_remove.TabIndex = 2;
            btn_remove.Text = "Xóa";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Orange;
            btn_edit.FlatAppearance.BorderColor = Color.Black;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.Black;
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(1, 142);
            btn_edit.Margin = new Padding(4, 5, 4, 5);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(163, 70);
            btn_edit.TabIndex = 3;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(79, 64);
            txt_id.Margin = new Padding(4, 5, 4, 5);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(124, 31);
            txt_id.TabIndex = 4;
            txt_id.TextChanged += textBox1_TextChanged;
            // 
            // txt_ban
            // 
            txt_ban.Location = new Point(745, 64);
            txt_ban.Margin = new Padding(4, 5, 4, 5);
            txt_ban.Name = "txt_ban";
            txt_ban.Size = new Size(124, 31);
            txt_ban.TabIndex = 5;
            txt_ban.TextChanged += txt_ban_TextChanged;
            // 
            // txt_mua
            // 
            txt_mua.Location = new Point(524, 64);
            txt_mua.Margin = new Padding(4, 5, 4, 5);
            txt_mua.Name = "txt_mua";
            txt_mua.Size = new Size(124, 31);
            txt_mua.TabIndex = 6;
            txt_mua.TextChanged += txt_mua_TextChanged;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(295, 64);
            txt_name.Margin = new Padding(4, 5, 4, 5);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(124, 31);
            txt_name.TabIndex = 7;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(79, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 25);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(295, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 9;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(524, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 10;
            label3.Text = "Giá mua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(745, 34);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 11;
            label4.Text = "Giá bán";
            // 
            // listViewDrink
            // 
            listViewDrink.BackColor = Color.White;
            listViewDrink.Location = new Point(12, 127);
            listViewDrink.Name = "listViewDrink";
            listViewDrink.Size = new Size(800, 420);
            listViewDrink.TabIndex = 12;
            listViewDrink.UseCompatibleStateImageBehavior = false;
            listViewDrink.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listViewDrink.Click += list_click;
            listViewDrink.MouseClick += mouse_click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_edit);
            groupBox1.Controls.Add(btn_remove);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(827, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 420);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txt_ban);
            groupBox2.Controls.Add(txt_id);
            groupBox2.Controls.Add(txt_mua);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_name);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(12, 553);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(976, 127);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 108);
            panel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(372, 29);
            label5.Name = "label5";
            label5.Size = new Size(213, 54);
            label5.TabIndex = 0;
            label5.Text = "ĐỒ UỐNG";
            // 
            // Drink
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 703);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listViewDrink);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Drink";
            Text = "Quản Lý Đồ Uống";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void Drink_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Button btn_add;
        private Button btn_remove;
        private Button btn_edit;
        private TextBox txt_id;
        private TextBox txt_ban;
        private TextBox txt_mua;
        private TextBox txt_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView listViewDrink;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label5;
    }
}

