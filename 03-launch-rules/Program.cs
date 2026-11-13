Console.WriteLine(CanLaunch(3, 50, true));
Console.WriteLine(CanLaunch(2, 50, true));
Console.WriteLine(CanLaunch(3, 49, true));
Console.WriteLine(CanLaunch(3, 50, false));
Console.WriteLine(CanLaunch(4, 80, true));

// TODO: Legg til de andre testkallene og refaktorer metoden.

static bool CanLaunch(int crewCount, int fuel, bool isHatchClosed)
{
if (crewCount < 3)
    {
    return false; 
    }

if (fuel < 50)
        {
        return false;
        }

if (!isHatchClosed)
    {
    return false;
    }
return true;
}
