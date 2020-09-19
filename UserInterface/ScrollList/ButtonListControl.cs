using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListControl : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonTemplateName;

    [SerializeField]
    private GameObject buttonTemplateDamage;

    [SerializeField]
    private int[] intArray;

    private ShopInventory shopInventory;

    private List<GameObject> buttons;

    private void Start()
    {
        shopInventory = new ShopInventory();

        buttons = new List<GameObject>();
        //if (buttons.Count > 0)
        //{
        //    foreach(GameObject button in buttons)
        //    {
        //        Destroy(button.gameObject);
        //    }

        //    buttons.Clear();
        //}

        shopInventory.populateShopInventory();
    }
    
    public void setWeaponInventory()
    {
        foreach (GameObject button in buttons)
        {
            Destroy(button.gameObject);
        }

        foreach (IWeapon weapon in shopInventory.weaponInventory)
        {
            GameObject buttonName = Instantiate(buttonTemplateName) as GameObject;
            GameObject buttonDamage = Instantiate(buttonTemplateName) as GameObject;

            buttonName.SetActive(true);
            buttonDamage.SetActive(true);

            buttonName.GetComponent<ButtonListButton>().setText(weapon.Name);
            buttonDamage.GetComponent<ButtonListButton>().setText(System.Convert.ToString(weapon.Damage));

            buttonName.transform.SetParent(buttonTemplateName.transform.parent, false);
            buttonDamage.transform.SetParent(buttonTemplateName.transform.parent, false);

            buttons.Add(buttonName);
            buttons.Add(buttonDamage);

        }
    }

    public void setArmorInventory()
    {
        foreach (GameObject button in buttons)
        {
            Destroy(button.gameObject);
        }

        foreach (IArmor armor in shopInventory.armorInventory)
        {
            GameObject buttonName = Instantiate(buttonTemplateName) as GameObject;
            GameObject buttonDamage = Instantiate(buttonTemplateName) as GameObject;

            buttonName.SetActive(true);
            buttonDamage.SetActive(true);

            buttonName.GetComponent<ButtonListButton>().setText(armor.Name);
            buttonDamage.GetComponent<ButtonListButton>().setText(System.Convert.ToString(armor.Defense));

            buttonName.transform.SetParent(buttonTemplateName.transform.parent, false);
            buttonDamage.transform.SetParent(buttonTemplateName.transform.parent, false);

            buttons.Add(buttonName);
            buttons.Add(buttonDamage);
        }
    }

    public void setItemInventory()
    {
        foreach (Item item in shopInventory.itemInventory)
        {
            GameObject buttonName = Instantiate(buttonTemplateName) as GameObject;
            buttonName.SetActive(true);

            buttonName.GetComponent<ButtonListButton>().setText(item.Name);

            buttonName.transform.SetParent(buttonTemplateName.transform.parent, false);

        }
    }
        
    public void buttonClick(string myTextString)
    {
        Debug.Log(myTextString);
    }

    void GenButons()
    {

    }
}
