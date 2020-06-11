
using Abstrastion.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Kubus : bangunruang
    {
        public int s;
        public override void volume()
        {
            Console.WriteLine("masukan nilai sisi : ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Kubus   =  " + (s*s*s));
        }
        public override void LuasPermukaan()
        {
            Console.WriteLine("Luas Permuaan Kubus   =  " + (6*(s*s)));
        }
    }
}
