public class CountFactory
{
    public static Count containerAddition(List<string> cups, List<string> bottles)
    {
        var cupcount = 1;
        foreach (var cup in cups)
        {
            if (cup == "Cup")
                cupcount += 1;
            else
                cupcount -= 1;
        }

        var bottlecount = 1;
        foreach (var bottle in bottles)
        {
            if (bottle == "Bottle")
                bottlecount += 1;
            else
                bottlecount -= 1;
        }

        return new Count(cupcount, bottlecount);
    }

    public static Count containerSubtraction(List<string> cups, List<string> bottles)
    {
        var cupcount = 1;
        foreach (var cup in cups)
        {
            if (cup == "Cup")
                cupcount -= 1;
            else
                cupcount += 1;
        }
        var bottlecount = 1;
        foreach (var bottle in bottles)
        {
            if (bottle == "Bottle")
                bottlecount -= 1;
            else
                bottlecount += 1;
        }
        return new Count(cupcount, bottlecount);
    }
}