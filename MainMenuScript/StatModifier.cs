using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatModifier : MonoBehaviour
{
    public Text stat;
    public Text statMod;

    public void ModifyStats()
    {
       Debug.Log(System.Convert.ToString((System.Convert.ToInt32(stat.text) - 10) / 2));
    }

}
