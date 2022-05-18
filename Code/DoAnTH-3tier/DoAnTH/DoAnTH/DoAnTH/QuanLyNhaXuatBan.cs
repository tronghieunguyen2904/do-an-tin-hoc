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
    public partial class QuanLyNhaXuatBan : Form
    {
        private static CXuLyNhaXuatBan xuly = new CXuLyNhaXuatBan();
        public QuanLyNhaXuatBan()
        {
            InitializeComponent();
        }

        private void hienThi(List<NhaXuatBan> dsNhaXuatBan)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsNhaXuatBan;
            dgvNhaXuatBan.DataSource = bs;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhaXuatBan a = new NhaXuatBan();
                a.maNhaXuatBan = txtMaNhaXuatBan.Text;
                a.tenNhaXUatBan = txtTenNhaXuatBan.Text;
                a.soDienThoaiNXB = txtsoDienThoai.Text;
                a.emailNXB = txtEmail.Text;
                a.diaChi = txtDiaChi.Text;

                if(a.maNhaXuatBan=="")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhà xuất bản!");
                    return;
                }
                if (xuly.them(a) == false)
                {
                    MessageBox.Show("Nhà xuất bản đã tồn tại trong hệ thống!");
                }
                else
                {
                    hienThi(xuly.getDSNhaXuatBan());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvNhaXuatBan.SelectedRows)
            {
                string maNhaXuatBan = r.Cells[0].Value.ToString();
                xuly.xoa(maNhaXuatBan);
            }
            hienThi(xuly.getDSNhaXuatBan());
        }

        private void dgvNhaXuatBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgvNhaXuatBan.SelectedRows)
            {
                string maNhaXuatBan = r.Cells[0].Value.ToString();
                NhaXuatBan x = xuly.tim(maNhaXuatBan);
                if (x != null)
                {
                    txtMaNhaXuatBan.Text = x.maNhaXuatBan;
                    txtTenNhaXuatBan.Text = x.tenNhaXUatBan;
                    txtsoDienThoai.Text = x.soDienThoaiNXB;
                    txtEmail.Text = x.emailNXB;
                    txtDiaChi.Text = x.diaChi;
                    break;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaXuatBan a = new NhaXuatBan();
            a.maNhaXuatBan = txtMaNhaXuatBan.Text;
            a.tenNhaXUatBan = txtTenNhaXuatBan.Text;
            a.soDienThoaiNXB = txtsoDienThoai.Text;
            a.emailNXB = txtEmail.Text;
            a.diaChi = txtDiaChi.Text;
            xuly.sua(a);
            hienThi(xuly.getDSNhaXuatBan());
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            
        }

        private void QuanLyNhaXuatBan_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyNhaXuatBan();
            hienThi(xuly.getDSNhaXuatBan());
        }
    }
}
