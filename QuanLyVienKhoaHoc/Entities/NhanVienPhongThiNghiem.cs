using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhanVienPhongThiNghiem : NhanVien
    {
        public double LuongTrongThang { get; set; }

        public override void Nhap()
        {
            base.Nhap();

            //check valid
            Console.Write("Luong trong thang : ");
            LuongTrongThang = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine("Luong Trong Thang: {0}", LuongTrongThang);
        }
    }
}
