using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    [Serializable]
    class TacGia
    {
        private string m_maTacGia;
        private string m_tenTacGia;
        private string m_soDienThoai;
        private string m_email;

        public string maTacGia
        {
            get { return m_maTacGia; }
            set { m_maTacGia = value; }
        }
        public string tenTacGia
        {
            get { return m_tenTacGia; }
            set { m_tenTacGia = value; }
        }
        public string soDienThoai
        {
            get { return m_soDienThoai; }
            set { m_soDienThoai = value; }
        }
        public string email
        {
            get { return m_email; }
            set { m_email = value; }
        }
        public TacGia()
        {
            m_tenTacGia = "";
            m_maTacGia = "";
            m_soDienThoai = "";
            m_email = "";
        }
        public TacGia(string maTacGia, string tenTacGia, string soDienThoai, string email)
        {
            m_maTacGia = maTacGia;
            m_tenTacGia = tenTacGia;
            m_soDienThoai = soDienThoai;
            m_email = email;
        }

        public static implicit operator List<object>(TacGia v)
        {
            throw new NotImplementedException();
        }
    }
}
