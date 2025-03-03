# System.IO Kütüphanesi Kullanımı 📂💻

Bu proje, `.NET` platformunda kullanılan `System.IO` kütüphanesinin temel sınıflarını açıklamaktadır. `System.IO` kütüphanesi, dosya ve dizin işlevleriyle ilgili birçok yardımcı sınıf içerir. Aşağıda, `File`, `FileInfo`, `Directory`, `DirectoryInfo`, `DriveInfo`, `Path`, `FileStream` ve `Stream` sınıflarına dair açıklamalar bulunmaktadır.

## Sınıflar ve Kullanım 📝

### 1. **File Sınıfı** 📄
`File` sınıfı, dosyalarla ilgili temel işlevleri sağlar (dosya okuma, yazma, silme vb.). Bu sınıfın çoğu metodu **statik** olarak tanımlanmıştır, bu nedenle doğrudan sınıf üzerinden erişilebilir. Nesne oluşturulmasına gerek yoktur.

### 2. **FileInfo Sınıfı** 🗂️
`FileInfo` sınıfı, bir dosyanın özelliklerini ve işlevlerini (özellikler üzerinde işlem yapma) daha esnek bir şekilde yönetmek için kullanılır. Bu sınıf, nesne tabanlı kullanıma uygundur.

### 3. **Directory Sınıfı** 📁
`Directory` sınıfı, dizinlerle ilgili işlemleri (dizin oluşturma, silme, dizin içeriğini listeleme vb.) yapmanıza olanak tanır. Tıpkı `File` sınıfı gibi, çoğu metodu **statik** olarak kullanılabilir.

### 4. **DirectoryInfo Sınıfı** 🗂️
`DirectoryInfo` sınıfı, belirli bir dizin üzerinde daha detaylı işlemler yapmanıza olanak tanır. Nesne tabanlıdır ve dizinle ilgili özelliklere doğrudan erişim sağlar.

### 5. **DriveInfo Sınıfı** 💾
`DriveInfo` sınıfı, bilgisayarınızdaki sürücüler hakkında bilgi almanızı sağlar (disk boyutu, boş alan vb.). Nesne tabanlıdır ve sürücülerle ilgili işlemler için kullanılır.

### 6. **Path Sınıfı** 🛤️
`Path` sınıfı, dosya ve dizin yolları ile ilgili çeşitli yardımcı metotlar sağlar (yol birleştirme, uzantı alma, dosya adı alma vb.). Bu sınıf tamamen **statiktir**.

### 7. **FileStream Sınıfı** 📥
`FileStream` sınıfı, dosyalarla byte düzeyinde işlem yapmanızı sağlar. Nesne tabanlıdır ve özellikle büyük dosya okuma/yazma işlemleri için kullanılır.

### 8. **Stream Sınıfı** 🌀
`Stream` sınıfı, dosya akışlarını yönetmek için kullanılan temel bir sınıftır. `FileStream`, `MemoryStream`, `BufferedStream` gibi sınıflar, `Stream` sınıfından türetilmiştir. Bu sınıf **soyut bir sınıf** olduğu için doğrudan nesne oluşturulmaz, bunun yerine türetilmiş sınıflar kullanılır.

## Statik ve Nesne Tabanlı Kullanım ⚙️

- **Statik Kullanım:** `File`, `Directory`, `Path` gibi sınıflar, genellikle statik olarak kullanılır. Bu sınıflarda nesne oluşturmaya gerek yoktur.
- **Nesne Tabanlı Kullanım:** `FileInfo`, `DirectoryInfo`, `DriveInfo` gibi sınıflar, nesne oluşturmanızı gerektirir. Bu sınıflar, belirli dosya, dizin veya sürücülerle ilgili daha detaylı işlem yapmanıza olanak tanır.

