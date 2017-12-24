using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enums;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhanVien
    {
        //HoTen, NamSinh, BangCap
        public string HoTen { get; set; }

        public DateTime NamSinh { get; set; }

        //Ky su, KySu
        public BangCap BangCap { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Ho Ten: ");
            HoTen = Console.ReadLine();

            //check valid
            Console.Write("Nam Sinh: ");
            NamSinh = DateTime.Parse(Console.ReadLine());

            Console.Write("Bang cap: 1. Ky Su; 2. Thac Si; 3. Tien Si; 4. Giao Su ");
            BangCap = (BangCap)int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ho Ten: {0}", HoTen);
            Console.WriteLine("Nam Sinh: {0}" , NamSinh);
            Console.WriteLine("Bang cap: {0}", BangCap);
        }

    }
}
