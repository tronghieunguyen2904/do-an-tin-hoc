using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DoAnTH
{
    public partial class QuanLyLoaiSach : Form
    {
        private static CXuLyLoaiSach xuly = new CXuLyLoaiSach();
        public QuanLyLoaiSach()
        {
            InitializeComponent();
        }

        private void hienThi(List<LoaiSach> dsLoai)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsLoai;
            dgvLoaiSach.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiSach a = new LoaiSach();
                a.maLoai = txtMaLoai.Text;
                a.tenLoai = txtTenLoai.Text;
                a.soLuongLoai = txtSoLuong.Text;
                
                if(a.maLoai == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã loại sách!");
                    return;
                }
                if (xuly.them(a) == false)
                {
                    MessageBox.Show("Loại sách đã tồn tại trong hệ thống!");
                }
                else
                {
                    hienThi(xuly.getDSLoaiSach());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvLoaiSach.SelectedRows)
            {
                string maLoai = r.Cells[0].Value.ToString();
                xuly.xoa(maLoai);
            }
            hienThi(xuly.getDSLoaiSach());
        }

        private void dgvLoaiSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgvLoaiSach.SelectedRows)
            {
                string maLoai = r.Cells[0].Value.ToString();
                LoaiSach a = xuly.tim(maLoai);
                if (a != null)
                {
                    txtMaLoai.Text = a.maLoai;
                    txtTenLoai.Text = a.tenLoai;
                    txtSoLuong.Text = a.soLuongLoai;
                    break;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiSach a = new LoaiSach();
            a.maLoai = txtMaLoai.Text;
            a.tenLoai = txtTenLoai.Text;
            a.soLuongLoai = txtSoLuong.Text;
            xuly.sua(a);
            hienThi(xuly.getDSLoaiSach());
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
           
        }

        private void QuanLyLoaiSach_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyLoaiSach();
            hienThi(xuly.getDSLoaiSach());
        }
    }
}
