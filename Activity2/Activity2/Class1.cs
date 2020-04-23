using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    class Class1
    {
        static void Main(string[] args)
        {

            Program.inputdata input = new Program.inputdata();
            input.inputPanjang();
            double lebar = input.inputLebar();

            Program h = new hitungLuas();
            Console.WriteLine("luas lingkaran= {0}", h.Luas(input.p, lebar));

            Program.hitungkeliling hk = new Program.hitungkeliling();
            Console.WriteLine("luas lingkaran= {0}", hk.keliling(input.p, lebar));

            Console.ReadLine();
        }
    }

    internal class hitungLuas : Program
    {
    }
}
