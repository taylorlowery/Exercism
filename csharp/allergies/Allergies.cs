using System;
using System.Collections.Generic;
using System.Linq;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private byte _mask { get; set; }

    public Allergies(int mask)
    {
        _mask = (byte)mask;
    }

    // determine if person has allergies
    public bool IsAllergicTo(Allergen allergen) => (_mask & (byte)allergen) == (byte)allergen;

    // List of allergens to which person is allergic
    public IEnumerable<Allergen> List() => Enum.GetValues(typeof(Allergen)).Cast<Allergen>().Where(IsAllergicTo);
}