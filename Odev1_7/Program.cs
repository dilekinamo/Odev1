Console.WriteLine("10 tane sayi girin. 50´den kücük olanlar gösterilecek: ");
int[] sayiArray=new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write(i + 1 + ". sayi:");
    sayiArray[i]= Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < 10; i++)
{
    if (sayiArray[i] < 50)
    {
        Console.Write(sayiArray[i]);
        Console.Write(' ');
    }
}
Console.WriteLine();Console.WriteLine();
Console.WriteLine("Programi bitirmek icin Enter basin");
Console.ReadLine();