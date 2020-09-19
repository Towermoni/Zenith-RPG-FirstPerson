using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    Random rnd = new Random();
    StreamReader srWeapon;
    StreamReader srArmor;
    StreamReader srItem;
    string line;

    [SerializeField]
     Text first;
    [SerializeField]
    Text second;
    [SerializeField]
    Text third;

    int randNum;

    private string[] weaponsSelection;
    private string[] armorSelection;
    private string[] itemSelection;
    private string[] genericSelection;

    //  string[] splitWeapon;

    //static public ArrayList weaponInventory = new ArrayList();
    private ArrayList chestInventory = new ArrayList();

    private ArrayList inventoryPanels = new ArrayList();

  //  public Dictionary<string, Object> genericCollection = new Dictionary<string, Object>();

    public Dictionary<string, IWeapon> weaponsCollection = new Dictionary<string, IWeapon>();
    public Dictionary<string, IArmor> armorCollection = new Dictionary<string, IArmor>();
    public Dictionary<string, Item> itemCollection = new Dictionary<string, Item>();

    public Dictionary<string, IGeneric> genericCollection = new Dictionary<string, IGeneric>();

    //public IG[] genericArray = new Object[3];

    public List<IGeneric> genericArray = new List<IGeneric>();

    public IWeapon[] weaponsArray = new IWeapon[3];
    public IArmor[] armorArray = new IArmor[3];
    public Item[] itemArray = new Item[2];

    //  public IWeapon[] weaponinventory = new IWeapon[7];

    int inc = 0;

    public Chest(Text first, Text second, Text third)
    {

        //Random r = new Random();

        //LongSword longSword = new LongSword();
        //GreatSword greatSword = new GreatSword();
        //Dagger dagger = new Dagger();

        //setWeapon(longSword, "LongSword");
        //setWeapon(greatSword, "GreatSword");
        //setWeapon(dagger, "Dagger");

        // for (int i = 0; i < 3; i++)
        //  {
        //weaponsArray[i] = GameManager.weaponsCollection[splitWeapon[i]];
        //weaponsArray[0] = longSword; //GameManager.weaponsCollection[splitWeapon[i]];
        //weaponsArray[1] = greatSword;
        //weaponsArray[2] = dagger;

        setWeapons();





      //  }

        //for (int i = 0; i < System.Convert.ToInt32(rnd); i++)
        //{
        //    chestInventory.Add(GameManager.weaponsCollection[splitWeapon[System.Convert.ToInt32(rnd)]]);
        //}

    }

    //static public void setWeapon<W>(W iWeapon, string wName) where W : IWeapon
    //{
    //    weaponsCollection.Add(wName, iWeapon);
    //}


    void setWeapons()
    {
        // Stores names for searching in dictionary

        // Classes objects used in dictionary
        Plate plate = new Plate();
        Leather leather = new Leather();

        LongSword longSword = new LongSword();
        GreatSword greatSword = new GreatSword();
        Dagger dagger = new Dagger();

        LockPick lockPick = new LockPick();
        Book book = new Book();

        weaponsSelection = new string[3] { "LongSword", "GreatSword", "Dagger" };
        armorSelection = new string[2] { "Plate", "Leather" };
        itemSelection = new string[2] { "LockPick", "Book" };
        genericSelection = new string[3] { "LongSword", "Plate", "LockPick" };

       // genericCollection.Add("LongSword", longSword);
       // genericCollection.Add("Plate", plate);
        genericCollection.Add("LockPick", lockPick);

        // Add objects to each respective dictionary
        weaponsCollection.Add("LongSword", longSword);
        weaponsCollection.Add("GreatSword", greatSword);
        weaponsCollection.Add("Dagger", dagger);

        armorCollection.Add("Plate", plate);
        armorCollection.Add("Leather", leather);

        itemCollection.Add("LockPick", lockPick);
        itemCollection.Add("Book", book);


        // Add items into chest array based on dictionary keys found in the selection arrays
        for (int i = 0; i < weaponsCollection.Count; i++)
        {
            weaponsArray[i] = weaponsCollection[weaponsSelection[System.Convert.ToInt32(Random.Range(0,weaponsCollection.Count))]];
        }
        for (int i = 0; i < armorCollection.Count; i++)
        {
            armorArray[i] = armorCollection[armorSelection[System.Convert.ToInt32(Random.Range(0,armorCollection.Count))]];
        }
        for (int i = 0; i < itemCollection.Count; i++)
        {
            itemArray[i] = itemCollection[itemSelection[System.Convert.ToInt32(Random.Range(0,itemCollection.Count))]];
        }
        for (int i = 0; i < itemCollection.Count; i++)
        {
            genericArray[i] = genericCollection[genericSelection[System.Convert.ToInt32(Random.Range(0, genericCollection.Count))]];
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        GameManager.setWeaponsInChest();


        srWeapon = new StreamReader("C:\\Users\\Apozharsky\\Documents\\cvtcClasses\\Semester3\\GameDevelopment\\DungeonCrawler\\Assets\\TextFiles\\GeneralTextFiles\\ChestWeapons.txt");
        //srArmor = new StreamReader("");
        //srItem = new StreamReader("");

        line = srWeapon.ReadToEnd();

        // GameManager.testSettingWeapons();

        LongSword longSword = new LongSword();
        GreatSword greatSword = new GreatSword();
        Dagger dagger = new Dagger(); 

        string[] splitWeapon = new string[3] { "LongSword", "GreatSword", "Dagger" };
        string[] splitArmor = line.Split('\t');
        string[] splitItem = line.Split('\t');

        weaponsCollection.Add("LongSword", longSword);
        weaponsCollection.Add("GreatSword", greatSword);
        weaponsCollection.Add("Dagger", dagger);

        weaponsArray[0] = weaponsCollection["LongSword"];
        weaponsArray[1] = weaponsCollection["GreatSword"];
        weaponsArray[2] = weaponsCollection["Dagger"];


        for (int i = 0; i < splitWeapon.Length; i++)
        {
            Debug.Log(splitWeapon[i]);
        }

        inc = 2;

        for (int i = 0; i < GameManager.weaponsCollection.Count; i++)
        {
            //   Debug.Log("Is inside the array: " + GameManager.weaponsCollection["LongSword"].Name);
            //   Debug.Log("Is inside the array: " + GameManager.weaponsCollection["GreatSword"].Name);
            //   Debug.Log("Is inside the array: " + GameManager.weaponsCollection["Dagger"].Name);
        }

        for (int i = 0; i < inc; i++)
        {
           // Debug.Log("Found Weapon: " + GameManager.weaponsArray[i].Name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showItems(Text first, Text second, Text third)
    {
        //for (int i = 0; i < weaponsArray.Length; i++)
        //{
        //    //inventoryPanels.Add();


        //}
       Chest chest = new Chest(first, second, third);


        //first.text = chest.weaponsArray[0].weaponName;
        //second.text = chest.weaponsArray[1].weaponName;
        //third.text = chest.weaponsArray[2].weaponName;

        //Debug.Log(chest.armorArray[0].armorName);

        first.text = chest.armorArray[0].Name;
        second.text = chest.armorArray[1].Name;
        //third.text = chest.armorArray[2].armorName;
    }

}
