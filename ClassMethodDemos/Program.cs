using System;

namespace ClassMethodDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();
            musteri1.Id = "100001";
            musteri1.Name = "Ahmet";
            musteri1.Age = 19;
            musteri1.Job = "-- Öğrenci\n";

            musteri musteri2 = new musteri();
            musteri2.Id = "10002";
            musteri2.Name = "Mustafa";
            musteri2.Age = 35;
            musteri2.Job = "-- Manavcı\n";

            musteri musteri3 = new musteri();
            musteri3.Id = "10003";
            musteri3.Name = "Aslı";
            musteri3.Age = 27;
            musteri3.Job = "-- Mimar\n";

            musteri musteri4 = new musteri();
            musteri4.Id = "10004";
            musteri4.Name = "Büşra";
            musteri4.Age = 72;
            musteri4.Job = "-- Emekli\n";

            musteri[] musteriler = new musteri[] { musteri1, musteri2, musteri3, musteri4 };
            musteriManager customermanager = new musteriManager();
            foreach (musteri musteri in musteriler)
            {
                customermanager.Add(musteri.Id, musteri.Name, musteri.Job, musteri.Age);
                customermanager.List(musteri.Id, musteri.Name, musteri.Job, musteri.Age);
                customermanager.Sil(musteri.Id, musteri.Name, musteri.Job, musteri.Age);
                Console.WriteLine("-->İşleminiz başarıyla tamamlanmıştır.\n");
            }
        }
    }
}