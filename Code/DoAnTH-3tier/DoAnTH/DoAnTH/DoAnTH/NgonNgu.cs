using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    [Serializable]
    class NgonNgu
    {
        private string m_maNgonNgu;
        private string m_tenNgonNgu;

        public string maNgonNgu
        {
            get { return m_maNgonNgu; }
            set { m_maNgonNgu = value; }
        }
        public string tenNgonNgu
        {
            get { return m_tenNgonNgu; }
            set { m_tenNgonNgu = value; }
        }

        public NgonNgu()
        {
            m_maNgonNgu = "";
            m_tenNgonNgu = "";
        }
        public NgonNgu(string maNgonNgu, string tenNgonNgu)
        {
            m_maNgonNgu = maNgonNgu;
            m_tenNgonNgu = tenNgonNgu;
        }
    }
}
