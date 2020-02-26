using System;
using System.Collections.Generic;
using System.Linq;

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
    public IEnumerable<Allergen> Allergens = (IEnumerable<Allergen>)Enum.GetValues(typeof(Allergen));

    int _mask { get; set; }
    int Mask => _mask;

    public Allergies(int mask)
    {
        if (mask > Allergens.Sum(a => (int)a))
        {
            mask = mask - HighestPowerOfTwoLessThanNum(mask);
        }

        _mask = mask;
    }

    // determine if person has allergies
    public bool IsAllergicTo(Allergen allergen) => this.List().Contains(allergen);

    // List of allergens to which person is allergic
    public Allergen[] List()
    {
        var allergens = new List<Allergen>();

        int mask = Mask;

        foreach (var allergen in Allergens.OrderByDescending(a => (int)a))
        {
            if (mask >= (int)allergen)
            {
                allergens.Add(allergen);
                mask -= (int)allergen;
            }
        }
        
        return allergens.OrderBy(a => (int)a).ToArray();
    }

    public int HighestPowerOfTwoLessThanNum(int num) => (int)(Enumerable.Range(0, num)
                                                            .Select(s => Math.Pow(2, s))
                                                                .TakeWhile(p => p < num)
                                                                    .Max());
}