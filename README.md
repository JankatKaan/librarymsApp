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

![image](https://github.com/user-attachments/assets/5954498b-c471-485c-942c-ddfcdad0f4b9)

![image](https://github.com/user-attachments/assets/7cd4ceef-e421-4519-a639-5d37480033bc)


Kitap Listesi Sayfası:

![image](https://github.com/user-attachments/assets/a667011e-6bf0-48e1-9c29-b32b255a7366)


Üye Listesi Sayfası:

![image](https://github.com/user-attachments/assets/8dfcc417-c535-47cb-bd83-22a1dc261f7b)


Ödünç Verme Sayfası:

![image](https://github.com/user-attachments/assets/356ece09-c78c-4f5c-bde0-221937c26440)

