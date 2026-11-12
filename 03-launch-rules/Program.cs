Console.WriteLine(CanLaunch(3, 50, true));
// TODO: Legg til de andre testkallene og refaktorer metoden.
static bool CanLaunch(int crewCount, int fuel, bool isHatchClosed)
{
    if (crewCount >= 3)
    {
        if (fuel >= 50)
        {
            if (isHatchClosed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}
