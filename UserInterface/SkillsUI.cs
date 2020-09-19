using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsUI : MonoBehaviour
{
    [SerializeField]
    GameObject skills;

    Text text;
    Text[] skillsArray;
    // Start is called before the first frame update
    void Start()
    {
        skillsArray = new Text[8];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showSkills()
    {

        for (int i = 0; i < 8; i++)
        {
            skills.gameObject.transform.GetChild(i).GetComponent<Text>().text = System.Convert.ToString(GameManager.Skills[i]);       }
        }

}
