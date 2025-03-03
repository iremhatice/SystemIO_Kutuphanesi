namespace _3_Directory_Sinifi
{
    internal class Program
    {
        const string directoryPath = @"C:\Users\pc\DırectoryKlasor";
        static void Main(string[] args)
        {
            #region Directory Sınıfı
            /*
               * Directory sınıfı, statik bir sınıftır ve dosya sisteminde dizinler (klasörler) üzerinde işlem yapmaya yarar.
               * Klasör oluşturma, silme, taşıma ve listeleme gibi işlemler için kullanılır.
               * Çünkü statik bir sınıf olduğu için nesne oluşturmadan doğrudan metodları çağırabiliriz.
             */
            #endregion

            #region Klasor Olusturma

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine("Klasör oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Klasör zaten mevcut.");
            }

            #endregion

            #region Alt Dizin Olusturma

            string subDirectory = Path.Combine(directoryPath, "SubFolder");
            Directory.CreateDirectory(subDirectory);
            Console.WriteLine("Alt klasör oluşturuldu.");

            #endregion

            #region Klasordeki dosya ve klasorleri listeleme

            string[] directories = Directory.GetDirectories(directoryPath);
            Console.WriteLine("Alt Klasörler:");
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }

            string[] files = Directory.GetFiles(directoryPath);
            Console.WriteLine("Dosyalar:");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            #endregion

            #region Klasoru Tasima

            string newDirectoryPath = @"C:\Users\pc\NewExampleKlasor";
            Directory.Move(directoryPath, newDirectoryPath);
            Console.WriteLine("Klasör taşındı.");

            #endregion

            #region Klasoru silme (Eğer içi boşsa)

            string newDirectoryPath2 = @"C:\Users\pc\NewExampleKlasor";
            Directory.Delete(newDirectoryPath2);
            Console.WriteLine("Klasör silindi.");
            #endregion
        }
    }
}