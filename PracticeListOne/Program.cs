class Program
{
    public static void Main(string[] args)
    {
        //string tipinde bir liste oluşturduk
        List<string> guests = new List<string>();
        //Bİlgi Mesajları
        Console.WriteLine("Hoşgeldin, Patika Plus Gala Gecesi İçin Davetli Listenizi Oluşturunuz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("! ! ! DİKKAT ! ! ! EN FAZLA 8 DAVETLİ GİREBİLİRSİNİZ ! ! ! DİKKAT ! ! !");
        Console.WriteLine("**********************************************");
        //for döngüsü ile kullanıcıdan 7 adet veri alıyoruz ama indeks 0 dan başladığı için gösterirken 1 den gösteriyoruz
        for (int i = 0; i < 8; i++) 
        {
            //i ye + 1 ekleyerek görüntüyü 1 den başlatmış oluyoruz
            Console.WriteLine($"{i + 1}. Davetlinin Adı ve Soyadını Giriniz : ");
            string input = Console.ReadLine();
            //listeye Add ile girilen değerleri ekliyoruz
            guests.Add(input);
        }
        Console.WriteLine("! ! ! DAVETLİ LİSTESİ OLUŞTURULDU ! ! !");
        //foreach de listelemek için davetlinin yanına rakam yazmak istiyorum o yüzden sayac diye bir değişken tanımladım ve birden başlattım.
        int sayac = 1;
        foreach (string input in guests)
        {
            Console.WriteLine($"{sayac++} - {input} ");
        }
    }
}