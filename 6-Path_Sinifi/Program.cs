using System;

namespace _6_Path_Sinifi
{
    internal class Program
    {
        const string filePath = @"C:\Users\pc\Productklasor\product.txt";
        static void Main(string[] args)
        {
            #region Path Sinifi
            /*
              Path sınıfı, dosya ve dizin yollarını (file paths & directory paths) işlemek için kullanılan bir C# sınıfıdır.
              Bu sınıf sayesinde dosya adlarını, uzantıları, klasör yollarını kolayca ayırabilir veya birleştirebilirsiniz.
             */
            #endregion

            #region Path Sinifi Ozellikleri
            //Dosya yolu içerisinden dosya adı, uzantı veya klasör adını almak için kullanılır.

            Console.WriteLine("Dosya Yolu: " + filePath); //Çıktı: Dosya Yolu: C:\Users\pc\Productklasor\product.txt
            Console.WriteLine("Dizin: " + Path.GetDirectoryName(filePath)); //Çıktı: Dizin: C:\Users\pc\Productklasor
            Console.WriteLine("Dosya Adı: " + Path.GetFileName(filePath)); //Çıktı: Dosya Adı: product.txt
            Console.WriteLine("Uzantısız Dosya Adı: " + Path.GetFileNameWithoutExtension(filePath)); //Çıktı: Uzantısız Dosya Adı: product
            Console.WriteLine("Uzantı: " + Path.GetExtension(filePath)); //Çıktı: Uzantı: .txt

            //Dosya ve dizin adlarını manuel olarak string birleştirerek yazmak yerine Path.Combine() kullanabilirsiniz.

            string relativePath = @"..\..\readme.txt";
            Console.WriteLine(Path.GetFullPath(relativePath)); //Çıktı: C:\Users\pc\Desktop\Çalışmalarım\SystemIO_Kutuphanesi\6-Path_Sinifi\bin\readme.txt

            string folder = @"D:\temp";
            string fileName = "readme.txt";

            Console.WriteLine(Path.Combine(folder, fileName)); //Çıktı: D:\temp\readme.txt
            Console.WriteLine(Path.ChangeExtension(filePath, ".pdf")); //Çıktı: C:\Users\pc\Productklasor\product.pdf


            //Sistem geçici dosya konumlarını almak için kullanılır.

            Console.WriteLine("Geçici Dosya Yolu: " + Path.GetTempPath()); //Sistem geçici dosya dizinini döndürür. Çıktı: Geçici Dosya Yolu: C:\Users\pc\AppData\Local\Temp\
            Console.WriteLine("Yeni Geçici Dosya Adı: " + Path.GetTempFileName()); // Yeni rastgele bir geçici dosya oluşturur. Çıktı: Yeni Geçici Dosya Adı: C:\Users\pc\AppData\Local\Temp\tmpxqxchz.tmp

            //Dosyanın bulunduğu kök dizini almak için kullanılır.

            string filePath2 = @"C:\Users\Irem\Documents\report.pdf";
            Console.WriteLine("Kök Dizin: " + Path.GetPathRoot(filePath2)); //Çıktı: Kök Dizin: C:\

            //Rastgele dosya yolu oluşturmak için kullanılır.

            string uniqueFileName = Path.ChangeExtension(Path.GetRandomFileName(), ".txt");
            Console.WriteLine("Rastgele Dosya Adı: " + uniqueFileName); //Çıktı: Rastgele Dosya Adı: imjjgld4.txt

            #endregion
        }
    }
}
