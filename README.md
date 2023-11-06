# KutuphaneUygulamasi
Kullanıcı girişi yapıldıktan sonra kütüphanedeki kitapların takibi ve ödünç verilmesi için bir ASP.NET Core MVC uygulamasıdır.

## Özellikler

Uygulamada aşağıdaki özellikler bulunmaktadır:

- Kullanıcılar, kitap ödünç almak istediklerinde adlarını ve soyadlarını girebilirler. Ayrıca geri getirme tarihini belirleyebilirler. Kitabın geri getirme tarihi geçtikten sonra, kitap otomatik olarak kütüphaneye geri eklenir.

- Kullanıcılar, yeni kitapları kütüphaneye eklemek için kitap ekleme bölümünü kullanabilirler. Kitap adı, yazarı ve resmi yüklenerek kütüphaneye yeni kitaplar eklenebilir.

- Projeye gelecekte daha fazla özellik ve geliştirmeler eklenecektir.

## Ekran görüntüleri

<img width="798" alt="Ekran görüntüsü 2023-11-06 200243" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/f95b7837-05ef-41c6-8586-31d1f01404a2">


<img width="795" alt="Ekran görüntüsü 2023-11-06 200429" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/f6c75e6f-62a1-4fc8-bde4-b414357ac35e">


<img width="793" alt="Ekran görüntüsü 2023-11-06 213533" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/c034de5f-b10f-4679-afc7-c4273fcc4c29">


<img width="798" alt="Ekran görüntüsü 2023-11-06 213632" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/e22ffc97-b698-4abf-94cf-37d65a4846ca">


<img width="797" alt="Ekran görüntüsü 2023-11-06 213658" src="https://github.com/muhammedlyas/KutuphaneUygulamasi/assets/113562315/59ab5dc6-c40d-46e2-9e09-9d59b0a07566">


## Kurulum

Proje yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1. Projeyi klonlayın.
2. Gerekli nuGet paketlerini yükleyin: Microsoft.EntityFrameworkCore dotnet add package Microsoft.EntityFrameworkCore.SqlServer dotnet add package Microsoft.EntityFrameworkCore.Tools dotnet add package Pomelo.EntityFrameworkCore.MySql
3. Database bağlantısını gerçekleştirin. 
4. Programı çalıştırın
