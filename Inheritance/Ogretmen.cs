public class Ogretmen : BaseKisi
{
    public decimal MaasBilgisi { get; set; } // Maaş bilgisi

    public void YazdirOgretmen() // Öğretmen bilgilerini yazdırma metodu
    {
        Console.WriteLine($"Maaş Bilgisi: {MaasBilgisi}"); // Maaş bilgisini yazdır
        Yazdir(); // BaseKisi'den yazdırma metodunu çağır
    }
}
