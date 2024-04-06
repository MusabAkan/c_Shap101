using OPP_1;

internal class Program
{
    private static void Main(string[] args)
    {
       Product product = new Product(); 
        product.Id =1;
        product.CategoryId = 2;
        product.ProductName = "Masa";
        product.UnitPrice = 500;
        product.UnitInStock = 3;


        Product product2 = new()
        {
            Id = 2,
            CategoryId = 3,
            UnitInStock = 4,
            ProductName = "Kalemr",
            UnitPrice = 35
        };

        //PascalCas //camelCase //casesentive
        ProductManager  productManager = new ();//intilazer yani örnek oluşturma
        //productManager.Add();
         
    }
}