namespace _5_DriveInfo_Sinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DriveInfo
            /*
             *  DriveInfo sınıfı, sisteminizdeki sürücüler hakkında bilgi almak için kullanılan bir C# sınıfıdır.
             *  Bu sınıfı kullanarak sürücünün adı, türü, toplam alanı, boş alanı ve dosya sistemi gibi bilgileri edinebilirsiniz.
             *  DriveInfo sınıfı, sistemdeki sabit diskleri, USB bellekleri ve harici diskleri kontrol etmek için kullanılır.  
             *  USB bellek takılı mı, sürücü kullanılabilir mi gibi kontroller yapılabilir.
             */
            #endregion

            #region DriveInfo Ozellikleri
            DriveInfo driveInfo = new DriveInfo("C"); //Sadece C sürücüsü hakkında bilgi alır.

            if (driveInfo.IsReady) //Sürücü kullanılabilir mi?
            {

                Console.WriteLine("Kullanılabilir: " + driveInfo.AvailableFreeSpace);
                Console.WriteLine("Boş: " + driveInfo.TotalFreeSpace);
                Console.WriteLine("Toplam: " + driveInfo.TotalSize);
                Console.WriteLine("Format: " + driveInfo.DriveFormat);
                Console.WriteLine("Tipi: " + driveInfo.DriveType);
                Console.WriteLine("Ismi: " + driveInfo.Name);
                Console.WriteLine("Kok: " + driveInfo.RootDirectory);
                Console.WriteLine("Etiket: " + driveInfo.VolumeLabel);
                Console.WriteLine($"Sürücü Adı: {driveInfo.Name}");
            }
            #endregion
        }
    }
}
