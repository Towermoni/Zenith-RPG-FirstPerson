using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour, IArmor
{
    public int ID { get; set; }
    public string Name { get; set; }
    //public string armorName { get; set; }
    public int Defense { get; set; }
    public double Weight { get; set; }
    public int Value { get; set; }

    public Plate()
    {
        Name = "Plate";
        Defense = 4;
        Weight = 20.00;
        Value = 75;
    }

    public double preventDamage(double damage)
    {
        return damage - Defense;
    }
}
