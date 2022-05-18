using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DoAnTH
{
    [Serializable]
    class CTruyCapDuLieu
    {
        private static CTruyCapDuLieu m_data = null;
        private List<LoaiSach> m_dsLoaiSach;
        private List<NgonNgu> m_dsNgonNgu;
        private List<NhaXuatBan> m_dsNhaXuatBan;
        private List<TacGia> m_dsTacGia;
        private List<Sach> m_dsSach;

        private CTruyCapDuLieu()
        {
            m_dsLoaiSach = new List<LoaiSach>();
            m_dsNgonNgu = new List<NgonNgu>();
            m_dsNhaXuatBan = new List<NhaXuatBan>();
            m_dsTacGia = new List<TacGia>();
            m_dsSach = new List<Sach>();
        }

        public static CTruyCapDuLieu khoitao()
        {
            if (m_data == null) m_data = new CTruyCapDuLieu();
            return m_data;
        }

        public List<LoaiSach> getDsLoaiSach()
        {
            return m_dsLoaiSach;
        }
        public List<NgonNgu> getDsNgonNgu()
        {
            return m_dsNgonNgu;
        }
        public List<NhaXuatBan> getDsNhaXuatBan()
        {
            return m_dsNhaXuatBan;
        }
        public List<TacGia> getDsTacGia()
        {
            return m_dsTacGia;
        }
        public List<Sach> getDSSach()
        {
            return m_dsSach;
        }
        public bool ghiFile(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, m_data);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool docFile(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_data = bf.Deserialize(f) as CTruyCapDuLieu;
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
