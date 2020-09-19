using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour, GenericCharacter_Interface
{
    // Character Class Fields
    private string cClass { get; set; }
    private int cExp { get; set; }

    // Interface
    public string Name { get; set; }
    public int Health { get; set; }
    public int Speed { get; set; }
    public int Armor { get; set; }
    public int Rnd { get; set; }

    // Interface arrays
    public int[] Stats { get; set; } = new int[6];
    public int[] Modifiers { get; set; } = new int[6];
    public int[] Skills { get; set; } = new int[8];

    // UI
    public GameObject statsParent;
    public GameObject skillsParent;
    public Text nameUI;
    public Text classUI;
    private Text text;

    public Character()
    {

    }

    public Character(string iName, string iClass, int iHealth,int[] iStats, int[] iModifiers, int[] iSkills, int iSpeed, int iExp)
    {
        Name = iName;
        cClass = iClass;
        Health = iHealth;
        Stats = iStats;
        Modifiers = iModifiers;
        Skills = iSkills;
        Speed = iSpeed;
        cExp = iExp;
    }

    public int checkSkill(int skill, int difficulty)
    {
        Rnd = Random.Range(8, 18);
        int check = Skills[skill] + Rnd;
        return check;
    }

    public void setName()
    {
        Name = nameUI.text;
    }

    public void setClass()
    {
        cClass = classUI.text;
    }

    public void calculateStats()
    {

        for (int i = 0; i < Stats.Length; i++)
        {
            text = statsParent.gameObject.transform.GetChild(i).GetComponent<Text>();
            Stats[i] = System.Convert.ToInt32(text.text);
            Modifiers[i] = (Stats[i] - 10) / 2;
        }

    }

    public void calculateSkills()
    {

        for (int i = 0; i < Skills.Length; i++)
        {
            
        }

    }


}