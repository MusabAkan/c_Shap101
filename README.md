# c_Shap101

***Rek�rsif ve Extension Metotlar*** 

Extension ve Rek�rsif Metotlar
Extension(Geni�letilmi�) Metot Kullan�m�
Extension Metotlar�n kelime anlam� geni�letilebilir metotlard�r. C# 3.0 ile hayat�m�za giren, ayn� kodu defalarca yazmak yerine, bir kere yaz�p her yerden eri�ebilece�imiz kolay kullan�m� olan metotlard�r.

Extension metot yazarken dikkat etmemiz gereken bir ka� kural vard�r. �u �ekilde :

Static bir class i�erisinde static bir metot olarak yaz�lmal�lar.
Extension metod da tan�ml� parametrelerden sadece 1 tanesi this ile tan�mlanabilir.
K���k bir �rnek ile kullan�m�n� g�relim.

public static class MyExtensionClass {
    public static bool IsEventNumber(this int value) {
        if(value%2==0)
            return true;
        else
            return false;
    }
}
Yukar�daki �rnekte static class i�erisinde IsEventNumber ad�nda bir extension metot g�r�yoruz. Metodun kendisi de static keyword� ile tan�mland�. this keyword�n�n uyguland��� parametreye bakarsak, integer ver tipindeki de�i�kenlere uygulanabilir is extension metot oldu�unu g�r�yoruz. Say�s�n�n �ift olup olmamas� durumuna g�re de geriye bool bir de�er d�n�yor.

Extension metotlar�n kullan�m�n� oturtman�n en kolay yolu �ncelikle i�i yapacak olan metodu istenileni kar��layacak �ekilde yazmakt�r. Daha sonradan class ve metodu static yaparak ve geni�letilecek veri tipine ba�l� parametrenin ba��na this anahtar kelimesi ekleyerek kullanabilirsiniz.

Yukar�daki extension metodun �rnek kullan�m� ise �u �ekildedir.

int deger = 123; bool isEven = deger.IsEvenNumber();

Rek�rsif(Yinelemeli) Metot Kullan�m�
Rek�rsif metotlar ilk ��renildi�inde i�selle�tirilmesi ve kullan�lmas� zor metotlard�r. Ama yaz�l�m�n ilerleyen y�llar�nda kullan�m� oturur ve bir �ok soruna rek�rsif metotlar� kullanarak ��z�m getirebilirsiniz. O nedenle acele etmemek gerek :)

�ok s�k olmasa da bazen fonksiyonun kendi kendini �a��rmas�na ihtiya� duyar�z. For d�ng�s� karma��k bir kod yazarak da bu ihtiyac� kar��lamak m�mk�n. Rek�rsif fonksiyonlar ise tam da bu ihtiya� i�in ortaya koyulmu�tur.

Rek�rsif fonksiyon kendi kendini �a��rma yetene�ine sahip oldu�u i�in kullan�rken �ok dikkatli olmak gerek. En b�y�k sorunlardan biri sonsuz d�ng�ye neden olmal�. Bu da System.StackOverflowException olarak bilinen hataya neden olur. Yani belle�in stack b�lgesinde bu fonksiyon �a�r�m� i�in ayr�lan alan t�kenmi�tir. Yinelemeli olarak yapt���n�z i�e ba�l� olarak risk de artar.

A�a��daki �rne�i inceleyerek ve hatta ka��t �zerinde yazarak yinelemeli fonksiyonlar�n kullan�m�n� daha iyi oturtabilirsiniz.

static int FibonacciSerisi(int sayi)
{  
    if (sayi==0)
        return 0;
    elseif (sayi==1)
        return 1;
    else
        return FibonacciSerisi(sayi-1)+FibonacciSerisi(sayi-2);
}