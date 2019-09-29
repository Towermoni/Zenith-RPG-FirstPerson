using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollStats : MonoBehaviour
{
    public GameObject stats;
    private int rnd;
    private Text tempStat;
    private int total;
    public Text UItotal;
    private Text modTotal;
    public Text remainingNum;
    private GameManager gameManager;

    public int[] Stats { get; set; }
    public int[] Modifiers { get; set; }

    private void Start()
    {
        Stats = new int[6];
        Modifiers = new int[6];
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void rollStats()
    {
        

        total = 0;
        for (int i = 0; i < 6; i++)
        {
            rnd = Random.Range(8, 18);
            tempStat = stats.gameObject.transform.GetChild(i).GetComponent<Text>();
            modTotal = tempStat.gameObject.transform.GetChild(0).GetComponent<Text>();
            tempStat.text = System.Convert.ToString(rnd);
            modTotal.text = System.Convert.ToString((System.Convert.ToInt32(tempStat.text) - 10) / 2);
            total += System.Convert.ToInt32(tempStat.text);

        }
        UItotal.text = System.Convert.ToString(total);
        remainingNum.text = "0";

    }
}
