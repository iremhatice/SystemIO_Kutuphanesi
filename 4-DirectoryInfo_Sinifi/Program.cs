namespace _4_DirectoryInfo_Sinifi
{
    internal class Program
    {
        const string directoryInfoPath = @"C:\Users\pc\DırectoryInfoKlasor";
        static void Main(string[] args)
        {
            #region DirectoryInfo Sinifi
            /*
             * DirectoryInfo sınıfı, nesne tabanlıdır, yani bir dizin ile işlem yapmadan önce DirectoryInfo nesnesi oluşturulmalıdır.
             * Dizin hakkında detaylı bilgi alabiliriz (oluşturulma zamanı, son erişim zamanı vb.)
             * Directory sınıfındaki gibi oluşturma, taşıma ve silme işlemlerini yapabilir.             
             */
            #endregion

            DirectoryInfo dirInfo = new DirectoryInfo(directoryInfoPath);

            #region Klasor olusturma

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
                Console.WriteLine("Klasör oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Klasör zaten mevcut.");
            }
            #endregion

            #region Klasor bilgilerini alma

            Console.WriteLine("Klasör Adı: " + dirInfo.Name);
            Console.WriteLine("Tam Yol: " + dirInfo.FullName);
            Console.WriteLine("Oluşturulma Tarihi: " + dirInfo.CreationTime);
            Console.WriteLine("Son Erişim Tarihi: " + dirInfo.LastAccessTime);
            Console.WriteLine("Klasör Var Mı: " + dirInfo.Exists);
            Console.WriteLine("Klasörün Kök Dizini: " + dirInfo.Root);
            #endregion

            #region Alt klasörleri listeleme

            DirectoryInfo[] subDirs = dirInfo.GetDirectories();
            Console.WriteLine("Alt Klasörler:");
            foreach (var subDir in subDirs)
            {
                Console.WriteLine(subDir.FullName);
            }
            #endregion

            #region Dosyalari listeleme

            FileInfo[] files = dirInfo.GetFiles();
            Console.WriteLine("Dosyalar:");
            foreach (var file in files)
            {
                Console.WriteLine(file.Name);
            }
            #endregion

            #region Klasoru Tasima

            string newPath = @"C:\Users\pc\NewExampleKlasor";
            dirInfo.MoveTo(newPath);
            Console.WriteLine("Klasör taşındı.");
            #endregion

            #region Klasoru silme 

            DirectoryInfo newDirInfo = new DirectoryInfo(newPath);
            newDirInfo.Delete();
            Console.WriteLine("Klasör silindi.");
            #endregion
        }
    }
}
