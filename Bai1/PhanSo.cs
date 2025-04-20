using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5.Models
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo() { TuSo = 0; MauSo = 1; }

        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau == 0 ? 1 : mau;
            RutGon();
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so (khac 0): ");
                MauSo = int.Parse(Console.ReadLine());
            } while (MauSo == 0);
            RutGon();
        }

        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            int tu = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mau = a.MauSo * b.MauSo;
            return new PhanSo(tu, mau);
        }

        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /= ucln;
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        public override string ToString()
        {
            if (MauSo == 1) return TuSo.ToString();
            return $"{TuSo}/{MauSo}";
        }
    }
}

