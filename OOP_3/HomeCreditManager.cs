using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class HomeCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ev kredi ödeme planı hesaplandı");
        }

        public void CustomDoIt()
        {
            throw new NotImplementedException();
        }
    }
}
