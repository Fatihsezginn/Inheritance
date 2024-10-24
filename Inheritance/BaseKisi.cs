public class BaseKisi
{
    public string Ad { get; set; } // Ad özelliği
    public string Soyad { get; set; } // Soyad özelliği

    public void Yazdir() // Yazdırma metodu
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}"); // Ad ve soyadı yazdır
    }
}
