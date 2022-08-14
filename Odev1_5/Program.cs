Console.Write("Bir sayi girin (Tek/Cift kontrol): ");
int sayi=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(sayi%2 == 0)
{
    Console.WriteLine(sayi+" cift");
}
else
{
    Console.WriteLine(sayi + " tek");
}
Console.WriteLine();
Console.WriteLine("Programi bitirmek icin Enter basin");
Console.ReadLine();