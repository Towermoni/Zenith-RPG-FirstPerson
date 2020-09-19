using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponInventory : MonoBehaviour
{
    [SerializeField]
    public GameObject swordInventory;
    [SerializeField]
    public GameObject stats;

    [SerializeField]
    public Text cost;

    [SerializeField]
    public Text damage;

    [SerializeField]
    public Text weight;


    static private Text inventoryNum;
    private Text tempStat;
    GameManager gameManager;

    LongSword longSword;
    GreatSword greatSword;

    Plate plate;

    private void Start()
    {
        setWeaponInventory();
    }


    public void checkWeaponStats(int i)
    {
      //  cost.text = System.Convert.ToString(GameManager.weaponinventory[i].Damage);
    
        //tempStat = stats.gameObject.transform.GetChild(1).GetComponent<Text>();
     //   damage.text = System.Convert.ToString(GameManager.weaponinventory[i].Weight);

       // tempStat = stats.gameObject.transform.GetChild(2).GetComponent<Text>();
      //  weight.text = System.Convert.ToString(GameManager.weaponinventory[i].Cost);
    }

    public void setWeaponInventory()
    {

        //longSword = new LongSword();
        //greatSword = new GreatSword();

        //GameManager.storeWeapon(longSword, 0);
        //GameManager.storeWeapon(longSword, 1);

        //for (int i = 0; i < GameManager.weaponinventory.Length; i++)
        //{
        //    inventoryNum = swordInventory.gameObject.transform.GetChild(i).GetChild(0).GetComponent<Text>();
        //    inventoryNum.text = GameManager.weaponinventory[i].weaponName;
        //}

      //  cost.text = System.Convert.ToString(GameManager.weaponinventory[0].Damage);

        //tempStat = stats.gameObject.transform.GetChild(1).GetComponent<Text>();
      //  damage.text = System.Convert.ToString(GameManager.weaponinventory[0].Weight);

        // tempStat = stats.gameObject.transform.GetChild(2).GetComponent<Text>();
      //  weight.text = System.Convert.ToString(GameManager.weaponinventory[0].Cost);
    }

    public void setArmorInventory()
    {

        plate = new Plate();

        GameManager.storeArmor(plate, 0);

        //for (int i = 0; i < GameManager.weaponinventory.Length; i++)
        //{
        //    inventoryNum = swordInventory.gameObject.transform.GetChild(i).GetChild(0).GetComponent<Text>();
        //    inventoryNum.text = GameManager.weaponinventory[i].weaponName;
        //}
    }
    
}
