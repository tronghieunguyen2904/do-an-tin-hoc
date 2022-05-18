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
    class CXuLyTacGia
    {
        private List<TacGia> dsTacGia;
        public CXuLyTacGia()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoitao();
            dsTacGia = data.getDsTacGia();
        }
        public List<TacGia> getDSTacGia()
        {
            return dsTacGia;
        }
        public TacGia tim(string maTacGia)
        {
            foreach (TacGia a in dsTacGia)
            {
                if (a.maTacGia == maTacGia) return a;
            }
            return null;
        }
        public bool them(TacGia a)
        {
            TacGia t = tim(a.maTacGia);
            if (t == null)
            {
                dsTacGia.Add(a);
                return true;
            }
            return false;
        }
        public bool xoa(string maTacGia)
        {
            TacGia t = tim(maTacGia);
            if (t != null)
            {
                dsTacGia.Remove(t);
                return true;
            }
            return false;
        }
        public bool sua(TacGia a)
        {
            TacGia t = tim(a.maTacGia);
            if (t == null) return false;
            t.maTacGia = a.maTacGia;
            t.tenTacGia = a.tenTacGia;
            t.soDienThoai = a.soDienThoai;
            t.email = a.email;
            return true;
        }
        //public bool ghiFile(string tenfile)
        //{
        //    try
        //    {
        //        FileStream f = new FileStream(tenfile, FileMode.Create);
        //        BinaryFormatter bf = new BinaryFormatter();
        //        bf.Serialize(f, dsTacGia);
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
        //        dsTacGia = bf.Deserialize(f) as List<TacGia>;
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
