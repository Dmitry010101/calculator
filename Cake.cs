
namespace CakeOrder;

internal class countPrice
{
    public static int One, Two, Three, Four, Five, Six;
    public static int Result;

    public countPrice(int onePunParam, int twoPunParam, int threePunParam, int fourPunParam, int fivePunParam, int sixPunParam)
    {
        One = onePunParam;
        Two = twoPunParam;
        Three = threePunParam;
        Four = fourPunParam;
        Five = fivePunParam;
        Six = sixPunParam;
    }

    public static void CountingResult()
    {
        Result = One + Two + Three + Four + Five + Six;
        Console.WriteLine(Result);
    }
}