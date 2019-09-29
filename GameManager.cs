using UnityEngine.SceneManagement;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    // Fields
    static public string Name { get; set; }
    static public int Health { get; set; }
    static public int Speed { get; set; }
    public int Rnd { get; set; }
    static public string className { get; set; }
    static public int Exp { get; set; }

    // Arrays
    static public int[] Stats = new int[6] { 0, 0, 0, 0, 0, 0 };
    static public int[] Modifiers = new int[6] { 0, 0, 0, 0, 0, 0 };
    static public int[] Skills = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

    // Character objects

    //static public ArrayList weaponInventory = new ArrayList();
    //static public ArrayList armorInventory = new ArrayList();

    // The following three arrays holds all of the available items in the game
    static public Dictionary<string, IWeapon> weaponsCollection = new Dictionary<string, IWeapon>();
    static public Dictionary<string, IArmor> armorCollection = new Dictionary<string, IArmor>();
    static public Dictionary<string, Item> itemCollection = new Dictionary<string, Item>();

    //static public IArmor[] armorCollection = new IArmor[2];
    // The following three arrays represent the items the player has in his/her inventory
    //static public CharacterArmor[] armorInventory = new CharacterArmor[7];
    //static public IWeapon[] weaponinventory = new IWeapon[7];

    // Current weapons held by player (Convert to Array list)
    static public IWeapon[] weaponsArray = new IWeapon[7];
    static public IArmor[] armorArray = new IArmor[7];
    static public Item[] itemArray = new Item[7];

    static public List<IWeapon> weaponsArray1 = new List<IWeapon>();

    static public List<IWeapon> playerWeaponsArray = new List<IWeapon>();

    static public IArmor[] armorArray1 = new IArmor[7];
    static public Item[] itemArray1 = new Item[7];

    // The following three objects represent the items the player has currently equipped
    static public CharacterArmor characterArmor = new CharacterArmor();
    static public CharacterWeapon characterWeapon = new CharacterWeapon();

    static public string[] weaponsSelection;
    static public string[] armorSelection;
    static public string[] itemSelection;

    private void Start()
    {
        LongSword longSword = new LongSword();
        GreatSword greatSword = new GreatSword();
        Dagger dagger = new Dagger();

        Plate plate = new Plate();
        Leather leather = new Leather();

        LockPick lockPick = new LockPick();
        Book book = new Book();

        weaponsArray1.Add(new LongSword());
        weaponsArray1.Add(new GreatSword());
        weaponsArray1.Add(new LongSword());
        weaponsArray1.Add(new GreatSword());
        weaponsArray1.Add(new Dagger());

        playerWeaponsArray.Add(new LongSword());
        playerWeaponsArray.Add(new GreatSword());

        //itemCollection.Add("LongSword", longSword);
        //itemCollection.Add("GreatSword", greatSword);
        //itemCollection.Add("Dagger", dagger);
        //itemCollection.Add("Plate", plate);
        //itemCollection.Add("Plate", leather);

        // Sets up weapons to be stored inside weaponsCollection dictionary
        weaponsSelection = new string[3] { "LongSword","GreatSword","Dagger"};
        armorSelection = new string[2] { "Plate", "Leather"};
        itemSelection = new string[2] { "LockPick", "Book" };

        weaponsCollection.Add("LongSword", longSword);
        weaponsCollection.Add("GreatSword", greatSword);
        weaponsCollection.Add("Dagger", dagger);

        armorCollection.Add("Plate", plate);
        armorCollection.Add("Leather", leather);

        itemCollection.Add("LockPick", lockPick);
        itemCollection.Add("Book", book);

        //setWeapon(longSword,"LongSword");
        //setWeapon(greatSword, "GreatSword");
        //setWeapon(dagger, "Dagger");

        //armorCollection[0] = plate;
        //armorCollection[1] = leather;

        //weaponsArray[0] = weaponsCollection["LongSword"];
        //weaponsArray[1] = weaponsCollection["GreatSword"];
        //weaponsArray[2] = weaponsCollection["Dagger"];

        //Debug.Log("Weapon in gameManager: " + weaponsArray[0].Cost);
        //Debug.Log("Weapon in gameManager: " + weaponsArray[1].Cost);
        //Debug.Log("Weapon in gameManager: " + weaponsArray[2].Cost);

    }


    static public void setWeaponsInChest()
    {
        for (int i = 0; i < weaponsCollection.Count; i++)
            weaponsArray[i] = weaponsCollection[weaponsSelection[i]];
        
        for (int i = 0; i < armorCollection.Count; i++)
            armorArray[i] = armorCollection[armorSelection[i]];
        
        for (int i = 0; i < itemCollection.Count; i++)
            itemArray[i] = itemCollection[itemSelection[i]];
    }

    static public void addWeaponToInventory(string wName, int num)
    {
        weaponsArray[num] = weaponsCollection[wName];
    }

    static public void addArmorToInventory(string wName, int num)
    {
        armorArray[num] = armorCollection[wName];
    }

    static public void testSettingWeapons()
    {
        LongSword longSword = new LongSword();
        GreatSword greatSword = new GreatSword();
        Dagger dagger = new Dagger();

        Plate plate = new Plate();
        Leather leather = new Leather();

        //setWeapon(longSword, "LongSword");
        //setWeapon(greatSword, "GreatSword");
        //setWeapon(dagger, "Dagger");

        armorCollection.Add("Plate", plate);
        armorCollection.Add("Leather", leather);
    }

    public void setBaseClass(string cClass, int health)
    {
        className = cClass;
        Health = health;
        Exp = 0;

       

    }

    static public void setWeapon<W>(W iWeapon, string wName) where W : IWeapon
    {
       // weaponsCollection.Add(wName, iWeapon);
    }

    //
    static public void storeArmor<A>(A iArmor, int i) where A : IArmor
    {
        CharacterArmor inventoryArmor = new CharacterArmor();

        inventoryArmor.armorName = iArmor.Name;
        inventoryArmor.Defense = iArmor.Defense;
        inventoryArmor.Weight = iArmor.Weight;
        inventoryArmor.Value = iArmor.Value;

        armorArray[i] = inventoryArmor;
    }


    static public void setArmor<A>(A cArmor) where A : IArmor
    {

        characterArmor.armorName = cArmor.Name;
        characterArmor.Defense = cArmor.Defense;
        characterArmor.Weight = cArmor.Weight;
        characterArmor.Value = cArmor.Value;      
    }


    static public void storeWeapon<W>(W iWeapon, int i) where W : IWeapon
    {
        CharacterWeapon inventoryWeapon = new CharacterWeapon();

        inventoryWeapon.Name = iWeapon.Name;
        inventoryWeapon.Damage = iWeapon.Damage;
        inventoryWeapon.CriticalRating = iWeapon.CriticalRating;
        inventoryWeapon.CriticalChance = iWeapon.CriticalChance;
        inventoryWeapon.Deflect = iWeapon.Deflect;
        inventoryWeapon.Value = iWeapon.Value;
        inventoryWeapon.Weight = iWeapon.Weight;

        weaponsArray[i] = inventoryWeapon;
    }

   static public void setWeapon<W>(W cWeapon) where W : IWeapon
    {
       // characterWeapon = new CharacterWeapon();

        characterWeapon.Name = cWeapon.Name;
        characterWeapon.Damage = cWeapon.Damage;
        characterWeapon.CriticalRating = cWeapon.CriticalRating;
        characterWeapon.CriticalChance = cWeapon.CriticalChance;
        characterWeapon.Deflect = cWeapon.Deflect;
        characterWeapon.Value = cWeapon.Value;

    }

    public void setStat(int stat, int inc)
    {
        GameManager.Stats[inc] = stat;
    }

    public void setSkills(int skill, int inc)
    {
        Skills[inc] = skill;
     //   Debug.Log("Stat" + inc + ": " + Skills[inc]);
    }

    public void setModifier(int mod, int inc)
    {
        Modifiers[inc] = mod;
       // Debug.Log("Modifier" + inc + ": " + Modifiers[inc]);
    }

    public void getStat()
    {
        for (int i = 0; i < GameManager.Stats.Length; i++)
        {
          //  Debug.Log("Stat " + i + ": " + GameManager.Stats[i]);
         //   Debug.Log("Modifier " + i + ": " + GameManager.Modifiers[i]);
        }
    }

    public void getSkills()
    {
        for (int i = 0; i < GameManager.Skills.Length; i++)
        {
           // Debug.Log("Skills " + i + ": " + GameManager.Skills[i]);
        }
    }

    public void showCharacterStats()
    {
        //Debug.Log("Name: " + GameManager.Name);
        //Debug.Log("Class: " + GameManager.className);
        //Debug.Log("Health: " + GameManager.Health);
        //Debug.Log("Speed: " + GameManager.Speed);
        //Debug.Log("Exp: " + GameManager.Exp);
    }

}
