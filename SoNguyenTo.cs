using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2_Link2
{
    internal class SoNguyenTo
    {
        private int a;

        public SoNguyenTo()
        {
        }

        public SoNguyenTo(int x)
        {
            if (isSoNguyenTo(x))
            {
                this.a = x;
            }
            else
            {
                Console.WriteLine("X khong phai so nguyen to, khong luu tru!");
            }
        }

        public bool isSoNguyenTo(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (int i = 2; i < x / 2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }               
            }
            return true;
        }

        public int timSoNguyenToTiepTheo()
        {
            a++;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    a++;
                }                
            }
            return a;
        }
        
        public int A
        {
            get { return a; }
            set
            {
                if (isSoNguyenTo(a))
                {
                    a = value;
                }
                else
                {
                    Console.WriteLine("khong set!");
                }
            }
        }
        //static void Main(string[] args)
        //{
        //    SoNguyenTo s = new SoNguyenTo(23);
        //    s.isSoNguyenTo(3);
        //    Console.WriteLine("So NT tiep theo: {0}", s.timSoNguyenToTiepTheo());
        //}
    }
}
