class Program
{
    static void Main(string[] args)
    {
        // Öğrenci oluşturma
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Ali",
            Soyad = "Yılmaz",
            OgrenciNumarasi = "12345"
        };

        // Öğretmen oluşturma
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Ayşe",
            Soyad = "Kara",
            MaasBilgisi = 5000m
        };

        // Bilgileri yazdırma
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci.YazdirOgrenci();

        Console.WriteLine("\nÖğretmen Bilgileri:");
        ogretmen.YazdirOgretmen();
    }
}
