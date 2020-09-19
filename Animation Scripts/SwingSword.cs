using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject sword;
    private bool isValid;
    private Animator animator;
    private float counter;
    private bool isSwung;
    private float nextSwing;
    private bool swingAgain;
    float clicked;
    float clicktime;
    float clickdelay;
    public Character character;
    // Armor armor;
    //Weapon weapon;

    GameManager gameManager;

    Plate plate;
    Leather leather;

    Object[] armorArray;

    GreatSword greatSword;
    LongSword longSword;

    Enemy enemy;
    List<Enemy> enemyList; 
    double damage;
    Dictionary<string, int> enemyDamage1;
    Dictionary<string, int> enemyHealth;
    Dictionary<string, EnemyArmor> enemyArmor;
    Dictionary<string, EnemyWeapon> enemyWeapon;
    
    bool countOne;


    public GameObject skeletonObject;
    Skeleton skeleton = new Skeleton("", 20);
    EnemyArmor enemyArmor1 = new EnemyArmor();
    Skeleton[] skeletonArray = new Skeleton[5];
    GameObject[] gameObjectArray = new GameObject[5];
    Dictionary<string, double> enemyDamage;
    Dictionary<string, GameObject> enemyObject;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        plate = new Plate();
        leather = new Leather();

        gameManager.getSkills();
        gameManager.getStat();
        gameManager.showCharacterStats();

       armorArray = new Object[2] { plate, leather };

        greatSword = new GreatSword();
        longSword = new LongSword();

        // GameManager.setWeapon(longSword);
         GameManager.setWeapon(greatSword);
        //GameManager.weaponInventory.Add(longSword);
        //GameManager.weaponInventory.Add(greatSword);
        GameManager.setArmor(plate);

        animator = GetComponent<Animator>();

        damage = 0;
        isValid = true;
        counter = 0;

        enemyDamage = new Dictionary<string, double>();
        enemyObject = new Dictionary<string, GameObject>();
        enemyArmor = new Dictionary<string, EnemyArmor>();
        enemyWeapon = new Dictionary<string, EnemyWeapon>();

        for (int i = 0; i < 3; i++)
        {

            skeletonArray[i] = new Skeleton("Skeleton" + i, 20); //= new Skeleton(i);


            gameObjectArray[i] = (GameObject)Instantiate(skeletonObject, new Vector3(i * 2, 2, 0), transform.rotation);
            gameObjectArray[i].name = "Skeleton" + i;


            enemyDamage.Add(skeletonArray[i].Name, skeletonArray[i].Health);
            enemyObject.Add(skeletonArray[i].Name, gameObjectArray[i]);
            enemyArmor.Add(skeletonArray[i].Name, skeletonArray[i].setArmor(leather));
            enemyWeapon.Add(skeletonArray[i].Name, skeletonArray[i].setWeapon(longSword));

        }

        gameManager.getStat();

        //for (int i = 0; i < GameManager.Stats.Length; i++)
        //{
        //    Debug.Log("Stat " + i + ": " + GameManager.Stats[i]);
        //}

    }

    private void Update()
    {

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

            clicked++;

            if (clicked == 1)
            {
                animator.SetTrigger("Base_Attack");
                clicktime = Time.time;

            }
                

            if (clicked > 1 && Time.time - clicktime < clickdelay)
            {
                animator.SetTrigger("Second_Attack");
                
                clicked = 0;
                clicktime = 0;


            }
            else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;

        }


        if (Input.GetKey(KeyCode.Mouse1) && isValid == true && Time.time > nextSwing && swingAgain == true)
        {
            Block();
            nextSwing = Time.time + 0.5f;

        }
        else if (!Input.GetKey(KeyCode.Mouse1) && isValid == false && Time.time > nextSwing && swingAgain == true)
        {
            ReturnSword();
            nextSwing = Time.time + 0.5f;
        }


       swingAgain = true;
    }

    public void PerformAttack()
    {
        counter += Time.deltaTime;
        animator.SetTrigger("Base_Attack");
        if (Input.GetKey(KeyCode.Mouse0) && swingAgain == true)
        {
            animator.SetTrigger("Second_Attack");

            swingAgain = false;
        }
    }

    public void performHeavyAttack()
    {
       animator.SetTrigger("Heavy_Attack");
        isSwung = true;
    }

    public void Block()
    {
        animator.SetTrigger("Block");
        isValid = false;


    }

    public void ReturnSword()
    {
       // animator.SetTrigger("Return");
        isValid = true;
        isSwung = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        damage = GameManager.characterWeapon.checkDamage(character);
        damage = enemyArmor[other.name].preventDamage(damage);
        
        enemyDamage[other.name] -= damage;

        if (enemyDamage[other.name] <= 0)
        {
            enemyObject[other.name].gameObject.SetActive(false);
        }

        gameManager.getStat();

    }


    private void spawnSkeletons()
    {

        for (int i = 0; i < 2; i++)
        {
            skeletonArray[i] = new Skeleton("Skeleton" + i, 20);

            gameObjectArray[i] = (GameObject)Instantiate(skeletonObject, new Vector3(i * 2, 2, 0), transform.rotation);
            gameObjectArray[i].name = "Skeleton" + i;

            enemyDamage.Add(skeletonArray[i].Name, skeletonArray[i].Health);
            enemyObject.Add(skeletonArray[i].Name, gameObjectArray[i]);
        }

    }


    }

