Console.Write("Bir deger girin. Ekranda 5 defa gösterilecek: ");
string deger = Console.ReadLine();
Console.WriteLine();
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(deger);
}
Console.WriteLine();
Console.WriteLine("Programi bitirmek icin Enter basin");
Console.ReadLine();