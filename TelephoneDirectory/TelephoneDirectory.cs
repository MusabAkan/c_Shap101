namespace TelephoneDirectory
{
    public class MobilePhoneBook
    {
        public MobilePhoneBook()
        {
            _phones.Add(new() { Id = Guid.Parse("c9fc263a-18ce-48c4-b78d-c61ead7ba4fa"), Name = "Musab", Surname = "AKAN", Number = "+90 0(553) 123 12 12" });
            _phones.Add(new() { Id = Guid.Parse("e460cb3a-58a3-4163-9602-2473e1eecfc3"), Name = "Mert", Surname = "KEÇİ", Number = "+90 0(553) 343 23 12" });
            _phones.Add(new() { Id = Guid.Parse("b9f72930-a6ea-45de-89ca-34288bb88bf0"), Name = "Yasin", Surname = "ÇAN", Number = "+90 0(553) 234 45 34" });
            _phones.Add(new() { Id = Guid.Parse("c742c388-d3a3-451d-8fd4-6908ae0d8507"), Name = "Deniz", Surname = "TEKİN", Number = "+90 0(553) 235 55 44" });
            _phones.Add(new() { Id = Guid.Parse("5ca318db-07f2-4db2-b3ab-b774097508f8"), Name = "Merih", Surname = "DEMİRAL", Number = "+90 0(553) 676 33 33" });
        }

        private readonly List<Phone> _phones = new();

        internal void GetPhones()
        {
            foreach (var phone in _phones)
                Console.WriteLine($"Id : {phone.Id}, Ad Soyad : {phone.FullName}, Cep No : {phone.Number}");
            Console.ReadKey();
        }

        internal void RemovePhoneBook()
        {
        again:
            Console.Clear();
            Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin ID'si?");
            string id = Console.ReadLine();
            if (Guid.TryParse(id, out Guid guidId))
            {
                var result = _phones.FirstOrDefault(i => i.Id == guidId);
                if (result is not null)
                {
                    Console.Write($"{result.FullName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y / n) : ");
                    string select = Console.ReadLine();

                    if (select.ToUpper() == "Y")
                    {
                        _phones.Remove(result);
                        return;
                    }
                    else
                        return;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n  * Silmeyi sonlandırmak için : (1)\r\n  * Yeniden denemek için      : (2)");

                    string select = Console.ReadLine();

                    if (select.Equals("1"))
                        return;
                    else
                        goto again;
                }
            }
            goto again;
        }

        internal void AddPhoneBook()
        {
        again:
            Console.WriteLine("Lütfen isim giriniz : ");
            string name = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz :");
            string surname = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz");
            string phone = Console.ReadLine();

            if (name.Trim() == string.Empty &&
                surname.Trim() == string.Empty &&
                phone.Trim() == string.Empty)
                goto again;

            _phones.Add(new Phone { Id = Guid.NewGuid(), Name = name, Surname = surname, Number = phone });


        }




        private class Phone
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Number { get; set; }

            public string FullName { get { return Name + " " + Surname; } }
        }
    }

}
