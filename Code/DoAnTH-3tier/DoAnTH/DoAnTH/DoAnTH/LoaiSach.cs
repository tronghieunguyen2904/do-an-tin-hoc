using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    [Serializable]
    class LoaiSach
    {
        private string m_maLoai;
        private string m_tenLoai;
        private string m_soLuong;

        public string maLoai
        {
            get { return m_maLoai; }
            set { m_maLoai = value; }
        }
        public string tenLoai
        {
            get { return m_tenLoai; }
            set { m_tenLoai = value; }
        }
        public string soLuongLoai
        {
            get { return m_soLuong; }
            set { m_soLuong = value; }
        }

        public LoaiSach()
        {
            m_maLoai = "";
            m_tenLoai = "";
            m_soLuong = "";
        }

        public LoaiSach(string maLoai, string tenLoai, string soLuong)
        {
            m_maLoai = maLoai;
            m_tenLoai = tenLoai;
            m_soLuong = soLuong;
        }
    }
}
