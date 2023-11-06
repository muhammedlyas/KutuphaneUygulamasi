# KutuphaneUygulamasi
Kullanıcı girişi yapıldıktan sonra kütüphanedeki kitapların takibi ve ödünç verilmesi için bir ASP.NET Core MVC uygulamasıdır.

## Özellikler

Uygulamada aşağıdaki özellikler bulunmaktadır:

- Kullanıcılar, kitap ödünç almak istediklerinde adlarını ve soyadlarını girebilirler. Ayrıca geri getirme tarihini belirleyebilirler. Kitabın geri getirme tarihi geçtikten sonra, kitap otomatik olarak kütüphaneye geri eklenir.

- Kullanıcılar, yeni kitapları kütüphaneye eklemek için kitap ekleme bölümünü kullanabilirler. Kitap adı, yazarı ve resmi yüklenerek kütüphaneye yeni kitaplar eklenebilir.

- Projeye gelecekte daha fazla özellik ve geliştirmeler eklenecektir.

## Ekran görüntüleri

<img width="798" alt="Ekran görüntüsü 2023-11-06 200243" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/f95b7837-05ef-41c6-8586-31d1f01404a2">


<img width="795" alt="Ekran görüntüsü 2023-11-06 200429" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/f00595f9-512a-4fad-9e7f-b93488cf837a">

<img width="793" alt="Ekran görüntüsü 2023-11-06 213533" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/8062997e-ca4e-49be-ae2b-2d9f3691d45a">

<img width="798" alt="Ekran görüntüsü 2023-11-06 213632" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/ff43b865-e351-40c2-a19d-88f93eb95d46">

<img width="797" alt="Ekran görüntüsü 2023-11-06 213658" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/dc77fba5-57a1-49f5-acf6-a0a49fe1c93b">

## Kurulum

Proje yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1. Projeyi klonlayın.
2. Gerekli nuGet paketlerini yükleyin: Microsoft.EntityFrameworkCore dotnet add package Microsoft.EntityFrameworkCore.SqlServer dotnet add package Microsoft.EntityFrameworkCore.Tools dotnet add package Pomelo.EntityFrameworkCore.MySql
3. Database bağlantısını gerçekleştirin. 
4. Programı çalıştırın
