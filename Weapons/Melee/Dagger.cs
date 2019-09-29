using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : MonoBehaviour, IWeapon
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
    public double CriticalRating { get; set; }
    public double CriticalChance { get; set; }
    public double Deflect { get; set; }
    public int Value { get; set; }
    public double Weight { get; set; }
    public double rnd { get; set; }

    public Dagger()
    {
        ID = 002;
        Name = "Dagger";
        Damage = 2;
        CriticalRating = 4;
        CriticalChance = 2;
        Deflect = .5;
        Value = 10;
        Weight = 5;
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
