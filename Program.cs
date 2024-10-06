namespace Q9;
class Program
{
    static void Main(string[] args)
    {
        decimal totalSales = 0;
        decimal sales = 0;
        int storeCount = 0;
        string message = " ";

        string path = @"../../../sales.txt";

        string[] fileContents = File.ReadAllLines(path);

        Console.WriteLine("Sales Report");
        Console.WriteLine("Store ID\tSales\t\t Performance");
   
        foreach(string line in fileContents)
        {
            string[] data = line.Split(',');

            string storeID = data[0];
            sales = decimal.Parse(data[1]);

            if (sales < 1000)
            {
                message = "Needs attention";
            }
            else if (sales > 1001 && sales < 1999)
            {
                message = "Moderate";
            }
            else if (sales > 2000)
            {
                message = "Very good";
            }

            Console.WriteLine($"\n{storeID}\t\t{sales}\t\t{message}");

            totalSales += sales;
            storeCount++;
        }

        Console.WriteLine($"\nTotal Sales : {totalSales}");
        Console.WriteLine($"Average Sales : {totalSales/storeCount}");
    }
}

