using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecreaseSkill : MonoBehaviour
{
    private int inc;
    private int totalNum;
    private Text stat;
    public Text total;

    public void changeSkill()
    {
        stat = this.gameObject.GetComponent<Text>();
        inc = System.Convert.ToInt32(stat.text);
        totalNum = System.Convert.ToInt32(total.text);
        if (inc > 0)
        {
            inc--;
            totalNum++;
            stat.text = System.Convert.ToString(inc);
            total.text = System.Convert.ToString(totalNum);
        }
    }
}
