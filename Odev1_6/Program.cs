Console.Write("Bir sayi girin. O sayiya kadar tek ve cift sayilar ayri ayri toplanacak: ");
int sayi=Convert.ToInt32(Console.ReadLine());
int tekToplam = 0;
int ciftToplam = 0;
for(int i = 0; i < sayi+1; i++)
{
    if(i%2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}
Console.WriteLine();
Console.WriteLine("Tek sayilarin toplami: "+tekToplam+"          Cift sayilarin toplami: "+ciftToplam);
Console.WriteLine();
Console.WriteLine("Programi bitirmek icin Enter basin");
Console.ReadLine();