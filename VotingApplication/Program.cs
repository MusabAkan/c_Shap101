internal class Program
{
    static Dictionary<int, string> categories = new()
    {
            {1, "Film Kategorileri"},
            {2, "Tech Stack Kategorileri"},
            {3, "Spor Kategorileri"}
        };

    static Dictionary<string, bool> registeredUsers = new();

    static Dictionary<int, int> categoryVotes = new();

    /*
        Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak üzere listelenmelidir. Yalnızca sisemde kayırlı olan kullanıcılar oy verebilir. Oylama sırasında öncelikle kullanıcının username'i istenmelidir. Eğer sistemde kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir. Kategoriler isteğe bağlı olarak belirlenebilir.

        Bazı Örnek Kategoriler: Film Kategorileri Tech Stack Kategorileri Spor Kategorileri
        Son olarak uygulama sonlandırılırken, Voting sonuçları hem rakamsal hem de yüzdesel olarak gösterilmelidir.
        Kullanılması gereken teknikler:
        Kategoriler pre-defined kullanılabilir.          
     */

    private static void Main(string[] args)
    {
        Console.WriteLine("Voting Uygulamasına Hoş Geldiniz!");

        while (true)
        {
            Console.Write("Lütfen kullanıcı adınızı girin:");
            string username = Console.ReadLine();

            if (!registeredUsers.ContainsKey(username))
            {
                Console.WriteLine("Yeni kullanıcı kaydedildi.");
                registeredUsers.Add(username, true);
            }

            Vote(username);

            Console.Write("Başka bir kullanıcı ile devam etmek ister misiniz? (E/H) ");
            string continueChoice = Console.ReadLine();

            if (continueChoice.ToLower() != "e")
                break;
        }

        ShowResults();

        Console.WriteLine("Uygulama sonlandırıldı. Çıkış yapmak için bir tuşa basın...");
        Console.ReadKey();
    }

    static void Vote(string username)
    {
        Console.WriteLine($"Merhaba, {username}!");

        Console.WriteLine("Kategoriler:");
        foreach (var category in categories)
        {
            Console.WriteLine($"{category.Key}. {category.Value}");
        }

        Console.WriteLine("Oy vermek istediğiniz kategorinin numarasını girin:");
        int categoryNumber = Convert.ToInt32(Console.ReadLine());

        if (!categories.ContainsKey(categoryNumber))
        {
            Console.WriteLine("Geçersiz kategori numarası! Lütfen tekrar deneyin.");
            return;
        }

        Console.WriteLine("Oy vermek istediğiniz oy sayısını girin (1-5 arası):");
        int vote = Convert.ToInt32(Console.ReadLine());

        if (vote < 1 || vote > 5)
        {
            Console.WriteLine("Geçersiz oy! Lütfen 1 ile 5 arasında bir oy girin.");
            return;
        }

        int categoryId = categoryNumber;
        if (categoryVotes.ContainsKey(categoryId))
            categoryVotes[categoryId] += vote;
        else
            categoryVotes.Add(categoryId, vote);

        Console.WriteLine("Oyunuz başarıyla kaydedildi.");
    }


    static void ShowResults()
    {
        Console.WriteLine("Voting Sonuçları:");

        foreach (var category in categories)
        {
            int categoryId = category.Key;
            string categoryName = category.Value;

            if (categoryVotes.ContainsKey(categoryId))
            {
                int totalVotes = categoryVotes[categoryId];
                double percentage = (totalVotes / 25.0) * 100; // 5 oy * toplam kullanıcı sayısı

                Console.WriteLine($"{categoryName}: Toplam Oy - {totalVotes}, Yüzde - {percentage}%");
            }
            else
            {
                Console.WriteLine($"{categoryName}: Henüz oy kullanılmadı.");
            }
        }
    }
}