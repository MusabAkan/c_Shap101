using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class ApplicationManager
    {
        public void MakeApplication(ICreditManager manager)
        {
            //başvuru bilgilerini değerlendirme
            /*
            HomeCreditManager homeCreditManager = new HomeCreditManager();
            homeCreditManager.Calculate ();
            */
            //design patern kırılma noktası burası çünkü böyle yazarsan katmanları bağımlı hale getirsin bu  doğru bir şey değil. Bu yüzden ; 
            //bellekte ihtiyaç kredi çalışır
            manager.Calculate();

        }

        public void GiveCreditPreliminaryInformation(List<ICreditManager> managers)
        {
            foreach (ICreditManager manager in managers)
                manager.Calculate ();
        }
    }
}
