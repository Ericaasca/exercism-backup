class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay[^1];

    public void IncrementTodaysCount() => birdsPerDay[^1] = birdsPerDay[^1] + 1;

    public bool HasDayWithoutBirds() => Array.Exists(birdsPerDay, element => element == 0);

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            totalBirds += birdsPerDay[i];
        }
        return totalBirds;
    }

    public int BusyDays()
    {
        int busyDayCount = 0;
        foreach (int birdVisits in birdsPerDay)
        {
            if (birdVisits >= 5)
            {
                busyDayCount += 1;
            }
        }
        return busyDayCount;
    }
}
