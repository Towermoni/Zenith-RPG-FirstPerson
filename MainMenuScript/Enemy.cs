using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, GenericCharacter_Interface
{
    // Interface Fields
    public string Name { get; set; }
    public int Health { get; set; }
    public int Speed { get; set; }
    public int Armor { get; set; }
    public int Rnd { get; set; }

    //Interface Arrays
    public int[] Stats { get; set; }
    public int[] Skills { get; set; }
    public int[] Modifiers { get; set; }

    public Enemy(string eName, int eHealth, int[] eStats, int[] eSkills, int[] eModifiers, int eSpeed)
    {
        Name = eName;
        Health = eHealth;
        Stats = eStats;
        Skills = eSkills;
        Modifiers = eModifiers;
        Speed = eSpeed;
    }

    public int checkSkill(int skill, int difficulty)
    {
        Rnd = Random.Range(8, 18);
        int check = Skills[skill] + Rnd;
        return check;
    }

    //private double checkDamage(Character character, Weapon weapon)
    //{
    //    Rnd = Random.Range(8, 18);
    //    double damage = character.Modifiers[0] + weapon.wDamage + Rnd;

    //    return damage;
    //}

}
