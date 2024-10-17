try
{
    int n = int.Parse(Console.ReadLine());
    bool isTrue = (n % 3 != 0) && (n % 7 == 0) && (n % 10 == 0);
    Console.WriteLine($"The number {n} meets the conditions: {isTrue}");
}
catch
{

}