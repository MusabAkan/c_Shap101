namespace Interfaces
{
    //dal => Dataccess'den gelen veri işlemleri yaptığımız yerdir (kısaca : veritabanı işlemleri)
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }
}
