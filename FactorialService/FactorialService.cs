namespace FactorialService;
public class FactorialService
{
    public static int GetFactorialOf(int x)
    {
        if (x < 0)
        {
            throw new Exception("No negative values allowed.");
        }
        var factorial = 1;
        for (var i = 1; i <= x; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}