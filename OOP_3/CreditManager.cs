using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    //imzanın aynı olduğu içeriklerin farklığı aslında şablon görevi olarak görüyor
    //interface genellikle I harfi ile başlar 

    //interfacelarde o interfave implente eden class'ı referans numrasınıs tutabiliyor

    internal interface ICreditManager
    {
        void Calculate();
        void CustomDoIt();
    }
}
