namespace _8_Stream_Sinifi
{
    internal class Program
    {
        const string filePath = @"C:\Users\pc\Productklasor\product.txt";
        static void Main(string[] args)
        {
            #region StreamReader Ile Dosya Okuma

            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Dosya İçeriği:\n" + content);
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // FileStream kullanarak StreamReader oluştur
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Dosya İçeriği:\n" + content);
            }
            #endregion

            #region StreamWriter Ile Dosya Yazma

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Bu bir test dosyasıdır.");
            }

            Console.WriteLine("Dosya yazıldı.");

            // FileStream kullanarak StreamWriter oluştur
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine("Merhaba, StreamWriter!");
                writer.WriteLine("Bu bir test dosyasıdır.");
            }

            Console.WriteLine("Dosya yazma işlemi tamamlandı.");
            #endregion
        }
    }
}
