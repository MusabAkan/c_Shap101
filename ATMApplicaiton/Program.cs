 

class User
{
    public string Username { get; set; }
    public string Pin { get; set; }
    public decimal Balance { get; set; }
}

class Program
{
    static Dictionary<string, User> users = new () {
        { "user1", new User { Username = "user1", Pin = "1234", Balance = 1000 } },
        { "user2", new User { Username = "user2", Pin = "5678", Balance = 1500 } }
    };

    static List<string> operations = new List<string> {
        "Para Çekme", "Para Yatırma", "Bakiye Sorgulama", "Gün Sonu"
    };

    static void Main(string[] args)
    {
        Console.WriteLine("ATM'ye hoş geldiniz!");
        string username = Login();
        if (username != null)
        {
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
                for (int i = 0; i < operations.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {operations[i]}");
                }
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Withdraw(username);
                            break;
                        case 2:
                            Deposit(username);
                            break;
                        case 3:
                            CheckBalance(username);
                            break;
                        case 4:
                            EndOfDay();
                            return;
                        default:
                            Console.WriteLine("Geçersiz işlem seçimi!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem seçimi!");
                }
            }
        }
    }

    static string Login()
    {
        Console.Write("Kullanıcı adınızı girin: ");
        string username = Console.ReadLine();
        Console.Write("PIN kodunuzu girin: ");
        string pin = Console.ReadLine();
        if (users.ContainsKey(username) && users[username].Pin == pin)
        {
            return username;
        }
        else
        {
            Console.WriteLine("Hatalı kullanıcı adı veya PIN!");
            return null;
        }
    }

    static void Withdraw(string username)
    {
        Console.Write("Çekmek istediğiniz miktarı girin: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            if (amount <= users[username].Balance)
            {
                users[username].Balance -= amount;
                Console.WriteLine("Para çekme işlemi başarılı.");
                Console.WriteLine("Güncel bakiyeniz: " + users[username].Balance);
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz miktar!");
        }
    }

    static void Deposit(string username)
    {
        Console.Write("Yatırmak istediğiniz miktarı girin: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            users[username].Balance += amount;
            Console.WriteLine("Para yatırma işlemi başarılı.");
            Console.WriteLine("Güncel bakiyeniz: " + users[username].Balance);
        }
        else
        {
            Console.WriteLine("Geçersiz miktar!");
        }
    }

    static void CheckBalance(string username)
    {
        Console.WriteLine("Güncel bakiyeniz: " + users[username].Balance);
    }

    static void EndOfDay()
    {
        string eodDate = DateTime.Now.ToString("ddMMyyyy");
        string logFilePath = "EOD_" + eodDate + ".txt";
        using (StreamWriter writer = new(logFilePath))
        {
            // Gün sonu raporu oluşturma işlemleri buraya gelecek
            writer.WriteLine("Gün sonu raporu");
            writer.WriteLine("Transaction logları");
            writer.WriteLine("Hatalı giriş denemeleri logları");
        }
        Console.WriteLine("Gün sonu raporu başarıyla oluşturuldu: " + logFilePath);
    }
}

 