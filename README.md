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