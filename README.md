# c_Shap101

***Rekürsif ve Extension Metotlar*** 

Extension ve Rekürsif Metotlar
Extension(Geniþletilmiþ) Metot Kullanýmý
Extension Metotlarýn kelime anlamý geniþletilebilir metotlardýr. C# 3.0 ile hayatýmýza giren, ayný kodu defalarca yazmak yerine, bir kere yazýp her yerden eriþebileceðimiz kolay kullanýmý olan metotlardýr.

Extension metot yazarken dikkat etmemiz gereken bir kaç kural vardýr. Þu þekilde :

Static bir class içerisinde static bir metot olarak yazýlmalýlar.
Extension metod da tanýmlý parametrelerden sadece 1 tanesi this ile tanýmlanabilir.
Küçük bir örnek ile kullanýmýný görelim.

public static class MyExtensionClass {
    public static bool IsEventNumber(this int value) {
        if(value%2==0)
            return true;
        else
            return false;
    }
}
Yukarýdaki örnekte static class içerisinde IsEventNumber adýnda bir extension metot görüyoruz. Metodun kendisi de static keywordü ile tanýmlandý. this keywordünün uygulandýðý parametreye bakarsak, integer ver tipindeki deðiþkenlere uygulanabilir is extension metot olduðunu görüyoruz. Sayýsýnýn çift olup olmamasý durumuna göre de geriye bool bir deðer dönüyor.

Extension metotlarýn kullanýmýný oturtmanýn en kolay yolu öncelikle iþi yapacak olan metodu istenileni karþýlayacak þekilde yazmaktýr. Daha sonradan class ve metodu static yaparak ve geniþletilecek veri tipine baðlý parametrenin baþýna this anahtar kelimesi ekleyerek kullanabilirsiniz.

Yukarýdaki extension metodun örnek kullanýmý ise þu þekildedir.

int deger = 123; bool isEven = deger.IsEvenNumber();

Rekürsif(Yinelemeli) Metot Kullanýmý
Rekürsif metotlar ilk öðrenildiðinde içselleþtirilmesi ve kullanýlmasý zor metotlardýr. Ama yazýlýmýn ilerleyen yýllarýnda kullanýmý oturur ve bir çok soruna rekürsif metotlarý kullanarak çözüm getirebilirsiniz. O nedenle acele etmemek gerek :)

Çok sýk olmasa da bazen fonksiyonun kendi kendini çaðýrmasýna ihtiyaç duyarýz. For döngüsü karmaþýk bir kod yazarak da bu ihtiyacý karþýlamak mümkün. Rekürsif fonksiyonlar ise tam da bu ihtiyaç için ortaya koyulmuþtur.

Rekürsif fonksiyon kendi kendini çaðýrma yeteneðine sahip olduðu için kullanýrken çok dikkatli olmak gerek. En büyük sorunlardan biri sonsuz döngüye neden olmalý. Bu da System.StackOverflowException olarak bilinen hataya neden olur. Yani belleðin stack bölgesinde bu fonksiyon çaðrýmý için ayrýlan alan tükenmiþtir. Yinelemeli olarak yaptýðýnýz iþe baðlý olarak risk de artar.

Aþaðýdaki örneði inceleyerek ve hatta kaðýt üzerinde yazarak yinelemeli fonksiyonlarýn kullanýmýný daha iyi oturtabilirsiniz.

static int FibonacciSerisi(int sayi)
{  
    if (sayi==0)
        return 0;
    elseif (sayi==1)
        return 1;
    else
        return FibonacciSerisi(sayi-1)+FibonacciSerisi(sayi-2);
}

Koleksiyon(Collections) Nedir ?


Klasik programlama dillerinde array yani diziler çok önemli veri tipleridir. Birçok problemimizi diziler yardýmýyla çözebiliriz ama bazý handikaplarý nedeniyle birçok sorun karþýsýnda da yetersiz kalýrlar.Bu sorunlarý þöyle sýralayabiliriz:



Array'in elemanlarý ayný veri tipinde olmalýdýr.
Array'in boyutu önceden belirlenmelidir.


Oysa programlama dillerinde farklý türlerde verileri saklamaya ihtiyaç duyarýz. Ve çoðu zaman ne kadar veri saklayacaðýmýz program akýþýnda belli olabilir. Koleksiyonlar tam da bu sorunlarý çözmek için dizilerin handikaplarýndan yaratýlmýþtýr.



Dizilerin aksine koleksiyonlarýn bazý tipleri; üzerinde çalýþtýklarý makinaýn RAM'i yettiði sürece geniþleyebilirler ve farklý türlerde veri tiplerini saklayabilirler.

Koleksiyonlarýn elemanlarý object tipindedir. Hatýrlayacak olursak öðrendiðimiz veri tipleri için object sýnýfýndan türediklerini söylemiþtik. Yani bu bir sorun deðil, her türlü veriyi koleksiyonlar içerisinde saklayabiliriz.



Koleksiyonlar System.Collections namespace i yani isim uzayý altýnda bulunurlar. Yani bir koleksiyon tipini kullanmak istiyorsanýz System.Collections'ý using direktifi ile programýnýza import ediyor olmanýz gerekiyor.



Peki bu Koleksiyonlar'ýn hiç dezavantajý yok mu? Olmaz olur mu tabiki var. Gelin yakýndan bakalým.



Dezavantajlarý


.NEt platformda kullanýdýðýmýz veri tipleri 2'ye ayrýlýr. Deðer ve referans veri tipleridir. Deðer tipleri belliðin stack bölgesinde tutulurken, Referans tipleri belleðin heap bölgesinde tutulur.



Deðer Tipleri: int, long, float, double, decimal, char, bool, byte, short, struct, enum


Referans Tipleri: string, object, class, interface, array, delegate, pointer




Bir deðer tipinin referans tipine dönüþtürülme boxing, tam tersine unboxing iþlemi denir.

Koleksiyonlar verilerini object tipinde tutuyor demiþtik. Object de bir referans tipi. Bu demek oluyor ki deðer tipinde bir veriyi koleksiyona eklemek istediðimde bir boxing iþlemi yapýyorum. Daha sonra elemaný okumak istediðimde de unboxing iþlemi yapýyorum. Boxing ve unboxing iþlemleri bilgisayar açýsýndan maliyetli bir iþlemdir. Koleksiyon içerisindeki eleman sayýsýnýn artýþýna baðlý olarak bu boxing ve unboxing iþlemlerinin sayýsý artacaktýr. Buna baðlý olarakta uygulamanýn performansý olumsuz yönde etkilenecektir.



NOT: Boxing ve unboxing iþlemlerinin performansa etkisine detaylý bakmak için þu makaleyi okumanýzý öneririm:

https://www.buraksenyurt.com/post/Boxing-ve-Unboxing-Performans-Kritigi-bsenyurt-com-dan