using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien chuongTrinh = new DanhSachNhanVien();

            int luaChon = -1;
            do
            {
                Console.WriteLine("------------------");
                Console.WriteLine("1. Nhap Danh Sach");
                Console.WriteLine("2. Xuat Danh Sach");
                Console.WriteLine("3. Tinh Luong Theo Doi Tuong");
                Console.WriteLine("------------------");

                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        chuongTrinh.Nhap();
                        break;
                    case 2:
                        chuongTrinh.Xuat();
                        break;
                    case 3:
                        chuongTrinh.TinhLuongTheoDoiTuong();
                        break;
                    default:
                        luaChon = -1;
                        break;
                }
            } while (luaChon != -1);

            //Dung chuong trinh de xem ket qua
            Console.ReadLine();
        }
    }
}
