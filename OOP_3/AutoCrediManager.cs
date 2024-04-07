using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class AutoCrediManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredi ödeme planı hesaplandı");
        }

        public void CustomDoIt()
        {
            throw new NotImplementedException();
        }
    }
}
