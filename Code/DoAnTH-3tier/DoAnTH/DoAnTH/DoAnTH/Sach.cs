using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    [Serializable]
    class Sach
    {
        private string m_maSach;
        private string m_tenSach;
        private string m_soLuongSach;
        private string m_gia;
        private LoaiSach m_loaiSach;
        private NgonNgu m_ngonNgu;
        private List<TacGia> m_tacGia;
        private NhaXuatBan m_nhaXuatBan;

        public string tenNhaXuatBan
        {
            get { return m_nhaXuatBan.tenNhaXUatBan; }
        }
        public string maSach
        {
            get { return m_maSach; }
            set { m_maSach = value; }
        }
        public string tenSach
        {
            get { return m_tenSach; }
            set { m_tenSach = value; }
        }
        public string soLuongSach
        {
            get { return m_soLuongSach; }
            set { m_soLuongSach = value; }
        }
        public string gia
        {
            get { return m_gia; }
            set { m_gia = value; }
        }

        public LoaiSach loaiSach
        {
            get { return m_loaiSach; }
            set { m_loaiSach = value; }
        }

        public NgonNgu ngonNgu
        {
            get { return m_ngonNgu; }
            set { m_ngonNgu = value; }
        }
        public List<TacGia> tacGia
        {
            get { return m_tacGia; }
            set { m_tacGia = value; }
        }
        public NhaXuatBan nhaXuatBan
        {
            get { return m_nhaXuatBan; }
            set { m_nhaXuatBan = value; }
        }

        public Sach()
        {
            m_maSach = "";
            m_tenSach = "";
            m_soLuongSach = "";
            m_gia = "";
            m_loaiSach = new LoaiSach();
            m_ngonNgu = new NgonNgu();
            m_nhaXuatBan = new NhaXuatBan();
            m_tacGia = new List<TacGia>();
        }
        public Sach(string maSach,string tenSach, string soLuong,string gia,LoaiSach loaisach,NgonNgu ngonNgu, NhaXuatBan nhaXuatBan,List<TacGia> tacGia)
        {
            m_maSach = maSach;
            m_tenSach = tenSach;
            m_soLuongSach = soLuong;
            m_gia = gia;
            m_ngonNgu = ngonNgu;
            m_nhaXuatBan = nhaXuatBan;
            m_loaiSach = loaisach;
            m_tacGia = tacGia;

        }
    }
}
