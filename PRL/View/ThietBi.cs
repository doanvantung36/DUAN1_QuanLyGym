using BUS.Service;

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
            
        }
        private void ThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
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
