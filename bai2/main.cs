using System;
using System.Collections.Generic;
using Lab2.Models;

namespace Lab2
{
    class main
    {
        static void Main(string[] args)
        {
            List<Hinh> danhSachHinh = new List<Hinh>();

            danhSachHinh.Add(new HinhTron(5));
            danhSachHinh.Add(new HinhVuong(4));
            danhSachHinh.Add(new HinhChuNhat(3, 6));
            danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

            double tongChuVi = 0;
            double tongDienTich = 0;

            foreach (var hinh in danhSachHinh)
            {
                tongChuVi += hinh.TinhChuVi();
                tongDienTich += hinh.TinhDienTich();
            }

            Console.WriteLine($"Tong chu vi: {tongChuVi:F2}");
            Console.WriteLine($"Tong dien tich: {tongDienTich:F2}");
        }
    }
}
