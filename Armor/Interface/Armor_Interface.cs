using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IArmor
{
    string Name { get; set; }
    int Defense { get; set; }
    double Weight { get; set; }
    int Value { get; set; }

    double preventDamage(double damage);
}
