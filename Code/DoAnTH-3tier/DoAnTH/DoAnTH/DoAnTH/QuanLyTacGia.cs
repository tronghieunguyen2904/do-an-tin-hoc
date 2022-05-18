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
    public partial class QuanLyTacGia : Form
    {
        private static CXuLyTacGia xuly = new CXuLyTacGia();
        public QuanLyTacGia()
        {
            InitializeComponent();
        }

        private void hienThi(List<TacGia> dsTacGia)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsTacGia;
            dgvTacGia.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TacGia a = new TacGia();
                a.maTacGia = txtMaTacGia.Text;
                a.tenTacGia = txtTenTacGia.Text;
                a.soDienThoai = txtSoDienThoai.Text;
                a.email = txtEmail.Text;
                if(a.maTacGia=="")
                {
                    MessageBox.Show("Bạn chưa nhập mã tác giả!");
                    return;
                }
                if (xuly.them(a) == false)
                {
                    MessageBox.Show("Tác giả đã tồn tại trong hệ thống!");
                }
                else
                {
                    hienThi(xuly.getDSTacGia());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvTacGia.SelectedRows)
            {
                string maTacGia = r.Cells[0].Value.ToString();
                xuly.xoa(maTacGia);
            }
            hienThi(xuly.getDSTacGia());
        }

        private void dgvTacGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgvTacGia.SelectedRows)
            {
                string maTacGia = r.Cells[0].Value.ToString();
                TacGia x = xuly.tim(maTacGia);
                if (x != null)
                {
                    txtMaTacGia.Text = x.maTacGia;
                    txtTenTacGia.Text = x.tenTacGia;
                    txtSoDienThoai.Text = x.soDienThoai;
                    txtEmail.Text = x.email;
                    break;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TacGia x = new TacGia();
            x.maTacGia = txtMaTacGia.Text;
            x.tenTacGia = txtTenTacGia.Text;
            x.soDienThoai = txtSoDienThoai.Text;
            x.email = txtEmail.Text;
            xuly.sua(x);
            hienThi(xuly.getDSTacGia());
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            
        }

        private void QuanLyTacGia_Load(object sender, EventArgs e)
        {

            xuly = new CXuLyTacGia();
            hienThi(xuly.getDSTacGia());
        }
    }
}
