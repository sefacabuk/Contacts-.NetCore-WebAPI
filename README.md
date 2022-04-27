# Contacts-.NetCore-WebAPI
Proje Amacı: Telefon Rehberi Oluşturmadır.
Projeyi çalıştırmadan önce uygulanması gereken konfigürasyonlar;
1- Visual Studio .net core 5 paketiniz olması gereklidir.
2- Contacts.DataAccess katmanını statrup project olarak seçiniz.
3- ContactsDbContext.cs dosyasında sql server bilgilerinizi düzenleyiniz
    optionsBuilder.UseSqlServer("Server=ServerAdiniz; Database=ContactsDb;uid=ServerKullaniciAdiniz;password=ServerKullaniciSifreniz");
4- Package Manager Console alanına;
    update-database
    Komutunu yazıp çalıştırınız ve tamamlanmasını bekleyiniz.
5- Contacts.API katmanını tekrar startup project olarak ayarlayınız.
6- Projeyi Çalışır duruma getirip ContactsWebUI projesinden işlemlere devam edebilirsiniz.
7- ContactsWebUI Api ile haberleşmediği durumda;
    Proje içerisindeki BusinessLogicLayer Klasorü altında Sabitler.cs dosyası içindeki ApiLink'i kontrol ediniz. 
    Contacts.API'nin çalıştığı port ile güncelleyiniz.
