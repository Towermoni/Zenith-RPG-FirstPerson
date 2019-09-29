using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterArmor : MonoBehaviour, IArmor
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string armorName { get; set; }
    public int Defense { get; set; }
    public double Weight { get; set; }
    public int Value { get; set; }

    public CharacterArmor()
    {
        armorName = "";
        Defense = 0;
        Weight = 0;
        Value = 0;
    }

    public double preventDamage(double damage)
    {
        return damage - Defense;
    }

}
