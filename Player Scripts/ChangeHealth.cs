using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealth : MonoBehaviour
{

    public GameObject player;
    private double health;
    public RectTransform healthBar;
    // Start is called before the first frame update
    void Start()
    {
        health = 1.0;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            health -= .25;
            healthBar.sizeDelta = new Vector2(healthBar.sizeDelta.x - (float)45, healthBar.sizeDelta.y);
            Debug.Log("Health: " + health);
           
        }

        if (health == 0)
        {
            Debug.Log("You died");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        health -= .25;
        healthBar.sizeDelta = new Vector2(healthBar.sizeDelta.x - (float)45, healthBar.sizeDelta.y);
        Debug.Log("Health: " + health);
    }

}
