using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enums;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhaQuanLy : NhanVien
    {
        public ChucVu ChucVu { get; set; }

        public int SoNgayCong { get; set; }

        public float BacLuong { get; set; }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Chuc vu: 1. Truong Phong; 2. Pho Phong; 3. Thu Ky:");
            ChucVu = (ChucVu)int.Parse(Console.ReadLine());

            Console.Write("So Ngay Cong : ");
            SoNgayCong = int.Parse(Console.ReadLine());

            Console.Write("Bac Luong : ");
            BacLuong = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine("Chuc Vu: {0}", ChucVu);
            Console.WriteLine("So Ngay Cong: {0}", SoNgayCong);
            Console.WriteLine("Bac Luong: {0}", BacLuong);
        }

    }
}
