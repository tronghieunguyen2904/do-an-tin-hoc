using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class ViewSach
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public string soLuong { get; set; }
        public string dongia { get; set; }
        public string maTacGia { get; set; }
        public string tenTacGia { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public string maNXB { get; set; }
        public string tenNXB { get; set; }
        public string diaChi { get; set; }
        public string soDienThoaiNXB { get; set; }
        public string emailNXB { get; set; }
        public string maLoai { get; set; }
        public string tenLoai { get; set; }
        public string soLuongLoai { get; set; }
        public string maNgonNgu { get; set; }
        public string tenNgonNgu { get; set; }
        public static List<ViewSach> chuyendoi(List<Sach> hdSach)
        {
            List<ViewSach> ds = new List<ViewSach>();

            foreach (Sach p in hdSach)
            {
                string tentg = "";
                foreach (TacGia t in p.tacGia)
                {
                    if (t != null)
                        tentg += (", " + t.tenTacGia);
                }
                ViewSach b = new ViewSach();
                b.maSach = p.maSach;
                b.tenSach = p.tenSach;
                b.soLuong = p.soLuongSach;
                b.dongia = p.gia;
                //b.maTacGia = null;
                b.tenTacGia = tentg;
                //b.soDienThoai = null;
                //b.email = null;
                b.maNXB = p.nhaXuatBan.maNhaXuatBan;
                b.tenNXB = p.nhaXuatBan.tenNhaXUatBan;
                b.diaChi = p.nhaXuatBan.diaChi;
                b.soDienThoaiNXB = p.nhaXuatBan.soDienThoaiNXB;
                b.emailNXB = p.nhaXuatBan.emailNXB;
                b.maLoai = p.loaiSach.maLoai;
                b.tenLoai = p.loaiSach.tenLoai;
                b.soLuongLoai = p.loaiSach.soLuongLoai;
                b.maNgonNgu = p.ngonNgu.maNgonNgu;
                b.tenNgonNgu = p.ngonNgu.tenNgonNgu;
                ds.Add(b);
            }
            
            return ds;
        }
    }
}
