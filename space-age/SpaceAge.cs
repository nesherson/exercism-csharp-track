using System;

public class SpaceAge
{
    private double _seconds;
    public SpaceAge(int seconds)
    {
        _seconds = (double)seconds;
    }

    private double CalculateAge(double earthYears)
    {
        const double _earthDays = 365.25;
        double earthDays = earthYears * _earthDays;

        double ageInMinutes = _seconds / 60;
        double ageInHours = ageInMinutes / 60;
        double ageInDays = ageInHours / 24;
        double age = ageInDays / earthDays;

        return age;
    }

    public double OnEarth()
    {
        const double earthYears = 1.0;

        return CalculateAge(earthYears);
    }

    public double OnMercury()
    {
        const double earthYearsOnMercury = 0.2408467;

        return CalculateAge(earthYearsOnMercury);
    }

    public double OnVenus()
    {
        const double earthYearsOnVenus = 0.61519726;

        return CalculateAge(earthYearsOnVenus);
    }

    public double OnMars()
    {
        const double earthYearsOnMars = 1.8808158;

        return CalculateAge(earthYearsOnMars);
    }

    public double OnJupiter()
    {
        const double earthYearsOnJupiter = 11.862615;

        return CalculateAge(earthYearsOnJupiter);
    }

    public double OnSaturn()
    {
        const double earthYearsOnSaturn = 29.447498;

        return CalculateAge(earthYearsOnSaturn);
    }

    public double OnUranus()
    {
        const double earthYearsOnUranus = 84.016846;

        return CalculateAge(earthYearsOnUranus);
    }

    public double OnNeptune()
    {
        const double earthYearsOnNeptune = 164.79132;

        return CalculateAge(earthYearsOnNeptune);
    }
}