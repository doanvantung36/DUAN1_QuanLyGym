using BUS;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class ThietBi : Form
    {
        public ThietBiServices _thietBiServices = new();
        List<DAL.DomainClass.ThietBi> _thietBiList;
        int idCellClick;
        public ThietBi()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            //dataGridView1.Rows.Clear();
            //dataGridView1.ColumnCount = 7;
            //dataGridView1.Columns[0].Name = "Loai thiet bi";
            //dataGridView1.Columns[1].Name = "Ten thiet bi";
            //dataGridView1.Columns[2].Name = "Nha cung cap";
            //dataGridView1.Columns[3].Name = "Vi tri";
            //dataGridView1.Columns[4].Name = "Chuc nang";
            //dataGridView1.Columns[5].Name = "So luong";
            //dataGridView1.Columns[6].Name = "Khoi luong";
            //dataGridView1.Columns[7].Name = "Gia tien";
            //int stt = 1;
            //_thietBiList = _thietBiServices.GetAllThietBi();
            //foreach (var item in _thietBiList)
            //{
            //    dataGridView1.Rows.Add(stt++, item.MaLoaiThietBi, item.TenThietBi, item.NhaCungCap, item.ViTri, item.ChucNang, item.SoLuong, item.KhoiLuong, item.Gia);
            //}
        }
        private void ThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var xacnhan = MessageBox.Show("Xác nhận thêm", "Thông báo", MessageBoxButtons.YesNo);
            //if (xacnhan == DialogResult.Yes)
            //{
            //    var CheckExits = (new DAL.DomainClass.ThietBi()
            //    {
            //        MaLoaiThietBi = txt_LoaiThietBi.Text,
            //        TenThietBi = txtTenThietBi.Text,
            //        NhaCungCap = txtNhaCungCap.Text,
            //        ViTri = txtViTri.Text,
            //        ChucNang = txtChucNang.Text,
            //        SoLuong = txtSoLuong.Text,
            //        KhoiLuong = Int32.Parse(txtKhoiLuong.Text),
            //        Gia = Int32.Parse(txtGiaTien.Text),

            //    });
            //    if (CheckExits != null)
            //    {
            //        MessageBox.Show("Thêm thành công", "Thông báo");
            //        LoadData();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm thất bại", "Thông báo");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Không thêm");
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var xacnhan = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo);
            //if (xacnhan != DialogResult.Yes)
            //{
            //    var them = _thietBiServices.DeleteThietBi(idCellClick);
            //    if (them)
            //    {
            //        MessageBox.Show("Xóa thành công");
            //        LoadData();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Xóa thất bại");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("KHông xóa");
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txt_LoaiThietBi.Text = "";
            txtTenThietBi.Text = "";
            txtNhaCungCap.Text = "";
            txtViTri.Text = "";
            txtChucNang.Text = "";
            txtSoLuong.Text = "";
            txtKhoiLuong.Text = "";
            txtGiaTien.Text = "";
        }
    }
}
