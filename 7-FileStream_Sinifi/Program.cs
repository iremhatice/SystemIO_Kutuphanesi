namespace _7_FileStream_Sinifi
{
    internal class Program
    {
        const string filePath = @"C:\Users\pc\Productklasor";
        static void Main(string[] args)
        {
            #region FileStream Sinifi
            /*
             * FileStream, dosyalarla doğrudan bayt seviyesinde okuma/yazma işlemleri yapmamızı sağlayan bir C# sınıfıdır.
             * Bu sınıf, büyük dosyalarla çalışırken veya veriyi doğrudan belleğe yüklemek yerine akış (stream) halinde işlemek gerektiğinde kullanılır.
             */
            #endregion

            #region FileStream Ile Dosya Yazma

            // FileStream ile dosya oluştur ve yazma modunda aç. Dosyaya veri yazmak için Write() metodu kullanılır.
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Merhaba, FileStream!"); //String ifadeyi baytlara (byte array) çevirir.
                fs.Write(data, 0, data.Length); //Byte dizisini dosyaya yazar.
            }

            Console.WriteLine("Dosya yazıldı: " + filePath);

            #endregion

            #region FileStream Ile Dosya Okuma

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStream.Length]; // Dosyanın boyutu kadar bir buffer oluştur
                int bytesRead = fileStream.Read(buffer, 0, buffer.Length); //Dosyadaki tüm baytları okur.

                Console.WriteLine($"Okunan byte sayısı: {bytesRead}");
                Console.WriteLine($"Icerik: " + System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead)); //Baytları stringe çevirir.
            }

            #endregion

            #region Dosyanın Sonuna Veri Eklemek

            // Dosyanın sonuna veri eklemek için FileMode.Append kullanılır.
            //FileMode.Append → Dosyanın sonuna ekleme yapar, var olmayan dosyayı oluşturur.

            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("\nYeni veri eklendi.");
                fs.Write(data, 0, data.Length); //Mevcut içeriği silmeden veri ekler.
            }

            Console.WriteLine("Dosyaya veri eklendi.");
            #endregion

            #region Dosya Silme

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Dosya silindi.");
            }
            else
            {
                Console.WriteLine("Dosya bulunamadı.");
            }
            #endregion

        }
    }
}
