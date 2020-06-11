using Abstrastion.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Balok : bangunruang
    {
        public int p,l,t;
        public override void Volume()
        {
            Console.WriteLine("masukan nilai Panjang : ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan nilai Lebar : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan nilai Tinggi : ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Balok   =  " + (p*l*t));

        }
        public override void LuasPermukaan()
        {
            Console.WriteLine("Luas Permukaan Balok  =  " + (2*(p*l+p*t+l*t)));
        }
    }
}
