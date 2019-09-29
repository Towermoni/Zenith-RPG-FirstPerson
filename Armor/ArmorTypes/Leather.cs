using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leather : MonoBehaviour, IArmor
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Defense { get; set; }
    public double Weight { get; set; }
    public int Value { get; set; }

    public Leather()
    {
        Name = "Leather";
        Defense = 1;
        Weight = 10.00;
        Value = 30;
    }

    public double preventDamage(double damage)
    {
        return damage - Defense;
    }

}
