public class penjumlahan
{
    public void JumlahTigaAngka<T>(T angka)
    {
        Console.WriteLine("Hasil Penjumlahan = " + angka);
    }
}
class Program
{
    static void Main(string[] args)
    {
        penjumlahan jum = new penjumlahan();
        int inputan = 13 + 02 + 22;
        jum.JumlahTigaAngka(inputan);
    }
}