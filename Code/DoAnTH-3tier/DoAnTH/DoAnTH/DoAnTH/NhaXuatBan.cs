using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    [Serializable]
    class NhaXuatBan
    {
        private string m_maNhaXuatBan;
        private string m_tenNhaXuatBan;
        private string m_diaChi;
        private string m_soDienThoai;
        private string m_email;

        public string maNhaXuatBan
        {
            get { return m_maNhaXuatBan; }
            set { m_maNhaXuatBan = value; }
        }
        public string tenNhaXUatBan
        {
            get { return m_tenNhaXuatBan; }
            set { m_tenNhaXuatBan = value; }
        }
        public string diaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }
        public string soDienThoaiNXB
        {
            get { return m_soDienThoai; }
            set { m_soDienThoai = value; }
        }
        public string emailNXB
        {
            get { return m_email; }
            set { m_email = value; }
        }
        public NhaXuatBan()
        {
            m_maNhaXuatBan = "";
            m_tenNhaXuatBan = "";
            m_diaChi = "";
            m_soDienThoai = "";
            m_email = "";
        }
        public NhaXuatBan(string maNhaXuatBan, string tenNhaXuatBan, string diaChi, string soDienThoai, string email)
        {
            m_maNhaXuatBan = maNhaXuatBan;
            m_tenNhaXuatBan = tenNhaXuatBan;
            m_diaChi = diaChi;
            m_soDienThoai = soDienThoai;
            m_email = email;
        }
    }
}
