using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Entities;

namespace QuanLyVienKhoaHoc
{
    class DanhSachNhanVien
    {
        List<NhanVien> danhSachs = new List<NhanVien>();

        /// <summary>
        /// Nhap danh sach nhan vien phong
        /// </summary>
        public void Nhap()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int soLuongNhanVien = int.Parse(Console.ReadLine());
            NhanVien nhanVien = null;
            for (int i = 0; i < soLuongNhanVien; i++)
            {
                Console.Write("Nhap nhan vien thu {0}: ", i + 1);
                int loaiNhanVien = -1;

                do
                {
                    Console.Write("1. NQL; 2. NKH; 3. NV PTN: ");
                    loaiNhanVien = int.Parse(Console.ReadLine());
                    switch (loaiNhanVien)
                    {
                        case 1:
                            nhanVien = new NhaQuanLy();
                            break;
                        case 2:
                            nhanVien = new NhaKhoaHoc();
                            break;
                        case 3:
                            nhanVien = new NhanVienPhongThiNghiem();
                            break;
                        default:
                            loaiNhanVien = -1;
                            break;
                    }

                    if (loaiNhanVien == -1)
                        Console.Write("Chon loai nhan vien!");

                } while (loaiNhanVien == -1);

                nhanVien.Nhap();
                danhSachs.Add(nhanVien);
            }
        }

        /// <summary>
        /// Xuat danh sach nhan vien phong
        /// </summary>
        public void Xuat()
        {
            foreach (NhanVien nhanVien in danhSachs)
            {
                Console.WriteLine("------------------");
                nhanVien.Xuat();
            }
        }

        /// <summary>
        /// Tinh tong luong chi tra cho moi doi tuong trong phong
        /// </summary>
        public void TinhLuongTheoDoiTuong()
        {

        }
    }
}
