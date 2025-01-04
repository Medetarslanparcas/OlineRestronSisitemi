Online Restoran Takip Sistemi, restoranlar ıçin sipariş, stok, menü ve personel yönetimini kolaylaştırmak amacıyla geliştirilmiş bir masaüstü uygulamasıdır. Bu proje, restoran sahiplerine operasyonlarını dijital olarak takip etme ve optimize etme olanağı sağlar.

Özellikler

Sipariş Yönetimi: Yeni sipariş ekleme, mevcut siparişleri güncelleme ve silme.

Menü Yönetimi: Yemeklerin fiyatlarını ve içeriklerini düzenleme.

Stok Takibi: Malzeme seviyelerini kontrol etme ve stok uyarıları alınması.

Personel Yönetimi: Çalışan bilgilerini kaydetme ve düzenleme.

Raporlama: Gelir, sipariş ve stok raporları oluşturma.

Kullanılan Teknolojiler

Programlama Dili: C# (Windows Forms)

Veritabanı: MySQL

Kütüpaneler ve Araçlar:

MySql.Data: Veritabanı bağlantısı ve sorgular.

System.Windows.Forms: Masaüstü arayüz geliştirme.

Kurulum

Proje Dosyasını Klonlama

git clone https://github.com/kullaniciAdiniz/online-restoran-sistemi.git
cd online-restoran-sistemi

Gereksinimler

Visual Studio 2019 veya daha yenisi

.NET Framework yüklenmiş bir bilgisayar

MySQL Server ve MySQL Workbench

Veritabanı Yapılandırması

Proje dizinindeki database.sql dosyasını kullanarak MySQL veritabanınızı oluşturun.

Veritabanı bağlantı ayarlarını App.config dosyasında düzenleyin:

<connectionStrings>
  <add name="MySqlConnection" connectionString="Server=localhost;Database=restoran_db;Uid=root;Pwd=password;" providerName="MySql.Data.MySqlClient" />
</connectionStrings>

Projeyi Çalıştırma

Visual Studio'da projeyi açın ve Run (F5) tuşuna basarak uygulamayı başlatın.

Ekran Görünütülerinden Örnekler

Anasayfa



Sipariş Ekranı



Katkıda Bulunma

Bu projeye katkı sağlamak isterseniz:

Bu depoyu fork edin.

Yeni bir dal oluşturun: git checkout -b yeni-ozellik

Değişikliklerinizi commit edin: git commit -m 'Yeni bir özellik eklendi'

Değişikliklerinizi push edin: git push origin yeni-ozellik

Bir Pull Request oluşturun.

