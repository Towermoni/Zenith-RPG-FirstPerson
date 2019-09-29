using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatSword : MonoBehaviour, IWeapon
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
    public double CriticalRating { get; set; }
    public double CriticalChance { get; set; }
    public double Deflect { get; set; }
    public int Value { get; set; }
    public double rnd { get; set; }
    public double Weight { get; set; }

    public GreatSword()
    {
        ID = 001;
        Name = "Great Sword";
        Damage = 5;
        CriticalRating = 2;
        CriticalChance = .5;
        Deflect = 2;
        Value = 50;
        Weight = 15;
    }


    public double checkDamage(Character character)
    {
        rnd = Random.Range(1, 10);
        double damage = 0;

        if (rnd <= CriticalChance)
        {
            damage = (character.Modifiers[0] + Damage) * CriticalRating;
        }
        else
        {
            damage = character.Modifiers[0] + Damage;
        }

        return damage;
    }
}
