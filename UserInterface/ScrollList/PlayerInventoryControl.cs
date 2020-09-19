using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryControl : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonTemplateName;

    private List<GameObject> buttons;

    // Start is called before the first frame update
    void Start()
    {
        buttons = new List<GameObject>();

        GameManager.weaponsArray1.Add(new LongSword());
        GameManager.weaponsArray1.Add(new GreatSword());
        GameManager.weaponsArray1.Add(new LongSword());
        GameManager.weaponsArray1.Add(new GreatSword());
        GameManager.weaponsArray1.Add(new Dagger());

        foreach (IWeapon weapon in GameManager.weaponsArray1 )
        {
            GameObject buttonName = Instantiate(buttonTemplateName) as GameObject;
            GameObject buttonDamage = Instantiate(buttonTemplateName) as GameObject;
            GameObject buttonWeight = Instantiate(buttonTemplateName) as GameObject;
            GameObject buttonValue = Instantiate(buttonTemplateName) as GameObject;

            buttonName.SetActive(true);
            buttonDamage.SetActive(true);
            buttonWeight.SetActive(true);
            buttonValue.SetActive(true);

            buttonName.GetComponent<ButtonListButton>().setText(weapon.Name);
            buttonDamage.GetComponent<ButtonListButton>().setText(System.Convert.ToString(weapon.Damage));
            buttonWeight.GetComponent<ButtonListButton>().setText(System.Convert.ToString(weapon.Weight));
            buttonValue.GetComponent<ButtonListButton>().setText(System.Convert.ToString(weapon.Value));

            buttonName.transform.SetParent(buttonTemplateName.transform.parent, false);
            buttonDamage.transform.SetParent(buttonTemplateName.transform.parent, false);
            buttonWeight.transform.SetParent(buttonTemplateName.transform.parent, false);
            buttonValue.transform.SetParent(buttonTemplateName.transform.parent, false);

            buttons.Add(buttonName);
            buttons.Add(buttonDamage);
            buttons.Add(buttonWeight);
            buttons.Add(buttonValue);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
