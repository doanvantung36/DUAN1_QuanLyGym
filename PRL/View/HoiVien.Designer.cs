namespace PRL.View
{
    partial class HoiVien
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
            tabControl1 = new TabControl();
            tbThongTin = new TabPage();
            tb_DiaChi = new TextBox();
            label7 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btn_Add = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            cb_GioiTinh = new ComboBox();
            date_NgaySinh = new DateTimePicker();
            tb_TenHoiVien = new TextBox();
            tb_SoDienThoai = new TextBox();
            tb_Email = new TextBox();
            tb_MaHoiVien = new TextBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbHopDong = new TabPage();
            btn_Update_HopDong = new Button();
            btn_Delete_HopDong = new Button();
            btn_Add_HopDong = new Button();
            btn_TimKiem_HOpDong = new Button();
            txt_TimKiem_HopDong = new TextBox();
            dtGrit_HopDong = new DataGridView();
            date_NgayHetHan = new DateTimePicker();
            date_NgayDangKi = new DateTimePicker();
            txt_DichVu = new TextBox();
            txt_TenHoiVien = new TextBox();
            txt_MaHopDong = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrit_HopDong).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tbThongTin);
            tabControl1.Controls.Add(tbHopDong);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(929, 492);
            tabControl1.TabIndex = 1;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tbThongTin
            // 
            tbThongTin.Controls.Add(tb_DiaChi);
            tbThongTin.Controls.Add(label7);
            tbThongTin.Controls.Add(btnUpdate);
            tbThongTin.Controls.Add(btnDelete);
            tbThongTin.Controls.Add(btn_Add);
            tbThongTin.Controls.Add(btnTimKiem);
            tbThongTin.Controls.Add(txtTimKiem);
            tbThongTin.Controls.Add(pictureBox1);
            tbThongTin.Controls.Add(cb_GioiTinh);
            tbThongTin.Controls.Add(date_NgaySinh);
            tbThongTin.Controls.Add(tb_TenHoiVien);
            tbThongTin.Controls.Add(tb_SoDienThoai);
            tbThongTin.Controls.Add(tb_Email);
            tbThongTin.Controls.Add(tb_MaHoiVien);
            tbThongTin.Controls.Add(dataGridView1);
            tbThongTin.Controls.Add(label6);
            tbThongTin.Controls.Add(label5);
            tbThongTin.Controls.Add(label4);
            tbThongTin.Controls.Add(label3);
            tbThongTin.Controls.Add(label2);
            tbThongTin.Controls.Add(label1);
            tbThongTin.Location = new Point(4, 24);
            tbThongTin.Name = "tbThongTin";
            tbThongTin.Padding = new Padding(3);
            tbThongTin.Size = new Size(921, 464);
            tbThongTin.TabIndex = 0;
            tbThongTin.Text = "Thông tin";
            tbThongTin.UseVisualStyleBackColor = true;
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Location = new Point(489, 99);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.PlaceholderText = "Nhập địa chỉ";
            tb_DiaChi.Size = new Size(299, 23);
            tb_DiaChi.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 104);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 23;
            label7.Text = "Địa Chỉ";
            // 
            // btnUpdate
            // 
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(713, 166);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 34);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(632, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 34);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn_Add
            // 
            btn_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add.Location = new Point(561, 166);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(63, 34);
            btn_Add.TabIndex = 20;
            btn_Add.Text = "Add";
            btn_Add.TextAlign = ContentAlignment.MiddleRight;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(489, 173);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(71, 23);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 173);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm hội viên";
            txtTimKiem.Size = new Size(463, 23);
            txtTimKiem.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(803, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 135);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // cb_GioiTinh
            // 
            cb_GioiTinh.FormattingEnabled = true;
            cb_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_GioiTinh.Location = new Point(95, 137);
            cb_GioiTinh.Name = "cb_GioiTinh";
            cb_GioiTinh.Size = new Size(281, 23);
            cb_GioiTinh.TabIndex = 15;
            cb_GioiTinh.Text = "Chọn giới tính";
            // 
            // date_NgaySinh
            // 
            date_NgaySinh.Format = DateTimePickerFormat.Custom;
            date_NgaySinh.Location = new Point(95, 99);
            date_NgaySinh.Name = "date_NgaySinh";
            date_NgaySinh.Size = new Size(281, 23);
            date_NgaySinh.TabIndex = 14;
            // 
            // tb_TenHoiVien
            // 
            tb_TenHoiVien.Location = new Point(95, 62);
            tb_TenHoiVien.Name = "tb_TenHoiVien";
            tb_TenHoiVien.PlaceholderText = "Nhập tên hội viên";
            tb_TenHoiVien.Size = new Size(281, 23);
            tb_TenHoiVien.TabIndex = 13;
            // 
            // tb_SoDienThoai
            // 
            tb_SoDienThoai.Location = new Point(489, 25);
            tb_SoDienThoai.Name = "tb_SoDienThoai";
            tb_SoDienThoai.PlaceholderText = "Nhập số điện thoại";
            tb_SoDienThoai.Size = new Size(299, 23);
            tb_SoDienThoai.TabIndex = 12;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(489, 62);
            tb_Email.Name = "tb_Email";
            tb_Email.PlaceholderText = "Nhập Email";
            tb_Email.Size = new Size(299, 23);
            tb_Email.TabIndex = 11;
            // 
            // tb_MaHoiVien
            // 
            tb_MaHoiVien.Location = new Point(95, 25);
            tb_MaHoiVien.Name = "tb_MaHoiVien";
            tb_MaHoiVien.PlaceholderText = "Nhập mã hội viên ";
            tb_MaHoiVien.Size = new Size(281, 23);
            tb_MaHoiVien.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(921, 260);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 67);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 28);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 145);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 106);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên hội viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã hội viên";
            // 
            // tbHopDong
            // 
            tbHopDong.Controls.Add(btn_Update_HopDong);
            tbHopDong.Controls.Add(btn_Delete_HopDong);
            tbHopDong.Controls.Add(btn_Add_HopDong);
            tbHopDong.Controls.Add(btn_TimKiem_HOpDong);
            tbHopDong.Controls.Add(txt_TimKiem_HopDong);
            tbHopDong.Controls.Add(dtGrit_HopDong);
            tbHopDong.Controls.Add(date_NgayHetHan);
            tbHopDong.Controls.Add(date_NgayDangKi);
            tbHopDong.Controls.Add(txt_DichVu);
            tbHopDong.Controls.Add(txt_TenHoiVien);
            tbHopDong.Controls.Add(txt_MaHopDong);
            tbHopDong.Controls.Add(label13);
            tbHopDong.Controls.Add(label12);
            tbHopDong.Controls.Add(label11);
            tbHopDong.Controls.Add(label10);
            tbHopDong.Controls.Add(label9);
            tbHopDong.Location = new Point(4, 24);
            tbHopDong.Name = "tbHopDong";
            tbHopDong.Padding = new Padding(3);
            tbHopDong.Size = new Size(921, 464);
            tbHopDong.TabIndex = 1;
            tbHopDong.Text = "Hợp đồng";
            tbHopDong.UseVisualStyleBackColor = true;
            // 
            // btn_Update_HopDong
            // 
            btn_Update_HopDong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update_HopDong.Location = new Point(802, 96);
            btn_Update_HopDong.Name = "btn_Update_HopDong";
            btn_Update_HopDong.Size = new Size(75, 34);
            btn_Update_HopDong.TabIndex = 27;
            btn_Update_HopDong.Text = "Update";
            btn_Update_HopDong.TextAlign = ContentAlignment.MiddleRight;
            btn_Update_HopDong.UseVisualStyleBackColor = true;
            btn_Update_HopDong.Click += btn_Update_HopDong_Click;
            // 
            // btn_Delete_HopDong
            // 
            btn_Delete_HopDong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Delete_HopDong.Location = new Point(802, 55);
            btn_Delete_HopDong.Name = "btn_Delete_HopDong";
            btn_Delete_HopDong.Size = new Size(75, 34);
            btn_Delete_HopDong.TabIndex = 26;
            btn_Delete_HopDong.Text = "Delete";
            btn_Delete_HopDong.TextAlign = ContentAlignment.MiddleRight;
            btn_Delete_HopDong.UseVisualStyleBackColor = true;
            btn_Delete_HopDong.Click += btn_Delete_HopDong_Click;
            // 
            // btn_Add_HopDong
            // 
            btn_Add_HopDong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_HopDong.Location = new Point(802, 14);
            btn_Add_HopDong.Name = "btn_Add_HopDong";
            btn_Add_HopDong.Size = new Size(75, 34);
            btn_Add_HopDong.TabIndex = 25;
            btn_Add_HopDong.Text = "Add";
            btn_Add_HopDong.TextAlign = ContentAlignment.MiddleRight;
            btn_Add_HopDong.UseVisualStyleBackColor = true;
            btn_Add_HopDong.Click += btn_Add_HopDong_Click;
            // 
            // btn_TimKiem_HOpDong
            // 
            btn_TimKiem_HOpDong.Location = new Point(802, 137);
            btn_TimKiem_HOpDong.Name = "btn_TimKiem_HOpDong";
            btn_TimKiem_HOpDong.Size = new Size(75, 23);
            btn_TimKiem_HOpDong.TabIndex = 24;
            btn_TimKiem_HOpDong.Text = "Tìm kiếm";
            btn_TimKiem_HOpDong.UseVisualStyleBackColor = true;
            btn_TimKiem_HOpDong.Click += btn_TimKiem_HOpDong_Click;
            // 
            // txt_TimKiem_HopDong
            // 
            txt_TimKiem_HopDong.Location = new Point(10, 138);
            txt_TimKiem_HopDong.Name = "txt_TimKiem_HopDong";
            txt_TimKiem_HopDong.PlaceholderText = "Tìm kiếm hợp đồng";
            txt_TimKiem_HopDong.Size = new Size(759, 23);
            txt_TimKiem_HopDong.TabIndex = 23;
            // 
            // dtGrit_HopDong
            // 
            dtGrit_HopDong.BackgroundColor = SystemColors.ControlLightLight;
            dtGrit_HopDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrit_HopDong.Location = new Point(0, 171);
            dtGrit_HopDong.Name = "dtGrit_HopDong";
            dtGrit_HopDong.RowHeadersWidth = 51;
            dtGrit_HopDong.RowTemplate.Height = 25;
            dtGrit_HopDong.Size = new Size(921, 290);
            dtGrit_HopDong.TabIndex = 14;
            dtGrit_HopDong.CellClick += dtGrit_HopDong_CellClick;
            // 
            // date_NgayHetHan
            // 
            date_NgayHetHan.Location = new Point(92, 100);
            date_NgayHetHan.Name = "date_NgayHetHan";
            date_NgayHetHan.Size = new Size(285, 23);
            date_NgayHetHan.TabIndex = 13;
            // 
            // date_NgayDangKi
            // 
            date_NgayDangKi.Location = new Point(92, 68);
            date_NgayDangKi.Name = "date_NgayDangKi";
            date_NgayDangKi.Size = new Size(284, 23);
            date_NgayDangKi.TabIndex = 12;
            // 
            // txt_DichVu
            // 
            txt_DichVu.Location = new Point(485, 6);
            txt_DichVu.Name = "txt_DichVu";
            txt_DichVu.Size = new Size(284, 23);
            txt_DichVu.TabIndex = 9;
            // 
            // txt_TenHoiVien
            // 
            txt_TenHoiVien.Location = new Point(92, 36);
            txt_TenHoiVien.Name = "txt_TenHoiVien";
            txt_TenHoiVien.Size = new Size(284, 23);
            txt_TenHoiVien.TabIndex = 8;
            // 
            // txt_MaHopDong
            // 
            txt_MaHopDong.Location = new Point(92, 6);
            txt_MaHopDong.Name = "txt_MaHopDong";
            txt_MaHopDong.Size = new Size(284, 23);
            txt_MaHopDong.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(393, 14);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 4;
            label13.Text = "Dịch vụ đi kèm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 106);
            label12.Name = "label12";
            label12.Size = new Size(78, 15);
            label12.TabIndex = 3;
            label12.Text = "Ngày hết hạn";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 75);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 2;
            label11.Text = "Ngày đăng kí";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 44);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 1;
            label10.Text = "Tên hội viên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 14);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 0;
            label9.Text = "Mã hợp đồng";
            // 
            // HoiVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(933, 497);
            Controls.Add(tabControl1);
            Name = "HoiVien";
            Text = "QuanLyHoiVien";
            tabControl1.ResumeLayout(false);
            tbThongTin.ResumeLayout(false);
            tbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbHopDong.ResumeLayout(false);
            tbHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrit_HopDong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbThongTin;
        private TabPage tbHopDong;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btn_Add;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private PictureBox pictureBox1;
        private ComboBox cb_GioiTinh;
        private DateTimePicker date_NgaySinh;
        private TextBox tb_TenHoiVien;
        private TextBox tb_SoDienThoai;
        private TextBox tb_Email;
        private TextBox tb_MaHoiVien;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Update_HopDong;
        private Button btn_Delete_HopDong;
        private Button btn_Add_HopDong;
        private Button btn_TimKiem_HOpDong;
        private TextBox txt_TimKiem_HopDong;
        private DataGridView dtGrit_HopDong;
        private DateTimePicker date_NgayHetHan;
        private DateTimePicker date_NgayDangKi;
        private TextBox txt_DichVu;
        private TextBox txt_TenHoiVien;
        private TextBox txt_MaHopDong;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox tb_DiaChi;
        private Label label7;
    }
}