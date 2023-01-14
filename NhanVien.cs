using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2_Link2
{
    internal class NhanVien
    {
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public double Luong { get; set; }
        public int SoGioLam { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(string ten, int tuoi, string diaChi, double luong, int soGioLam)
        {
            Ten = ten;
            Tuoi = tuoi;
            DiaChi = diaChi;
            Luong = luong;
            SoGioLam = soGioLam;
        }

        public void inputInfo()
        {
            Console.Write("Nhap ten nhan vien: ");
            this.Ten = Console.ReadLine();
            Console.Write("Nhap tuoi nhan vien: ");
            this.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap tien luong: ");
            this.Luong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so gio lam: ");
            this.SoGioLam = int.Parse(Console.ReadLine());
        }

        public void printInfo()
        {
            Console.WriteLine("Ten nhan vien: {0}", this.Ten);
            Console.WriteLine("Ten nhan vien: {0}", this.Tuoi);
            Console.WriteLine("Ten nhan vien: {0}", this.Luong);
            Console.WriteLine("Ten nhan vien: {0}", this.SoGioLam);
        }

        public double tinhThuong()
        {
            if (SoGioLam >= 200)
            {
                return Luong * 0.2;
            }
            else if (SoGioLam < 200 && SoGioLam >= 100)
            {
                return Luong * 0.1;
            }
            else
            {
                return Luong;
            }
        }
    }
}
