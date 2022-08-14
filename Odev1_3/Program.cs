Console.Write("0 ve 10 arasindaki sayilarin toplami (0 ve 10 dahil): ");
byte toplam = 0;
for(byte i = 0; i < 11; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);
Console.WriteLine();
Console.WriteLine("Programi bitirmek icin Enter basin");
Console.ReadLine();