namespace DailySpendingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = new List<string>();
            bool isCompleted, isContinue = true;
            string shop, product;
            int amount;
            double price, total = 0, grandTotal = 0;

            Console.Write("Hoşgeldiniz...\nİsminizi giriniz\t\t: ");
            string name = Console.ReadLine();
            Console.Write("Merhaba {0} alışverişe hazır mısın?\n(Evet ise e/E - Hayır ise h/H)\t: ",name);
            string entrance = Console.ReadLine();
            isCompleted = (entrance.ToLower() == "e") ? false : true;
            Console.WriteLine("\n***************************************");

            while (!isCompleted)
            {
                Console.Write("Alışveriş yapacağınız mağaza\t: ");
                shop = Console.ReadLine();
                while (isContinue)
                {
                    Console.Write("Aldığınız ürün\t\t\t: ");
                    product = Console.ReadLine();
                    Console.Write("Kaç adet aldınız\t\t: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ürünün fiyatı\t\t\t: ");
                    price = Convert.ToDouble(Console.ReadLine());
                    total = amount * price;
                    grandTotal += total;
                    shopingList.Add($"{shop} isimli mağazadan {amount} adet {product} ürününü {price} TL fiyatla {total} TL'ye aldınız...");
                    Console.Write("Mağazada alışverişe devam etmek ister misiniz?\n(Evet is e/E - Hayır ise h/H)\t: ");
                    entrance = Console.ReadLine();
                    Console.WriteLine("\n***************************************");
                    isContinue = entrance.ToLower() == "e" ? true : false;

                }

                Console.WriteLine("Mağazamıza yeniden bekleriz. İyi günler...\n");
                Console.Write("Başka bir mağazaya girecek misiniz?\n(Evet ise e/E - Hayır ise h/H)\t: ");
                entrance = Console.ReadLine();
                isCompleted = entrance == "e" ? false : true;
                isContinue = true;
            }
            Console.WriteLine("Hoşçakal {0}...", name);

            Console.WriteLine("\n=============== ALIŞVERİŞ ÖZETİ===================\n");
            foreach (string item in shopingList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nBugün yaptığınız alışveriş sonucunda toplam olarak {grandTotal} TL harcama yaptınız...");
            
        }
    }
}