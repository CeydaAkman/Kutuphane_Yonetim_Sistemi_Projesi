# Kütüphane Yönetim Sistemi Projesi

Bu proje, kütüphane operasyonlarını dijitalleştirmek, kitap takibini kolaylaştırmak ve kullanıcı deneyimini en üst düzeye çıkarmak amacıyla geliştirilmiş kapsamlı bir yönetim sistemidir.

# Özellikler

Kitap Yönetimi: Kitap ekleme, silme, güncelleme ve liste filtreleme.

Üye Takibi: Kütüphaneye kayıtlı üyelerin bilgilerini yönetme ve ödünç geçmişini görüntüleme.

Ödünç Alma & İade: Kitapların teslim tarihlerini takip eden dinamik ödünç verme sistemi.

Arama & Filtreleme: Yazara, kitap adına veya kategoriye göre hızlı arama motoru.

Dashboard & İstatistikler: Toplam kitap sayısı, aktif ödünç verilen kitaplar gibi verilerin anlık takibi.

# Kullanılan Teknolojiler

Proje geliştirilirken modern yazılım prensipleri ve aşağıdaki teknolojiler kullanılmıştır:

Programlama Dili: C#

Arayüz: Windows Forms

Veritabanı: MSSQL

# Nielsen'in Kullanıcı Arayüzü İlkeleri

Bu projede kullanıcı deneyimini optimize etmek için Jakob Nielsen'in 10 temel ilkesine sadık kalınmıştır:

Sistem Durumunun Görünürlüğü: İşlem yapıldığında kullanıcıya net bildirimler sunulur.

Sistem ile Gerçek Dünyanın Uyumu: "Ödünç Ver", "İade Et" gibi kütüphanecilik terimleri kullanılarak kullanıcının aşina olduğu bir dil benimsenmiştir.

Kullanıcı Kontrolü ve Özgürlüğü: Yanlışlıkla yapılan işlemler için "İptal" veya "Geri Al" seçenekleri mevcuttur.

Hata Önleme: Kritik işlemlerden önce onay mekanizması çalıştırılarak hataların önüne geçilir.

Tanımak Yerine Hatırlamak: Kullanıcıların karmaşık ID'leri hatırlaması yerine, seçim yapabileceği listeler ve arama kutuları sunulur.

# Kurulum Adımları

Projeyi bilgisayarınızda çalışır hale getirmek için şu basit adımları izleyebilirsiniz:

Projeyi İndirme: Sayfanın sağ üst köşesinde bulunan yeşil "Code" butonuna tıklayarak projeyi "Download ZIP" seçeneğiyle bilgisayarınıza indirin ve klasöre çıkartın.

Gerekli Yazılımların Kontrolü: Bilgisayarınızda projenin yazıldığı dilin ve veritabanı sisteminin kurulu olduğundan emin olun.

Kütüphane Yüklemeleri: Proje klasörü içerisinde yer alan bağımlılıkların yüklendiğinden emin olun.

Veritabanı Bağlantısı: Eğer harici bir veritabanı kullanılıyorsa, veritabanı dosyasının proje dizininde olduğundan veya bağlantı ayarlarının yapıldığından emin olun.

Çalıştırma: Ana uygulama dosyasını çift tıklayarak veya ilgili editör üzerinden "Çalıştır" diyerek başlatın.

# Kullanım Adımları

Uygulama açıldıktan sonra sistemi şu şekilde kullanabilirsiniz:

Giriş Yapma: Eğer bir yetkilendirme sistemi varsa, yönetici bilgilerinizle sisteme giriş yapın.

Kitap Kaydı Oluşturma: "Kitap Ekle" sekmesine giderek kitabın adı, yazarı, sayfa sayısı ve kategorisi gibi bilgileri girip sisteme kaydedin.

Üye Kaydı Oluşturma: Kütüphaneden yararlanacak kişileri "Üye İşlemleri" bölümünden sisteme tanımlayın.

Ödünç Verme İşlemi: "Ödünç Ver" butonuna tıklayarak listeden bir kitap ve bir üye seçip işlemi onaylayın. Sistem, iade tarihini otomatik olarak hesaplayacaktır.

İade Alma ve Güncelleme: Kitap geri getirildiğinde "İade Al" seçeneğiyle kitabın durumunu tekrar "Mevcut" olarak güncelleyin.

Arama ve Listeleme: Elinizdeki mevcut kitapları veya üyeleri görmek için arama çubuğunu kullanarak filtreleme yapın.
