using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class CXuLySach
    {
        private List<Sach> dssach;

        public CXuLySach()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoitao();
            dssach = data.getDSSach();
        }

        public List<Sach> getDSSach()
        {
            return dssach;
        }

        public Sach tim(string masach)
        {
            foreach (Sach a in dssach)
            {
                if (a.maSach == masach)
                {
                    return a;
                }
            }
            return null;
        }

        public bool them(Sach x)
        {
            Sach t = tim(x.maSach);
            if (t == null)
            {
                dssach.Add(x);
                return true;
            }
            return false;
        }

        public bool xoa(string masach)
        {
            Sach t = tim(masach);
            if (t != null)
            {
                dssach.Remove(t);
                return true;
            }
            return false;
        }
        public bool sua(Sach x)
        {
            Sach t = tim(x.maSach);
            if(t!=null)
            {
                t.maSach = x.maSach;
                t.tenSach = x.tenSach;
                t.soLuongSach=x.soLuongSach;
                t.gia=x.gia;
                t.ngonNgu = x.ngonNgu;
                t.loaiSach=x.loaiSach;
                t.nhaXuatBan = x.nhaXuatBan;
                t.tacGia= x.tacGia;
                return true;
            }
            return false;
        }
    }
}
