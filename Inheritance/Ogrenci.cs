public class Ogrenci : BaseKisi
{
    public string OgrenciNumarasi { get; set; } // Öğrenci numarası

    public void YazdirOgrenci() // Öğrenci bilgilerini yazdırma metodu
    {
        Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}"); // Öğrenci numarasını yazdır
        Yazdir(); // BaseKisi'den yazdırma metodunu çağır
    }
}
