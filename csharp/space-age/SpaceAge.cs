using System;
using System.Collections.Generic;

public class SpaceAge
{
    private int _seconds;
    private int _secondsInEarthYear = 31557600;

    private Dictionary<string, double> orbitalPeriods = new Dictionary<string, double>{
        {"Mercury", 0.2408467},
        {"Venus", 0.61519726},
        {"Earth", 1.0},
        {"Mars", 1.8808158},
        {"Jupiter", 11.862615},
        {"Saturn", 29.447498},
        {"Uranus", 84.016846},
        {"Neptune", 164.79132}
    };

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double AgeInSpace(string planet)
    {
        if (orbitalPeriods.ContainsKey(planet))
        {
            double ageOnPlanet = _seconds / (_secondsInEarthYear * orbitalPeriods[planet]);
            double ageRounded = Math.Round(ageOnPlanet, 2);
            return ageRounded;
        }
        else
        {
            throw new ArgumentException("No such planet in our solar system");
        }
    }


    public double OnEarth()
    {
        return AgeInSpace("Earth");
    }

    public double OnMercury()
    {
        return AgeInSpace("Mercury");
    }

    public double OnVenus()
    {
        return AgeInSpace("Venus");
    }

    public double OnMars()
    {
        return AgeInSpace("Mars");
    }

    public double OnJupiter()
    {
        return AgeInSpace("Jupiter");
    }

    public double OnSaturn()
    {
        return AgeInSpace("Saturn");
    }

    public double OnUranus()
    {
        return AgeInSpace("Uranus");
    }

    public double OnNeptune()
    {
        return AgeInSpace("Neptune");
    }
}