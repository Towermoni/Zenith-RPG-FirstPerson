using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFinishedCharacter : MonoBehaviour
{

    public GameObject statNumParent;
    public GameObject statModParent;
    public GameObject skillParent;

    [SerializeField]
    Text characterName;

    [SerializeField]
    Text className;

    [SerializeField]
    Text health;

    [SerializeField]
    Image image;
    // public GameObject baseStatsParent;
    private Text tempStatUI;

    void Start()
    {
        
    }

    // Update is called once per frame

    public void showCharacterInfo()
    {
        characterName.text = "Zenith";
        className.text = System.Convert.ToString(GameManager.className);
        health.text = System.Convert.ToString(GameManager.Health);
        


        for (int i = 0; i < GameManager.Skills.Length; i++)
        {
            Debug.Log("This works too!");
            tempStatUI = skillParent.gameObject.transform.GetChild(i).GetComponent<Text>();
            tempStatUI.text = System.Convert.ToString(GameManager.Skills[i]);
        }
        for (int i = 0; i < GameManager.Stats.Length; i++)
        {
            Debug.Log("It works!");
            tempStatUI = statNumParent.gameObject.transform.GetChild(i).GetComponent<Text>();
            tempStatUI.text = System.Convert.ToString(GameManager.Stats[i]);

            tempStatUI = statModParent.gameObject.transform.GetChild(i).GetComponent<Text>();
            tempStatUI.text = System.Convert.ToString(GameManager.Modifiers[i]);
        }
    }
}
