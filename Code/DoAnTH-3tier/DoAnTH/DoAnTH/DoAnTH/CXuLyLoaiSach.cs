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
    class CXuLyLoaiSach
    {
        private List<LoaiSach> dsLoai;

        public CXuLyLoaiSach()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoitao();
            dsLoai = data.getDsLoaiSach();
        }
        public List<LoaiSach> getDSLoaiSach()
        {
            return dsLoai;
        }
        public LoaiSach tim(string maLoai)
        {
            foreach(LoaiSach a in dsLoai)
            {
                if (a.maLoai == maLoai) return a;
            }
            return null;
        }
        public bool them(LoaiSach a)
        {
            LoaiSach t = tim(a.maLoai);
            if(t == null)
            {
                dsLoai.Add(a);
                return true;
            }
            return false;
        }
        public bool xoa(string mamh)
        {
            LoaiSach t = tim(mamh);
            if (t != null)
            {
                dsLoai.Remove(t);
                return true;
            }
            return false;
        }
        public bool sua(LoaiSach a)
        {
            LoaiSach t = tim(a.maLoai);
            if (t == null) return false;
            t.tenLoai = a.tenLoai;
            t.soLuongLoai = a.soLuongLoai;
            return true;
        }
        
    }
}
