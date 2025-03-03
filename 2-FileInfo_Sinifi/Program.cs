using System.IO;
using System.Security.Cryptography;

namespace _2_FileInfo_Sinifi
{
    internal class Program
    {
        const string filePath = @"C:\Users\pc\Productklasor\product.txt";
        static void Main(string[] args)
        {
            #region FileInfo Sinifi
            /*
               * FileInfo sınıfı, System.IO ad alanında yer alan ve dosyalarla ilgili çeşitli işlemleri daha ayrıntılı bir şekilde yönetmeye imkan veren bir sınıftır. FileInfo, statik olmayan bir sınıftır ve dosyalar üzerinde işlem yapmadan önce bir FileInfo nesnesi oluşturulması gerekir. Bu sınıf, dosyalar hakkında daha fazla bilgi almanıza, dosyaları değiştirmeye ve dosyalarla ilgili çeşitli işlemleri yapmanıza olanak tanır.

               * FileInfo Sınıfının Ozellikleri ve Kullanımı
                 FileInfo, genellikle dosya yönetimi için daha esnek bir çözüm sunar. File sınıfına benzer şekilde, dosya işlemleri yapabilmek için yine bir dosya yolu gereklidir, ancak FileInfo ile dosya üzerinde işlem yapmadan önce nesne oluşturmanız gerekir. Bu sınıf, dosyaların özelliklerine ve durumlarına daha kolay erişim sağlar ve ayrıca dosya işlemlerini (okuma, yazma, silme gibi) gerçekleştirebilir.
             */
            #endregion

            #region FileInfo Sınıfının Ana Ozellikleri
            FileInfo fileInfo = new FileInfo(filePath);

            // Exists: Dosyanın var olup olmadığını kontrol eder. Belirtilen dosyanın var olup olmadığını boolean bir değer ile döndürür.

            Console.WriteLine("Dosya Var mı: " + fileInfo.Exists); //Çıktı: Dosya Var mı: True

            // CreationTime: Dosyanın oluşturulma zamanını döndürür.
            DateTime creationTime = fileInfo.CreationTime;
            Console.WriteLine("Dosya oluşturma tarihi: " + creationTime); //Çıktı: Dosya oluşturma tarihi: 28.02.2025 01:38:20

            // FullName: Dosyanın tam yolunu döndürür.
            string fullName = fileInfo.FullName;
            Console.WriteLine("Dosyanın Tam Ismi: " + fullName); // Çıktı: Dosyanın Tam Ismi: C: \Users\pc\Productklasor\product.txt

            // Name: Dosyanın adını döndürür (uzantı dahil).
            string fileName = fileInfo.Name; 
            Console.WriteLine("Dostanın Ismi: " + fileName); // Çıktı: Dostanın Ismi: product.txt

            // Extension: Dosyanın uzantısını döndürür.
            string extension = fileInfo.Extension;
            Console.WriteLine("Dosyanın Uzantısı: " + extension);  // Çıktı: Dosyanın Uzantısı: .txt

            // Directory: Dosyanın bulunduğu dizini döndürür.
            DirectoryInfo directory = fileInfo.Directory;
            Console.WriteLine("Dosyanın Adresi: " + directory); // Çıktı: Dosyanın Adresi: C: \Users\pc\Productklasor

            // Length: Dosyanın boyutunu bayt (byte) cinsinden döndürür.
            long size = fileInfo.Length;  // Dosya boyutu
            Console.WriteLine("Dosyanın Boyutu: " + size); // Çıktı: Dosyanın Boyutu: 0

            // LastAccessTime: Dosyanın son erişim zamanını döndürür.
            DateTime lastAccessTime = fileInfo.LastAccessTime;
            Console.WriteLine("Dosya son erişim tarihi: " + creationTime); //Çıktı: Dosya son erişim tarihi: 28.02.2025 01:38:20

            // LastWriteTime: Dosyanın son yazılma zamanını döndürür.
            DateTime lastWriteTime = fileInfo.LastWriteTime;
            Console.WriteLine("Dosyanın Değişiklik Tarihi: " + lastWriteTime); // Çıktı: Dosyanın Değişiklik Tarihi: 28.02.2025 01:38:20

            // IsReadOnly: Dosyanın salt okunur olup olmadığını belirtir.
            bool isReadOnly = fileInfo.IsReadOnly;
            Console.WriteLine("Dosyanın Okunurlugu: " + isReadOnly);
            #endregion

            #region FileInfo Sınıfının Metodları
            FileInfo fileInfo2 = new FileInfo(filePath);

            // Delete(): Dosyayı siler.
            fileInfo2.Delete();

            // CopyTo(): Dosyayı başka bir konuma kopyalar.
            fileInfo2.CopyTo("path_to_new_file.txt");

            // MoveTo(): Dosyayı başka bir konuma taşır.
            fileInfo2.MoveTo("path_to_new_file.txt");

            // Open(): Dosyayı açar ve bir FileStream nesnesi döndürür.
            FileStream fs = fileInfo2.Open(FileMode.Open);
            Console.WriteLine(fs);

            // OpenRead(): Dosyayı sadece okuma amacıyla açar ve bir FileStream döndürür.
            FileStream fs2 = fileInfo2.OpenRead();
            Console.WriteLine(fs2);

            // OpenWrite(): Dosyayı sadece yazma amacıyla açar ve bir FileStream döndürür.
            FileStream fs3 = fileInfo2.OpenWrite();
            Console.WriteLine(fs3);

            // Refresh(): Dosya bilgilerini günceller. Bu metod, FileInfo nesnesi oluşturulduktan sonra dosya üzerinde yapılan değişikliklerin nesneye yansımasını sağlar.
            fileInfo.Refresh();

            // Attributes: Dosyanın özelliklerini almak ve değiştirmek için kullanılabilir (örneğin, salt okunur, gizli vs.).
            FileAttributes attributes = fileInfo.Attributes;
            fileInfo.Attributes = FileAttributes.ReadOnly;  // Dosyayı salt okunur yapma
            #endregion

            #region FileInfo Sınıfı ile Ilgili Kullanım Senaryoları
            /*
             *   Dosya Bilgilerini Alma: Bir dosyanın yolu, boyutu, oluşturulma tarihi gibi özelliklere FileInfo ile kolayca ulaşabilirsiniz. Bu, dosya yönetimi uygulamalarında oldukça kullanışlıdır.
             *   Dosya Yönetimi: CopyTo, MoveTo, Delete gibi metodlarla dosyaları taşıma, kopyalama ve silme işlemleri yapılabilir.
             *   Dosya Akışları ile Çalışma: Open, OpenRead ve OpenWrite gibi metodlarla dosyaların içerikleri üzerinde akış (stream) işlemleri yapılabilir.
             *   Dosya Özelliklerini Güncelleme: IsReadOnly, Attributes gibi özelliklerle dosyanın salt okunur olması gibi özellikler kontrol edilebilir ve değiştirilebilir.
             *   Dosya Erişim Zamanı Takibi: Dosyanın son erişim zamanı, oluşturulma zamanı gibi bilgileri alarak dosyanın ne zaman kullanıldığını takip edebilirsiniz.
             */
            #endregion

            #region Ozet
            /*
             *  FileInfo sınıfı, dosya işlemleri için çok daha ayrıntılı bir kontrol sağlar. Özellikle dosyanın özelliklerine erişim, dosyayı açma, okuma ve yazma işlemleri gibi daha karmaşık işlemler için kullanılır. FileInfo, File sınıfına göre daha esnek ve zengin özellikler sunar, çünkü her dosya için nesne tabanlı işlemler yapmanıza olanak tanır. Bu sınıf, dosya yönetim sistemleri ve uygulamaları geliştirirken oldukça faydalıdır.
             */
            #endregion
        }
    }
}
