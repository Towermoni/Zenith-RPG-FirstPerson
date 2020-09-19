using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArmor : MonoBehaviour, IArmor
{
    public string Name { get; set; }
    public int Defense { get; set; }
    public double Weight { get; set; }
    public int Value { get; set; }

    public EnemyArmor()
    {
        Name = "";
        Defense = 0;
        Weight = 0;
        Value = 0;
    }

    public double preventDamage(double damage)
    {
        return damage - Defense;
    }
}
