double[] prices = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
Func<double, double> vat = x => x * 1.2;
double[] pricesWithVat = prices.Select(vat).ToArray();
foreach (var price in pricesWithVat)
{
    Console.WriteLine($"{price:f2}");
}