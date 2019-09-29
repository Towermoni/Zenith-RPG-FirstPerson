using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBaseClassStats : MonoBehaviour
{

    private Button tempName;
    private Text tempText;

    [SerializeField]
    int speed;
    [SerializeField]
    int health;

    public void setBaseStats()
    {
        tempName = this.GetComponent<Button>();
        GameManager.className = tempName.name;

        // tempText = this.gameObject.transform.GetChild(1).GetComponent<Text>();
        GameManager.Health = health;
        GameManager.Speed = speed;
        GameManager.Exp = 0;

        Debug.Log(GameManager.Health);
        Debug.Log(GameManager.Speed);
        Debug.Log(GameManager.Exp);
    }

}
