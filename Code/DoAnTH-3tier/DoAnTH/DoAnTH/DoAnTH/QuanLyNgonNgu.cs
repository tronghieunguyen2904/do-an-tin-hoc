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
    public partial class QuanLyNgonNgu : Form
    {
        private static CXuLyNgonNgu xuly = new CXuLyNgonNgu();
        public QuanLyNgonNgu()
        {
            InitializeComponent();
        }
        private void hienThi(List<NgonNgu> dsNgonNgu)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsNgonNgu;
            dgvNgonNgu.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NgonNgu a = new NgonNgu();
                a.maNgonNgu = txtMaNgonNgu.Text;
                a.tenNgonNgu = txtTenNgonNgu.Text;

                if(a.maNgonNgu=="")
                {
                    MessageBox.Show("Bạn chưa nhập mã ngôn ngữ!");
                    return;
                }
                if (xuly.them(a) == false)
                {
                    MessageBox.Show("Ngôn ngữ đã tồn tại trong hệ thống!");
                }
                else
                {
                    hienThi(xuly.getDSNgonNgu());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvNgonNgu.SelectedRows)
            {
                string maNgonNgu = r.Cells[0].Value.ToString();
                xuly.xoa(maNgonNgu);
            }
            hienThi(xuly.getDSNgonNgu());
        }

        private void dgvNgonNgu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgvNgonNgu.SelectedRows)
            {
                string maNgonNgu = r.Cells[0].Value.ToString();
                NgonNgu x = xuly.tim(maNgonNgu);
                if (x != null)
                {
                    txtMaNgonNgu.Text = x.maNgonNgu;
                    txtTenNgonNgu.Text = x.tenNgonNgu;
                    break;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NgonNgu a = new NgonNgu();
            a.maNgonNgu = txtMaNgonNgu.Text;
            a.tenNgonNgu = txtTenNgonNgu.Text;
            xuly.sua(a);
            hienThi(xuly.getDSNgonNgu());
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            
        }

        private void QuanLyNgonNgu_Load(object sender, EventArgs e)
        {
            xuly = new CXuLyNgonNgu();
            hienThi(xuly.getDSNgonNgu());
        }
    }
}
