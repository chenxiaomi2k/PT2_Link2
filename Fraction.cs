using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2_Link2
{
    internal class Fraction
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public Fraction()
        {
        }

        public Fraction(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }

        public void nhapPhanSo()
        {
            Console.Write("Nhap tu so: ");
            this.TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            this.MauSo = int.Parse(Console.ReadLine());
        }

        public void inPhanSo()
        {
            Console.WriteLine("Phan so cua ban la {0}/{1}", TuSo, MauSo);
        }

        public void rutGonPhanSo(int tu, int mau)
        {
            int uoc = 0;
            if (tu > mau)
            {
                for (int i = 1; i <= mau; i++)
                {
                    if (tu % i == 0 && mau % i == 0)
                    {
                        uoc = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= tu; i++)
                {
                    if (tu % i == 0 && mau % i == 0)
                    {
                        uoc = i;
                    }
                }
            }
            if (uoc != 0)
            {
                this.TuSo = TuSo / uoc;
                this.MauSo = MauSo / uoc;
            }
            else
            {
                this.TuSo = TuSo;
                this.MauSo = MauSo;
            }
        }

        public void nghichDaoPhanSo()
        {
            if (TuSo / MauSo != 0)
            {
                int temp = TuSo;
                TuSo = MauSo;
                MauSo = temp;
            }
        }

        public void add(int a, int b)
        {
            this.TuSo = a * MauSo + b * TuSo;
            this.MauSo = b * MauSo;
        }

        public void sub(int a, int b)
        {
            this.TuSo = a * MauSo - b * TuSo;
            this.MauSo = b * MauSo;
        }

        public void mul(int a, int b)
        {
            this.TuSo = a * TuSo;
            this.MauSo = b * MauSo;
        }

        public void div(int a, int b)
        {
            this.TuSo = a * MauSo;
            this.MauSo = b * TuSo;
        }
    }
}
