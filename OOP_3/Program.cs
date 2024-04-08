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

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        ILoggerService smsLoggerService =new SMSLoggerService();


        ApplicationManager applicationManager = new ApplicationManager();
        applicationManager.MakeApplication(autoCreditManager, new List<ILoggerService> { fileLoggerService, smsLoggerService });

        //List<ICreditManager> cusotmerOption1 = [helpingCrediManager, autoCreditManager];
        //List<ICreditManager> cusotmerOption2 = new () {helpingCrediManager, homeCreditManager, autoCreditManager };

        //Console.WriteLine("Müşteri 1 seçtiği listeler");
        //applicationManager.GiveCreditPreliminaryInformation(cusotmerOption1);

        //Console.WriteLine("Müşteri 2 seçtiği listeler");
        //applicationManager.GiveCreditPreliminaryInformation(cusotmerOption2);


        Console.ReadKey();
    }
}