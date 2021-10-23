using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeekCount = new int[] { 0, 2, 5, 3, 7, 8, 4 };

        return lastWeekCount;
    }

    public int Today()
    {
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
