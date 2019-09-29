using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetStats : MonoBehaviour
{
    public GameObject statsParent;

    private int statNum;
    private int statMod;

    static private Text text;

    public Character character;

    private void Start()
    {
        //gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void calculateStats()
    {
        for (int i = 0; i < GameManager.Stats.Length; i++)
        {
            text = statsParent.gameObject.transform.GetChild(i).GetComponent<Text>();
            statMod = (System.Convert.ToInt32(text.text) - 10) / 2;
            statNum = System.Convert.ToInt32(text.text);
            GameManager.Stats[i] = statNum;
            GameManager.Modifiers[i] = statMod;
        }
    }
}
