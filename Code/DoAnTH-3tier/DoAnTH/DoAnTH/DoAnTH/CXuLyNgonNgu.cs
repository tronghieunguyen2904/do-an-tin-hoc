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
    class CXuLyNgonNgu
    {
        private List<NgonNgu> dsNgonNgu;
        public CXuLyNgonNgu()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoitao();
            dsNgonNgu = data.getDsNgonNgu();
        }
        public List<NgonNgu> getDSNgonNgu()
        {
            return dsNgonNgu;
        }
        public NgonNgu tim(string maNgonNgu)
        {
            foreach (NgonNgu a in dsNgonNgu)
            {
                if (a.maNgonNgu == maNgonNgu) return a;
            }
            return null;
        }
        public bool them(NgonNgu a)
        {
            NgonNgu t = tim(a.maNgonNgu);
            if (t == null)
            {
                dsNgonNgu.Add(a);
                return true;
            }
            return false;
        }
        public bool xoa(string mamh)
        {
           NgonNgu t = tim(mamh);
            if (t != null)
            {
                dsNgonNgu.Remove(t);
                return true;
            }
            return false;
        }
        public bool sua(NgonNgu a)
        {
            NgonNgu t = tim(a.maNgonNgu);
            if (t == null) return false;
            t.maNgonNgu = a.maNgonNgu;
            t.tenNgonNgu = a.tenNgonNgu;
            return true;
        }
        //public bool ghiFile(string tenfile)
        //{
        //    try
        //    {
        //        FileStream f = new FileStream(tenfile, FileMode.Create);
        //        BinaryFormatter bf = new BinaryFormatter();
        //        bf.Serialize(f, dsNgonNgu);
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
        //        dsNgonNgu = bf.Deserialize(f) as List<NgonNgu>;
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
