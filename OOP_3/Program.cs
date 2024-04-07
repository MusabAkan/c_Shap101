using OOP_3;

internal class Program
{
    private static void Main(string[] args)
    {


        //ICreditManager helpingCrediManager = new HelpingCrediManager();
        //helpingCrediManager.Calculate();

        //ICreditManager autoCrediManager =  new AutoCrediManager();
        //autoCrediManager.Calculate();

        //ICreditManager homeCreditManager = new HomeCreditManager();
        //homeCreditManager.Calculate();

        ICreditManager helpingCrediManager = new HelpingCrediManager();
        ICreditManager autoCreditManager = new AutoCrediManager();
        ICreditManager homeCreditManager = new HomeCreditManager();
        
        ApplicationManager applicationManager = new ApplicationManager();
        //applicationManager.MakeApplication(helpingCrediManager);

        List<ICreditManager> cusotmerOption1 = new () {helpingCrediManager, autoCreditManager };
        List<ICreditManager> cusotmerOption2 = new () {helpingCrediManager, homeCreditManager, autoCreditManager };

        Console.WriteLine("Müşteri 1 seçtiği listeler");
        applicationManager.GiveCreditPreliminaryInformation(cusotmerOption1);

        Console.WriteLine("Müşteri 2 seçtiği listeler");
        applicationManager.GiveCreditPreliminaryInformation(cusotmerOption2);


        Console.ReadKey();
    }
}