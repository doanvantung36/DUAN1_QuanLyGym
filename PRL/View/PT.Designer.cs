namespace PRL.View
{
    partial class PT
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            dg_PT = new DataGridView();
            txt_MaPT = new TextBox();
            txtTenPT = new TextBox();
            txtDiaChi = new TextBox();
            txtSoDienThoai = new TextBox();
            txt_Email = new TextBox();
            date_ngaySinh = new DateTimePicker();
            cb_GioiTinh = new ComboBox();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Add = new Button();
            btn_Search = new Button();
            txttimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            txt_caTap = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dg_PT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 11);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã huấn luyện viên(PT)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 42);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên huấn luyện viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 73);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 104);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 135);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(604, 42);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 6;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(604, 11);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 5;
            label10.Text = "Số điện thoại";
            // 
            // dg_PT
            // 
            dg_PT.BackgroundColor = SystemColors.HighlightText;
            dg_PT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_PT.Location = new Point(10, 199);
            dg_PT.Name = "dg_PT";
            dg_PT.RowHeadersWidth = 51;
            dg_PT.RowTemplate.Height = 25;
            dg_PT.Size = new Size(891, 275);
            dg_PT.TabIndex = 10;
            // 
            // txt_MaPT
            // 
            txt_MaPT.Location = new Point(321, 10);
            txt_MaPT.Name = "txt_MaPT";
            txt_MaPT.Size = new Size(277, 23);
            txt_MaPT.TabIndex = 11;
            // 
            // txtTenPT
            // 
            txtTenPT.Location = new Point(321, 40);
            txtTenPT.Name = "txtTenPT";
            txtTenPT.Size = new Size(277, 23);
            txtTenPT.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(321, 135);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(277, 23);
            txtDiaChi.TabIndex = 13;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(700, 8);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(200, 23);
            txtSoDienThoai.TabIndex = 14;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(700, 40);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(200, 23);
            txt_Email.TabIndex = 15;
            // 
            // date_ngaySinh
            // 
            date_ngaySinh.Location = new Point(321, 69);
            date_ngaySinh.Name = "date_ngaySinh";
            date_ngaySinh.Size = new Size(277, 23);
            date_ngaySinh.TabIndex = 17;
            // 
            // cb_GioiTinh
            // 
            cb_GioiTinh.FormattingEnabled = true;
            cb_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_GioiTinh.Location = new Point(321, 101);
            cb_GioiTinh.Name = "cb_GioiTinh";
            cb_GioiTinh.Size = new Size(277, 23);
            cb_GioiTinh.TabIndex = 19;
            // 
            // btn_Update
            // 
            btn_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update.Location = new Point(825, 163);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 34);
            btn_Update.TabIndex = 27;
            btn_Update.Text = "Update";
            btn_Update.TextAlign = ContentAlignment.MiddleRight;
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Delete.Location = new Point(733, 163);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 34);
            btn_Delete.TabIndex = 26;
            btn_Delete.Text = "Delete";
            btn_Delete.TextAlign = ContentAlignment.MiddleRight;
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add.Location = new Point(651, 163);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(63, 34);
            btn_Add.TabIndex = 25;
            btn_Add.Text = "Add";
            btn_Add.TextAlign = ContentAlignment.MiddleRight;
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(569, 169);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(71, 23);
            btn_Search.TabIndex = 24;
            btn_Search.Text = "Tìm kiếm";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // txttimKiem
            // 
            txttimKiem.Location = new Point(13, 170);
            txttimKiem.Name = "txttimKiem";
            txttimKiem.PlaceholderText = "Tìm kiếm PT";
            txttimKiem.Size = new Size(550, 23);
            txttimKiem.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(23, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 135);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txt_caTap);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dg_PT);
            panel1.Controls.Add(btn_Update);
            panel1.Controls.Add(btn_Delete);
            panel1.Controls.Add(btn_Add);
            panel1.Controls.Add(btn_Search);
            panel1.Controls.Add(txttimKiem);
            panel1.Controls.Add(cb_GioiTinh);
            panel1.Controls.Add(date_ngaySinh);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(txtSoDienThoai);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtTenPT);
            panel1.Controls.Add(txt_MaPT);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 477);
            panel1.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(700, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 30;
            // 
            // txt_caTap
            // 
            txt_caTap.AutoSize = true;
            txt_caTap.Location = new Point(604, 75);
            txt_caTap.Name = "txt_caTap";
            txt_caTap.Size = new Size(41, 15);
            txt_caTap.TabIndex = 29;
            txt_caTap.Text = "Ca tập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(604, 109);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 31;
            label7.Text = "Trạng thái";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Active", "Free" });
            comboBox1.Location = new Point(700, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 32;
            // 
            // PT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(915, 482);
            Controls.Add(panel1);
            Name = "PT";
            Text = "PT";
            ((System.ComponentModel.ISupportInitialize)dg_PT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label10;
        private DataGridView dg_PT;
        private TextBox txt_MaPT;
        private TextBox txtTenPT;
        private TextBox txtDiaChi;
        private TextBox txtSoDienThoai;
        private TextBox txt_Email;
        private DateTimePicker date_ngaySinh;
        private ComboBox cb_GioiTinh;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Add;
        private Button btn_Search;
        private TextBox txttimKiem;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label7;
        private TextBox textBox1;
        private Label txt_caTap;
        private ComboBox comboBox1;
    }
}