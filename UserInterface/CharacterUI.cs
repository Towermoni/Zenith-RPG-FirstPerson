using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class CharacterUI : MonoBehaviour
{
    [SerializeField]
    public GameObject cover;

    [SerializeField]
    public FirstPersonController firstPersonController;

    private GameObject stats;
    private bool isOpened;
    private bool isPaused;
   // private Text text;

    private Text[] textUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.J) && isOpened == false)
        {
            cover.gameObject.SetActive(true);
            isOpened = true;
            isPaused = true;
            setStats();
            
        }
        else if (Input.GetKeyUp(KeyCode.J) && isOpened == true)
        {
            cover.gameObject.SetActive(false);
            isOpened = false;
            isPaused = false;
        }

        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

    }


    void setStats()
    {
        textUI = new Text[4];

        // stats = cover.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;

        textUI[1] = cover.transform.GetChild(0).GetChild(0).GetChild(1).GetChild(0).GetComponent<Text>();
        textUI[2] = cover.transform.GetChild(0).GetChild(0).GetChild(1).GetChild(1).GetComponent<Text>();
        textUI[3] = cover.transform.GetChild(0).GetChild(0).GetChild(1).GetChild(2).GetComponent<Text>();

        //textUI[1].text = GameManager.Name;
        //textUI[2].text = GameManager.className;
        textUI[3].text = "1";

        for (int i = 0; i < GameManager.Stats.Length; i++)
        {
            Debug.Log("Stats Length: " + GameManager.Stats.Length);
            textUI[0] = cover.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(i).GetComponent<Text>();
            textUI[0].text = System.Convert.ToString(GameManager.Stats[i]);
        }

        isOpened = false;
        isPaused = false;
    }
}
