using GameProject.Concrete;
using GameProject.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        GamerManager gamerManager = new (new UserValidationManager());

        gamerManager.Add(new Gamer {FirstName = "musab bilal", LastName = "akan", BirthYear = 1998, IdentityNumber = 18530270084 });

        Console.ReadLine();
    }
}