using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryControl : MonoBehaviour
{
    //private List<PlayerItem> playerInventory;

    [SerializeField]
    private GameObject buttonTemplate;
    [SerializeField]
    private GridLayoutGroup gridGroup;

    [SerializeField]
    private Sprite[] iconSprites;

    [SerializeField]
    private GameObject buttonTemplateName;

    [SerializeField]
    private GameObject buttonTemplateDamage;

    [SerializeField]
    private GameObject buttonTemplateWeight;

    [SerializeField]
    private GameObject buttonTemplateValue;

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
            GameObject buttonWeight = Instantiate(buttonTemplateName) as GameObject;
            GameObject buttonValue = Instantiate(buttonTemplateName) as GameObject;

            buttonName.SetActive(true);
            buttonDamage.SetActive(true);
            buttonWeight.SetActive(true);
            buttonValue.SetActive(true);

            buttonName.GetComponent<ButtonListButton>().setText(armor.Name);
            buttonDamage.GetComponent<ButtonListButton>().setText(System.Convert.ToString(armor.Defense));
            buttonWeight.GetComponent<ButtonListButton>().setText(System.Convert.ToString(armor.Weight));
            buttonValue.GetComponent<ButtonListButton>().setText(System.Convert.ToString(armor.Value));

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

    //void Start()
    //{
    //    playerInventory = new List<PlayerItem>();

    //    for (int i=0; i<100;i++)
    //    {
    //        PlayerItem newItem = new PlayerItem();
    //        newItem.iconSprite = iconSprites[Random.Range(0, iconSprites.Length)];

    //        playerInventory.Add(newItem);
    //    }
    //}

    //void GenInventory()
    //{

    //    foreach (PlayerItem newItem in playerInventory)
    //    {
    //        GameObject newButton = Instantiate(buttonTemplate) as GameObject;
    //        newButton.SetActive(true);

    //        newButton.GetComponent<InventoryButton>().setText("Bane?");
    //        newButton.transform.SetParent(buttonTemplate.transform.parent, false);
    //    }
    //}

    //public class PlayerItem
    //{
    //    public Sprite iconSprite;
    //}
}
