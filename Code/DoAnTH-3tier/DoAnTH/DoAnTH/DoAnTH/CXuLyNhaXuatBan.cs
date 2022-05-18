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
    class CXuLyNhaXuatBan
    {
        private List<NhaXuatBan> dsNhaXuatBan;
        public CXuLyNhaXuatBan()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoitao();
            dsNhaXuatBan= data.getDsNhaXuatBan();
        }
        public List<NhaXuatBan> getDSNhaXuatBan()
        {
            return dsNhaXuatBan;
        }
        public NhaXuatBan tim(string maNhaXuatBan)
        {
            foreach (NhaXuatBan a in dsNhaXuatBan)
            {
                if (a.maNhaXuatBan == maNhaXuatBan) return a;
            }
            return null;
        }
        public bool them(NhaXuatBan a)
        {
            NhaXuatBan t = tim(a.maNhaXuatBan);
            if (t == null)
            {
                dsNhaXuatBan.Add(a);
                return true;
            }
            return false;
        }
        public bool xoa(string maNhaXuatBan)
        {
            NhaXuatBan t = tim(maNhaXuatBan);
            if (t != null)
            {
               dsNhaXuatBan.Remove(t);
                return true;
            }
            return false;
        }
        public bool sua(NhaXuatBan a)
        {
            NhaXuatBan t = tim(a.maNhaXuatBan);
            if (t == null) return false;
            t.maNhaXuatBan = a.maNhaXuatBan;
            t.tenNhaXUatBan = a.tenNhaXUatBan;
            t.soDienThoaiNXB = a.soDienThoaiNXB;
            t.emailNXB = a.emailNXB;
            t.diaChi = a.diaChi;
            return true;
        }
        //public bool ghiFile(string tenfile)
        //{
        //    try
        //    {
        //        FileStream f = new FileStream(tenfile, FileMode.Create);
        //        BinaryFormatter bf = new BinaryFormatter();
        //        bf.Serialize(f, dsNhaXuatBan);
        //        f.Close();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        //public bool docFile(string tenfile)
        //{
        //    try
        //    {
        //        FileStream f = new FileStream(tenfile, FileMode.Open);
        //        BinaryFormatter bf = new BinaryFormatter();
        //        dsNhaXuatBan = bf.Deserialize(f) as List<NhaXuatBan>;
        //        f.Close();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}
