Console.Write("Kac sayi toplanacak? ");
byte adet=Convert.ToByte(Console.ReadLine());
int toplam = 0;
for(int i=0; i<adet; i++)
{
    Console.Write(i+1+". sayi: ");
    int sayi=Convert.ToInt32(Console.ReadLine());
    toplam += sayi;
}
Console.WriteLine();
Console.WriteLine("Toplam: "+toplam);
Console.WriteLine();
Console.WriteLine("Programi bitirmek icin Enter basin");
Console.ReadLine();