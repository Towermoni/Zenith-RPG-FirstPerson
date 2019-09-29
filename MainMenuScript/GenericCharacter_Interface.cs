using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GenericCharacter_Interface
{
    string Name { get; set; }
    int Health { get; set; }
    int[] Stats { get; set; }
    int[] Skills { get; set; }
    int[] Modifiers { get; set; }
    int Speed { get; set; }
    int Rnd { get; set; }

    //Objects
   // EnemyArmor enemyArmor { get; set; }

    // Methods
    int checkSkill(int skill, int difficulty);

    //void setArmor<A>(A eArmor) where A : IArmor;
}
