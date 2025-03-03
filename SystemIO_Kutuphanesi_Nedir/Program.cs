using System.IO;
using System.Security.Cryptography;

namespace SystemIO_Kutuphanesi_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region SystemIO Nedir
            //System.IO, .NET Framework ve.NET Core'da yer alan bir kütüphanedir ve dosya ve akış işlemleriyle ilgili işlevleri sağlamak için kullanılır. Bu kütüphane, dosyalarla ve dizinlerle etkileşime girmenize olanak tanır. Temelde, dosya okuma, yazma, silme, yeniden adlandırma gibi işlemleri gerçekleştirebilirsiniz. Ayrıca, veri akışlarını yönetme ve dizin yapıları ile ilgili işlemleri kolaylaştırır.
            #endregion

            #region  System.IO Kutuphanesinin Islevleri
            /* 
            * Dosya Islemleri 
            Dosya okuma ve yazma: File sınıfı ile dosyaları okuma, yazma, kopyalama, silme gibi işlemler yapılabilir.
            Dosya yönetimi: Dosyanın var olup olmadığını kontrol etme, dosya özelliklerine erişme, yeniden adlandırma gibi işlemler yapılabilir.
            Dosya akışları (streams): Dosya içeriğini byte byte okuma ve yazma işlemleri yapılabilir.


            * Dizin Islemleri
            Dizin oluşturma, silme, dizin içeriği listeleme: Directory sınıfı ile dizinler üzerinde işlemler yapılabilir.
            Dizinlerin alt dizinlerine ve dosyalarına erişim sağlar.

            * Akışlar (Streams)
            Akışlar, verilerin belleğe veya dosyalara yazılması ve oradan okunması için kullanılan nesnelerdir. Stream sınıfı, akış işlemleri için temel bir sınıf sağlar.
            FileStream: Dosya okuma ve yazma işlemleri için kullanılır.
            MemoryStream: Bellek üzerinde veri okuma ve yazma işlemleri için kullanılır.

            * Path Sınıfı
            Dosya ve dizin yollarını yönetmek için kullanılan statik bir sınıftır. Dosya yolu birleştirme, uzantı alma, dizin ismi çıkarma gibi işlemler için kullanılır.
            Örneğin, Path.Combine() ile dosya yolunu birleştirebilir, Path.GetExtension() ile dosya uzantısını alabilirsiniz.

            * FileInfo ve DirectoryInfo
            FileInfo ve DirectoryInfo sınıfları, dosya ve dizinlerle ilgili detaylı bilgilere erişmenizi sağlar. Bu sınıflar ile daha objektif bir şekilde dosya veya dizinle ilgili işlemler yapılabilir.
            Ornegin, FileInfo sınıfı, bir dosyanın boyutunu, oluşturulma tarihini, son erişim zamanını ve diğer özellikleri sorgulamak için kullanılabilir.
             */
            #endregion

            #region  System.IO Kütüphanesinin Kullanım Alanları
            /*
             *   Dosya ve Dizin Yönetimi: Dosya oluşturma, okuma, yazma, silme, yeniden adlandırma, dosya kopyalama gibi işlemler yapılabilir.
             *   Veri Akışı İşlemleri: Büyük verilerle çalışırken akış (stream) işlemleri kullanılır. Bu, dosyalarla verimli bir şekilde çalışmayı sağlar.
             *   Uygulama Ayarları ve Konfigürasyonlar: Dosyalar aracılığıyla uygulama ayarları ve veriler saklanabilir ve okunabilir.
             *   Dosya Yedekleme: Dosya yedekleme işlemleri için dosyaların kopyalanması veya taşınması işlemleri yapılabilir. 
             */
            #endregion

            #region Ozet
            /*
             * System.IO kütüphanesi, dosya işlemleri ve veri akışlarıyla ilgili geniş bir işlevsellik sunar. Dosya okuma, yazma, dizin yönetimi ve akışlar gibi işlemleri kolaylaştıran bu kütüphane, dosya tabanlı uygulamalar geliştiren yazılımcılar için kritik bir araçtır. File, Directory, Stream, Path gibi sınıflar, dosyalar ve dizinlerle etkili bir şekilde çalışmayı sağlar.       
             */
            #endregion
        }
    }
}
