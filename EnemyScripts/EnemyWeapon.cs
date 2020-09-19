using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour, IWeapon
{

    public string Name { get; set; }
    public int Damage { get; set; }
    public double CriticalRating { get; set; }
    public double CriticalChance { get; set; }
    public double Deflect { get; set; }
    public int Value { get; set; }
    public double Weight { get; set; }
    public double rnd { get; set; }

    public EnemyWeapon()
    {
        Name = "";
        Damage = 0;
        CriticalRating = 0;
        CriticalChance = 0;
        Deflect = 0;
        Value = 0;
        Weight = 0;
    }

    public double checkDamage(Enemy enemy)
    {
        rnd = Random.Range(1, 10);
        double damage = 0;

        if (rnd <= CriticalChance)
        {
            damage = (enemy.Modifiers[0] + Damage) * CriticalRating;
        }
        else
        {
            damage = enemy.Modifiers[0] + Damage;
        }

        return damage;
    }
}
