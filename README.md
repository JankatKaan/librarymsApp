KÜTÜPHANE YÖNETİM SİSTEMİ

1. Projenin Amacı

Kütüphane Yönetim Sistemi, kütüphanelerde bulunan kitapların kaydını tutmak, yeni kitap eklemek, var olan kitap bilgilerini güncellemek ve kitapları silebilmek amacıyla geliştirilmiştir. Üye ekleme, güncelleme ve silme işlemleri de yapılmaktadır. Ayrıca üyelere kitap atama da gerçekleştirilir. Bu sistem, kullanıcıların kitap veritabanını kolayca yönetmesini sağlar ve kitap bilgilerine hızlı bir şekilde erişim sunar.

2. Kullanılan Teknolojiler

Bu projede aşağıdaki teknolojiler kullanılmıştır:

Backend: ASP.NET Core (MVC)

Veritabanı: SQLite

Frontend: HTML, CSS, JavaScript, Bootstrap

ORM: Entity Framework Core

Geliştirme Ortamı: Visual Studio

3. Kod Yapısının Açıklaması

Proje, Model-View-Controller (MVC) mimarisi kullanılarak geliştirilmiştir. CRUD işlemleri yapılmıştır Ana bilesenleri şu şekildedir:

1-Model

[Book.cs]: BookId, Title (Kitap adı), Author (Yazar), Category (Kitap türü), CoverImage (Kapak resmi), Description (Açıklama), PublicationYear (yayın yılı)

[Member.cs]: MemberId, Name, Surname, Email, Phone

[BookBorrow.cs]: BorrowId, BorrowDate

2-Controller

Index(): Kitap ve üye listesini getirir ve görüntüler.

Create(): Yeni kitap ve üye ekleme formunu gösterir ve ekleme işlemini gerçekleştirir.

Edit(): Kitap ve üye bilgilerini günceller.

Delete(): Kitap ve üye kaydını siler.

3-View (Bootstrap Kullanılıyor)

Kitaplar ve üyeler için ekleme/düzenleme/silme butonlarını içerir.

4. Ekran Görüntüleri

Ana Sayfa:

![home](https://github.com/user-attachments/assets/84ac42b2-a92f-4564-8f52-813313a38efd)


Kitap Listesi Sayfası:

![book](https://github.com/user-attachments/assets/54c91612-7bc6-4be2-8a41-1b2d09ae42e6)


Üye Listesi Sayfası:

![member](https://github.com/user-attachments/assets/e11ffc7d-d6f7-4287-b3f7-47d322b5cd59)


Ödünç Verme Sayfası:

![borrow](https://github.com/user-attachments/assets/9de0ebca-0738-43d7-b3d6-07486b5eea2c)
