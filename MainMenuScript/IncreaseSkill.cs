using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseSkill : MonoBehaviour
{
    private int inc;
    private int totalNum;
    private Text skill;
    public Text total;

    public void changeSkill()
    {
        skill = this.gameObject.GetComponent<Text>();
        inc = System.Convert.ToInt32(skill.text);
        totalNum = System.Convert.ToInt32(total.text);

        if (totalNum > 0)
        {
            inc++;
            totalNum--;
            skill.text = System.Convert.ToString(inc);
            total.text = System.Convert.ToString(totalNum);
        }

    }
}
