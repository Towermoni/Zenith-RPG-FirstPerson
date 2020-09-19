using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class InteractItem : MonoBehaviour
{
    [SerializeField]
    Camera playerCamera;

    [SerializeField]
    Text promptText;

    RaycastHit hit;
    LayerMask weaponMask;
    LayerMask armorMask;
    LayerMask itemMask;
    LayerMask chestMask;
    Ray ray;
    StreamReader sr;
    StreamReader sr1;
    StreamReader sr2;

    [SerializeField]
    GameObject background;

    [SerializeField]
    GameObject playerInventory;

    [SerializeField]
    GameObject chestInventory;

    [SerializeField]
    Text first;
    [SerializeField]
    Text second;
    [SerializeField]
    Text third;

    [SerializeField]
    Text first1;
    [SerializeField]
    Text second1;
    [SerializeField]
    Text third1;

    // Chest chest = new Chest();

    private string[] weaponsSelection;
    private string[] armorSelection;
    private string[] itemSelection;

    private string line;

    int inc;

    Dictionary<string, string> itemCollection = new Dictionary<string, string>();

    void Start()
    {
        inc = 0;


        //GameManager.testSettingWeapons();

        LongSword longSword = new LongSword();
        GreatSword greatSword = new GreatSword();

        //GameManager.weaponsCollection.Add("LongSword", longSword);
      //  GameManager.weaponsCollection.Add("GreatSword", greatSword);

       // sr = new StreamReader("C:\\Users\\Apozharsky\\Documents\\cvtcClasses\\Semester3\\GameDevelopment\\DungeonCrawler\\Assets\\TextFiles\\GeneralTextFiles\\InteractableWeapons.txt");
        // sr1 = new StreamReader("C:\\Users\\Apozharsky\\Documents\\cvtcClasses\\Semester3\\GameDevelopment\\DungeonCrawler\\Assets\\TextFiles\\GeneralTextFiles\\InteractableArmor.txt");
        sr2 = new StreamReader("C:\\Users\\Apozharsky\\Documents\\cvtcClasses\\Semester3\\GameDevelopment\\DungeonCrawler\\Assets\\TextFiles\\GeneralTextFiles\\InteractableItems.txt");
        line = sr2.ReadToEnd();

        string[] splitText = line.Split('\t');

        for (int i = 0; i < 30; i++)
        {
            itemCollection.Add(splitText[i], splitText[i+1]);   
            i++;
            i++;
        }

    }

    void Update()
    {
        ray = playerCamera.ViewportPointToRay(Vector3.one / 2f);
        weaponMask = LayerMask.GetMask("weapon");
        armorMask = LayerMask.GetMask("armor");
        itemMask = LayerMask.GetMask("item");
        chestMask = LayerMask.GetMask("chest");

        if (Physics.Raycast(ray, out hit, 10f, weaponMask))
        {
            promptText.text = itemCollection[hit.collider.tag];

            if(Input.GetKeyUp(KeyCode.E))
            {
                GameManager.storeWeapon(GameManager.weaponsCollection[hit.collider.tag], inc);

                Chest chest = new Chest(first, second, third);


                // Adds weapons to the player inventory
                GameManager.addWeaponToInventory("GreatSword", 0);
                GameManager.addWeaponToInventory("Dagger", 1);
                GameManager.addWeaponToInventory("LongSword", 2);

                //hit.collider.gameObject.SetActive(false);
                //inc++;
                //Debug.Log(GameManager.weaponsCollection[hit.collider.tag]);
                background.gameObject.SetActive(true);
                playerInventory.gameObject.SetActive(true);
                chestInventory.gameObject.SetActive(true);

                first.text = chest.weaponsArray[0].Name;
                second.text = chest.genericArray[0].Name;
                third.text = chest.armorArray[1].Name;

                first1.text = GameManager.weaponsArray[0].Name;
                second1.text = GameManager.itemArray[1].Name;
                third1.text = GameManager.armorArray[1].Name;

               // chest.showItems(first, second, third);
                //first.text = "Why won't";
                //second.text = "you";
                //third.text = "work";
            }
        }
        else if(Physics.Raycast(ray, out hit, 10f, armorMask))
        {
            promptText.text = itemCollection[hit.collider.tag];

            if (Input.GetKeyUp(KeyCode.E))
            {
                GameManager.storeWeapon(GameManager.weaponsCollection[hit.collider.tag], inc);
                hit.collider.gameObject.SetActive(false);
                inc++;
                Debug.Log(GameManager.weaponsCollection[hit.collider.tag]);
            }
        }
        else if (Physics.Raycast(ray, out hit, 10f, itemMask))
        {
            promptText.text = itemCollection[hit.collider.tag];

            if (Input.GetKeyUp(KeyCode.E))
            {
                GameManager.storeWeapon(GameManager.weaponsCollection[hit.collider.tag], inc);
                hit.collider.gameObject.SetActive(false);
                inc++;
                Debug.Log(GameManager.weaponsCollection[hit.collider.tag]);
            }
        }
        else if (Physics.Raycast(ray, out hit, 10f, chestMask))
        {
            promptText.text = itemCollection[hit.collider.tag];

            if (Input.GetKeyUp(KeyCode.E))
            {
                //background.gameObject.SetActive(true);
                //playerInventory.gameObject.SetActive(true);
                //chestInventory.gameObject.SetActive(true);
                //Chest.showItems(first, second, third);
                
            }
        }
        else
        {
            promptText.text = "";
        }


    }

    public void checkSelectedItem()
    {
        weaponsSelection = new string[3] { "LongSword", "GreatSword", "Dagger" };
        armorSelection = new string[2] { "Plate", "Leather" };
        itemSelection = new string[2] { "LockPick", "Book" };

        

    }
}
