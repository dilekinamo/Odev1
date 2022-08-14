Console.Write("Hangi sayiya kadar 0´dan baslayarak toplansin? ");
int sayi=Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for(int i = 0; i < sayi+1; i++)
{
    toplam += i;
}
Console.WriteLine("Sonuc: "+toplam);
Console.WriteLine();
Console.WriteLine("Programi bitirmek icin Enter basin");
Console.ReadLine();