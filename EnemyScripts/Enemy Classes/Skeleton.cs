using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour, GenericCharacter_Interface
{
    public int EnemyID { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int[] Stats { get; set; }
    public int[] Skills { get; set; }
    public int[] Modifiers { get; set; }
    public int Attack { get; set; }
    public int Speed { get; set; }
    public int Rnd { get; set; }

    EnemyArmor enemyArmor { get; set; }
    EnemyWeapon enemyWeapon { get; set; }

    public Skeleton(string name, int health)
    {
        Name = name;
        EnemyID = 0;
        Health = health;
        Stats = new int[] { 13, 10, 0, 10, 10, 10 };
        Modifiers = new int[] { 2, 0, 0, 0, 0, 0 };
        Skills = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        Speed = 10;

        enemyArmor = new EnemyArmor();
        enemyWeapon = new EnemyWeapon();
    }


    public int checkSkill(int skill, int difficulty)
    {
        throw new System.NotImplementedException();
    }

    public void getEnemyID(GameObject gameObject, Skeleton skeleton)
    {
       // Rnd = Random.RandomRange(0, 1000);
        skeleton.EnemyID = gameObject.GetInstanceID();
    }

    public int getHealth(Skeleton skeleton)
    {
        return skeleton.Health;
    }

    public EnemyArmor setArmor<A>(A eArmor) where A : IArmor
    {

        enemyArmor.Name = eArmor.Name;
        enemyArmor.Defense = eArmor.Defense;
        enemyArmor.Weight = eArmor.Weight;
        enemyArmor.Value = eArmor.Value;

        return enemyArmor;
    }

    public EnemyWeapon setWeapon<W>(W eWeapon) where W : IWeapon
    {
        enemyWeapon.Name = eWeapon.Name;
        enemyWeapon.Damage = eWeapon.Damage;
        enemyWeapon.CriticalRating = eWeapon.CriticalRating;
        enemyWeapon.CriticalChance = eWeapon.CriticalChance;
        enemyWeapon.Deflect = eWeapon.Deflect;
        enemyWeapon.Value = eWeapon.Value;

        return enemyWeapon;
    }

}
