namespace array_methods;
class Program
{
    static void Main(string[] args)
    {
        //Sort Method
        int[] sayi_dizisi={21,16,38,74,65,85,12};
        Console.WriteLine("######## Sırasız Liste");
        foreach (var sayi in sayi_dizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("######## Sırasız Liste");
        Array.Sort(sayi_dizisi);
          foreach (var sayi in sayi_dizisi)
        {
            Console.WriteLine(sayi);
        }
        //Clear Method
        Console.WriteLine("######## Clear");
        Array.Clear(sayi_dizisi,3,2);
           foreach (var sayi in sayi_dizisi)
        {
            Console.WriteLine(sayi);
        }
        //Reverse Method
        Console.WriteLine("######## Reverse");
        Array.Reverse(sayi_dizisi);
           foreach (var sayi in sayi_dizisi)
        {
            Console.WriteLine(sayi);
        }
        //IndexOf Method
        Console.WriteLine("######## IndexOf");
        Console.WriteLine(Array.IndexOf(sayi_dizisi,12));
        //Resize Method
        Console.WriteLine("######## IndexOf");
        Array.Resize<int>(ref sayi_dizisi,9);
        sayi_dizisi[8]=23;
        sayi_dizisi[7]=13;
          foreach (var sayi in sayi_dizisi)
        {
            Console.WriteLine(sayi);
        }
    }
}
