using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{ 
    //string weaponName { get; set; }
    string Name { get; set; }
    int Damage { get; set; }
    double CriticalRating { get; set; }
    double CriticalChance { get; set; }
    double Deflect { get; set; }
    int Value { get; set; }
    double Weight { get; set; }
    double rnd { get; set; }

}
