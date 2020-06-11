using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Kubus : Ibangunruang
    {
        public int s;
        public void volume()
        {
            Console.WriteLine("masukan nilai sisi : ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Kubus   =  " + (s * s * s));
        }
       public void LuasPermukaan()
        {
            Console.WriteLine("Luas Permukaan Kubus   =  " + (6 * (s * s)));
        }
    }
}
