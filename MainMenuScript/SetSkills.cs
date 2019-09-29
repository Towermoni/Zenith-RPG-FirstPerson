using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSkills : MonoBehaviour
{

    public GameObject skillsParent;

    private int skillNum;

    static private Text text;

    public void calculateSkills()
    {
        for (int i = 0; i < GameManager.Skills.Length; i++)
        {
            text = skillsParent.gameObject.transform.GetChild(i).GetComponent<Text>();
            skillNum = System.Convert.ToInt32(text.text);
            GameManager.Skills[i] = skillNum;
        }
    }

}
