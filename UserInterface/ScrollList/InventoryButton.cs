using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{

    [SerializeField]
    private Text myString;

    public void setText(string btnText)
    {
        myString.text = btnText;
    }

}
