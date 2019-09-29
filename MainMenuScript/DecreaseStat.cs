using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecreaseStat : MonoBehaviour, StatInterface
{
    private int inc;
    private int totalNum;
    private Text stat;
    public Text statMod;
    public Text total;

    public void changeStat()
    {
        stat = this.gameObject.GetComponent<Text>();
        inc = System.Convert.ToInt32(stat.text);
        totalNum = System.Convert.ToInt32(total.text);
        if (inc > 8)
        {
            inc--;
            totalNum++;
            stat.text = System.Convert.ToString(inc);
            total.text = System.Convert.ToString(totalNum);
            statMod.text = System.Convert.ToString((System.Convert.ToInt32(stat.text) - 10) / 2);
        }
    }
}
