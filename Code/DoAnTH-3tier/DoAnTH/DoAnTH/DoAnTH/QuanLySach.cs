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
    public partial class QuanLySach : Form
    {
        private  CXuLyTacGia xulyTG ;
        private  CXuLyNhaXuatBan xulyNXB ;
        private  CXuLyLoaiSach xulyLS ;
        private  CXuLyNgonNgu xulyNN ;
        private  CXuLySach xulySach ;
        private  Sach hdSach ;
        private  List<TacGia> tg2;
        
        public QuanLySach()
        {
            InitializeComponent();
        }
        private void hienthiComboBoxTacGia(List<TacGia> dsTG)
        {
            cmbMaTacGia.DisplayMember = "maTacGia";
            cmbMaTacGia.ValueMember = "maTacGia";
            cmbMaTacGia.DataSource = dsTG;
        }
        private void hienthiComboBoxNXB(List<NhaXuatBan> dsNXB)
        {
            cmbMaNxb.DisplayMember = "maNhaXuatBan";
            cmbMaNxb.ValueMember = "maNhaXuatBan";
            cmbMaNxb.DataSource = dsNXB;
        }
        private void hienthiComboBoxLS(List<LoaiSach> dsLS)
        {
            cmbMaLoai.DisplayMember = "maLoai";
            cmbMaLoai.ValueMember = "maLoai";
            cmbMaLoai.DataSource = dsLS;
        }
        private void hienthiComboBoxNN(List<NgonNgu> dsNN)
        {
            cmbMaNgonNgu.DisplayMember = "maNgonNgu";
            cmbMaNgonNgu.ValueMember = "maNgonNgu";
            cmbMaNgonNgu.DataSource = dsNN;
        }

        private void cmbMaTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matacgia = cmbMaTacGia.SelectedValue.ToString();
            TacGia a = xulyTG.tim(matacgia);
            txtTenTacGia.Text = a.tenTacGia;
            txtSdtTacGia.Text = a.soDienThoai;
            txtEmailTg.Text = a.email;

        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            xulyTG = new CXuLyTacGia();
            hienthiComboBoxTacGia(xulyTG.getDSTacGia());
            xulyNXB = new CXuLyNhaXuatBan();
            hienthiComboBoxNXB(xulyNXB.getDSNhaXuatBan());
            xulyLS = new CXuLyLoaiSach();
            hienthiComboBoxLS(xulyLS.getDSLoaiSach());
            xulyNN = new CXuLyNgonNgu();
            hienthiComboBoxNN(xulyNN.getDSNgonNgu());
            xulySach = new CXuLySach();
            tg2 = new List<TacGia>();
            hdSach = new Sach();
            hienthiDSSach(hdSach);
        }

        private void cmbMaNxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manxb = cmbMaNxb.SelectedValue.ToString();
            NhaXuatBan a = xulyNXB.tim(manxb);
            txtTenNhaXuatBan.Text = a.tenNhaXUatBan;
            txtDiaChi.Text = a.diaChi;
            txtSdtNxb.Text =a.soDienThoaiNXB;
            txtEmailNxb.Text = a.emailNXB;
        }

        private void cmbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maloai = cmbMaLoai.SelectedValue.ToString();
            LoaiSach a = xulyLS.tim(maloai);
            txtTenLoai.Text = a.tenLoai;
            txtSoLuongLoai.Text = a.soLuongLoai;
        }

        private void cmbMaNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mangonngu = cmbMaNgonNgu.SelectedValue.ToString();
            NgonNgu a = xulyNN.tim(mangonngu);
            txtTenNgonNgu.Text = a.tenNgonNgu;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
                string ma=txtMaSach.Text;
                if(ma=="")
                {
                    MessageBox.Show("Bạn chưa nhập mã sách!");
                    return;
                }
                if (xulySach.tim(ma) != null)
                {
                    MessageBox.Show("Mã sách đã tồn tại!");
                    return;
                }
                Sach ct = new Sach();
                string manxb = cmbMaNxb.SelectedValue.ToString();
                string maloai = cmbMaLoai.SelectedValue.ToString();
                string mangonngu = cmbMaNgonNgu.SelectedValue.ToString();
                ct.nhaXuatBan = xulyNXB.tim(manxb);
                ct.loaiSach = xulyLS.tim(maloai);
                ct.ngonNgu = xulyNN.tim(mangonngu);
                ct.maSach = txtMaSach.Text;
                ct.tenSach = txtTenSach.Text;
                ct.soLuongSach = txtSoLuongSach.Text;
                ct.gia = txtGia.Text;
            
                foreach (DataGridViewRow r in dgvTacGia1.Rows)
                {
                TacGia tg;
                tg = xulyTG.tim(r.Cells[0].Value?.ToString());
                ct.tacGia.Add(tg);
                }
                xulySach.them(ct);
                dgvTacGia1.Rows.Clear();

                hienthiDSSach(hdSach);
          
        }
        private void hienthiDSSach(Sach x)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource= ViewSach.chuyendoi(xulySach.getDSSach());
            dgv.DataSource = bs;
        }


        //private void btnLap_Click(object sender, EventArgs e)
        //{
        //    hdSach.maSach = txtMaSach.Text;
        //    hdSach.tenSach = txtTenSach.Text;
        //    hdSach.soLuongSach = txtSoLuongSach.Text;
        //    hdSach.gia = txtGia.Text;
        //    if (xulySach.them(hdSach) == false)
        //    {
        //        MessageBox.Show("Không thêm được sách!");
        //    }
        //    else
        //    {
        //        hienthiDSSach(xulySach.getDSSach());
        //        hdSach = new Sach();
        //        hienthiHoadon(hdSach);
        //    }
        //}
        private void hienthiDSTG(List<TacGia> tg)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tg.ToList();
            dgvTacGia1.DataSource = bs;
           
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuongLoai_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            TacGia tg = xulyTG.tim(cmbMaTacGia.SelectedValue.ToString());
            tg2.Add(tg);
            hienthiDSTG(tg2);
        }

        private void dgvTacGia_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string masach = r.Cells[0].Value.ToString();
                Sach a = xulySach.tim(masach);
                txtMaSach.Text = a.maSach;
                txtTenSach.Text = a.tenSach;
                txtSoLuongSach.Text = a.soLuongSach;
                txtGia.Text = a.gia;
                cmbMaNgonNgu.SelectedValue = a.ngonNgu.maNgonNgu;
                cmbMaLoai.SelectedValue = a.loaiSach.maLoai;
                cmbMaNxb.SelectedValue = a.nhaXuatBan.maNhaXuatBan;
                hienthiDSTG(a.tacGia);
                break;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string maLoai = r.Cells[0].Value.ToString();
                xulySach.xoa(maLoai);
                MessageBox.Show("Xóa thông tin thành công");
            }
            hienthiDSSach(hdSach);
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvTacGia1.SelectedRows)
            {
                string maTacGia = r.Cells[0].Value.ToString();
                TacGia tg = xulyTG.tim(maTacGia);
                tg2.Remove(tg);
                MessageBox.Show("Xóa thành công");
            }
            hienthiDSTG(tg2);
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            Sach ct = new Sach();
            string manxb = cmbMaNxb.SelectedValue.ToString();
            string maloai = cmbMaLoai.SelectedValue.ToString();
            string mangonngu = cmbMaNgonNgu.SelectedValue.ToString();
            ct.nhaXuatBan = xulyNXB.tim(manxb);
            ct.loaiSach = xulyLS.tim(maloai);
            ct.ngonNgu = xulyNN.tim(mangonngu);
            ct.maSach = txtMaSach.Text;
            ct.tenSach = txtTenSach.Text;
            ct.soLuongSach = txtSoLuongSach.Text;
            ct.gia = txtGia.Text;
            foreach (DataGridViewRow r in dgvTacGia1.Rows)
            {
                TacGia tg;
                tg = xulyTG.tim(r.Cells[0].Value?.ToString());
                ct.tacGia.Add(tg);
            }
            xulySach.sua(ct);

            hienthiDSSach(hdSach);
        }
    }
}
