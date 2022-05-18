using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNgonNgu_Click(object sender, EventArgs e)
        {
            QuanLyNgonNgu ngonNgu = new QuanLyNgonNgu();
            ngonNgu.ShowDialog();
        }

        private void btnLoaiSach_Click(object sender, EventArgs e)
        {
            QuanLyLoaiSach loaiSach = new QuanLyLoaiSach();
            loaiSach.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyNhaXuatBan NhaXB = new QuanLyNhaXuatBan();
            NhaXB.ShowDialog();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            QuanLyTacGia tacGia = new QuanLyTacGia();
            tacGia.ShowDialog();
        }

        private void quảnLýNgônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNgonNgu f = new QuanLyNgonNgu();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLoaiSach f = new QuanLyLoaiSach();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhaXuatBan f = new QuanLyNhaXuatBan();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTacGia f = new QuanLyTacGia();
            f.MdiParent = this;
            f.Show();
        }

        private void ghiDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoitao();
            if (data.ghiFile("sach.dat") == true)
                MessageBox.Show("Ghi dữ liệu thành công!");
            else MessageBox.Show("Không ghi được dữ liệu!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoitao();
            if (data.docFile("sach.dat") == false)
                MessageBox.Show("Không đọc được dữ liệu!");
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach f = new QuanLySach();
            f.MdiParent = this;
            f.Show();
        }
    }
}
