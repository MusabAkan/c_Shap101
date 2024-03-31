using TelephoneDirectory;

internal class Program
{


    private static void Main(string[] args)
    {
        MobilePhoneBook mobilePhoneBook = new();

        again:
        Console.Clear();
        Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :)\n******************************************* \n(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak﻿");
        string preference = Console.ReadLine();
        //mobilePhoneBook.GetDirectory();
        switch (preference)
        {
            case "1":
                mobilePhoneBook.AddPhoneBook();
                break;
            case "2":
                mobilePhoneBook.RemovePhoneBook();
                break;
            case "3":
                mobilePhoneBook.AddPhoneBook();
                break;
            case "4":
                mobilePhoneBook.GetPhones();
                break;

            case "5":
                mobilePhoneBook.AddPhoneBook();
                break;
            default:               
                goto again;
        }
        goto again;
    }
}