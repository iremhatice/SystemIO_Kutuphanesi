using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace _1_File_Sinifi
{
    internal class Program
    {
        const string filePath = @"C:\Users\pc\Productklasor\product.txt";
        static void Main(string[] args)
        {
            #region File Sinifi
            /*
               * File sınıfı, .NET Framework ve .NET Core’da dosyalarla ilgili temel işlemleri yapmanıza olanak tanır. Dosya işlemleri için kullanılan statik bir sınıftır.  Bu sınıf, dosyaları okuma, yazma, kopyalama, silme gibi işlemleri gerçekleştirmenizi sağlar. System.IO.File sınıfı, dosya sistemindeki dosyalarla etkileşimde bulunmayı kolaylaştıran bir dizi statik metot sunar.

               * File Sınıfının Ozellikleri
               Statik bir sınıftır: File sınıfı, doğrudan bir nesne oluşturulmadan kullanılır, çünkü tüm metotlar statiktir.
               Dosya işlemleri için çeşitli yardımcı metotlar içerir: Dosya okuma ve yazma işlemleri, dosya kopyalama, silme, varlık kontrolü gibi bir dizi işlevi içerir.
           */
            #endregion

            #region File Sınıfının Ana Metodları

            #region 1.Dosya Okuma ve Yazma Islemleri
            // WriteAllText: Dosyayı belirtilen yolda oluşturur ve içine verilen metni yazar. Eğer dosya zaten mevcutsa, içeriğini üzerine yazar.

            File.WriteAllText("product.txt", "Hello, World!");
            File.WriteAllText(filePath, "Deneme");

            // ReadAllText: Bir dosyadaki tüm metni okur. Belirtilen dosyadaki tüm içeriği bir string olarak döndürür.

            string content = File.ReadAllText("path_to_file.txt");
            string[] content2 = File.ReadAllLines(filePath);

            foreach (var item in content2)
            {
                Console.WriteLine(item);
            }

            // AppendAllText: Bir dosyaya metin ekler. Dosyanın sonuna metin ekler, dosya yoksa yeni bir dosya oluşturur.

            File.AppendAllText("path_to_file.txt", "More text.");
            File.AppendAllText(filePath, "Merhaba");
            #endregion

            #region 2.Dosya Kopyalama
            // Copy: Kaynak dosyayı belirtilen hedef dosyaya kopyalar. Eğer hedef dosya zaten varsa, bir hata fırlatır. Hedefin üzerine yazılmasını istiyorsanız, üçüncü bir parametre ekleyebilirsiniz.

            File.Copy(filePath, "C:\\Users\\pc\\OgrenciKlasoru\\Ogrenciler.txt");
            File.Copy("sourceFile.txt", "destinationFile.txt");
            File.Copy("sourceFile.txt", "destinationFile.txt", true);  // Uzerine yazar

            #endregion

            #region 3.Dosya Silme
            // Delete: Belirtilen dosyayı siler. Dosya mevcut değilse, hata fırlatılır.

            File.Delete("path_to_file.txt");
            File.Delete("C:\\Users\\pc\\Productklasor\\product.txt");
            #endregion

            #region 4.Dosya Varlıgını Kontrol Etme
            // Exists: Dosyanın var olup olmadığını kontrol eder. Belirtilen dosyanın var olup olmadığını boolean bir değer ile döndürür.

            bool fileExists = File.Exists("path_to_file.txt");
            if (File.Exists(filePath))
                File.WriteAllText(filePath, "Merhaba Dünya! \n\t Irem Kars");
            else
                File.Create(filePath);
            Console.WriteLine("TXT Oluşturuldu.");
            #endregion

            #region 5.Dosya Ozelliklerini Alma
            // GetAttributes: Dosyanın özelliklerini alır. (örneğin, salt okunur, gizli vs.) Dosya özelliklerini döndürür. Bu özellikler FileAttributes enum değerleri ile temsil edilir (örneğin, ReadOnly, Hidden).

            FileAttributes attributes = File.GetAttributes("path_to_file.txt");
            FileAttributes attributes2 = File.GetAttributes(filePath);

            Console.WriteLine(attributes);
            Console.WriteLine(attributes2); //Çıktı: Archive
            #endregion

            #region 6.Dosya Yolu ve Adı Alma
            // GetFileName: Dosyanın adını alır. Verilen dosya yolundan sadece dosyanın ismini döndürür.

            string fileName = Path.GetFileName("path_to_file.txt");
            string fileName2 = Path.GetFileName(filePath);

            Console.WriteLine(fileName); // Çıktı: path_to_file.txt
            Console.WriteLine(fileName2); // Çıktı:  product.txt

            // GetFileNameWithoutExtension: Dosyanın uzantısı olmadan ismini alır.

            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension("path_to_file.txt");
            string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension("C:\\Users\\pc\\Productklasor\\product.txt");

            Console.WriteLine(fileNameWithoutExtension); //Çıktı: path_to_file
            Console.WriteLine(fileNameWithoutExtension2); //Çıktı: product

            // GetExtension: Dosyanın uzantısını alır.

            string extension = Path.GetExtension("path_to_file.txt");
            string extension2 = Path.GetExtension("C:\\Users\\pc\\Productklasor\\product.txt");

            Console.WriteLine(extension); //Çıktı: .txt
            Console.WriteLine(extension2); //Çıktı: .txt
            #endregion

            #region 7.Dosya Okuma ve Yazma Akışları
            // ReadAllBytes: Bir dosyanın tüm içeriğini byte dizisi olarak okur.

            byte[] bytes = File.ReadAllBytes("path_to_file.txt");

            // WriteAllBytes: Byte dizisini bir dosyaya yazar.

            byte[] bytesToWrite = new byte[] { 0, 1, 2, 3 };
            File.WriteAllBytes("path_to_file.bin", bytesToWrite);
            #endregion

            #region 8.Dosya Bilgileri Alma
            // GetLastAccessTime: Dosyanın son erişim zamanını alır.
            DateTime lastAccessTime = File.GetLastAccessTime("product.txt");
            Console.WriteLine(lastAccessTime); //Çıktı: 1.01.1601 02:00:00

            // GetCreationTime: Dosyanın oluşturulma zamanını alır.

            DateTime creationTime = File.GetCreationTime("product.txt");
            Console.WriteLine(creationTime); //Çıktı: 1.01.1601 02:00:00

            // GetLastWriteTime: Dosyanın son yazılma zamanını alır.

            DateTime lastWriteTime = File.GetLastWriteTime("product.txt");
            Console.WriteLine(lastWriteTime); //Çıktı: 1.01.1601 02:00:00
            #endregion

            #endregion

            #region File Sınıfı ile Ilgili Kullanım Senaryoları
            /*
             *  Basit Dosya Okuma ve Yazma: Dosyalarla metin okuma ve yazma işlemleri yapmak için WriteAllText, ReadAllText, AppendAllText gibi metotlar kullanılabilir.

             *  Dosya Kopyalama ve Silme: Kullanıcıların dosya yönetimi yapmasına olanak tanır. Dosya yedekleme için Copy ve gereksiz dosyaları silmek için Delete metotları kullanılır.

             *  Dosya Varlık Kontrolü: Dosyanın var olup olmadığını kontrol etmek için Exists metodu kullanılır. Bu, dosyaların silinmeden önce güvenli bir şekilde kontrol edilmesini sağlar.

             *  Dosya Bilgileri: Dosya oluşturulma tarihi, son erişim tarihi gibi dosya bilgilerine erişmek için GetCreationTime, GetLastAccessTime, GetLastWriteTime gibi metodlar kullanılabilir.

             *  Akış ve Binary Islemleri: Dosya okuma ve yazma işlemleri byte düzeyinde yapılabilir. Bu, özellikle büyük dosyalarla çalışırken daha verimli olabilir.
             */
            #endregion


        }
    }
}
