class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if(time >= 6 && time < 11)
            Console.WriteLine("Günaydın");

        else if(time < 18)
            Console.WriteLine("İyi Günler");

        else
            Console.WriteLine("İyi Geceler");

        string sonuc = time <= 18 ? " İyi Günler" : "İyi Geceler";

        sonuc = time <= 6 && time < 11 ? "Günaydın" : time < 18 ? "İyi Günler" : " İyi Geceler";
            Console.WriteLine(sonuc);

        string s1 = "Bir sayının Girin: ";
        int sayi1;
        sayi1 = Convert.ToInt32(s1);


        if(sayi1 >= 2 && sayi1 <= 5)
            Console.WriteLine("Not Weird");
        
        else if(sayi1 >= 6 && sayi1 <= 20)
            Console.WriteLine("Weird");
        
        else
            Console.WriteLine("Not Weird");


    }
}