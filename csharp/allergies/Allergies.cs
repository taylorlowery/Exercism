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
    IEnumerable<Allergen> Allergens = (IEnumerable<Allergen>)Enum.GetValues(typeof(Allergen));

    int _mask { get; set; }
    byte Mask => (byte)_mask;

    public Allergies(int mask)
    {
        _mask = mask;
    }

    // determine if person has allergies
    public bool IsAllergicTo(Allergen allergen) => this.List().Contains(allergen);

    // List of allergens to which person is allergic
    public IEnumerable<Allergen> List()
    {
        foreach (var allergen in Allergens)
        {
            if ((Mask & (byte)allergen) > 0)
            {
                yield return allergen;
            }
        }
    }
}


// Below here is my original solution, which does not use bitwise operators
// I keep it here as a cautionary tale for those who follow
//public class Allergies
//{
//    IEnumerable<Allergen> Allergens = (IEnumerable<Allergen>)Enum.GetValues(typeof(Allergen));

//    int _mask { get; set; }
//    int Mask => _mask;

//    public Allergies(int mask)
//    {
//        // if the mask is higher than the sum of all allergens
//        if (mask > Allergens.Sum(a => (int)a))
//        {
//            mask = mask - HighestPowerOfTwoLessThanNum(mask);
//        }

//        _mask = mask;
//    }

//    // determine if person has allergies
//    public bool IsAllergicTo(Allergen allergen) => this.List().Contains(allergen);

//    // List of allergens to which person is allergic
//    public Allergen[] List()
//    {
//        var allergens = new List<Allergen>();

//        int mask = Mask;

//        foreach (var allergen in Allergens.OrderByDescending(a => (int)a))
//        {
//            if (mask >= (int)allergen)
//            {
//                allergens.Add(allergen);
//                mask -= (int)allergen;
//            }
//        }

//        return allergens.OrderBy(a => (int)a).ToArray();
//    }

//    public int HighestPowerOfTwoLessThanNum(int num) => (int)(Enumerable.Range(0, num)
//                                                            .Select(s => Math.Pow(2, s))
//                                                                .TakeWhile(p => p < num)
//                                                                    .Max());
//}