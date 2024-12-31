internal class Program
{
    // Część III. Test aplikacji konsolowej
    static void Main(string[] args)
    {
        List<int> list100 = new List<int>();
        Random random = new Random();
        
        for (int i = 0; i < 100; i++)
            list100.Add(random.Next(1000));
    
        Console.WriteLine("Elements of a sorted array:");
        bubbleSort(list100);
    }
    
    // Część I. Aplikacja konsolowa
    static void bubbleSort(List<int> list)
    {
        int biggestNumber = 0;

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i; j >= 0; j--)
            {
                if (list[j] > list[j + 1])
                {
                    biggestNumber = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = biggestNumber;
                }
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
            if (list.Count()-1 == i) break;
            Console.Write(", ");
        }
    }
}