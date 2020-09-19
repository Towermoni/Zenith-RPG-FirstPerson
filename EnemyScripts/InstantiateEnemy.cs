using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{
    public GameObject skeletonObject;
    Skeleton skeleton = new Skeleton("", 20);
    Skeleton[] skeletonArray = new Skeleton[2];
    GameObject[] gameObjectArray = new GameObject[2];
    Dictionary<string, int> enemyDamage;
    Dictionary<string, int> enemyHealth;
    Dictionary<string, int> enemyArmor;
    Dictionary<string, GameObject> enemyObject;
    bool isValid;

    // Start is called before the first frame update
    void Start()
    {
        isValid = true;
        enemyDamage = new Dictionary<string, int>();
        enemyObject = new Dictionary<string, GameObject>();

        //for (int i = 0; i < 3; i++)
        //{
        //    Debug.Log("Testing: " + i);
        //    skeletonArray[i] = new Skeleton("Skeleton" + i, 20); //= new Skeleton(i);
        //    //skeleton = new Skeleton(i);
        //    skeletonArray[i].getEnemyID(skeletonObject, skeletonArray[i]);
        //    //Instantiate(skeletonObject, new Vector3(0, i * 2, 0), transform.rotation);
        //    gameObjectArray[i] = (GameObject)Instantiate(skeletonObject, new Vector3(0, 2, 0), transform.rotation);
        //    gameObjectArray[i].name = "Skeleton" + i;
        //   // skeletonArray[i].name = gameObjectArray[i].name;
        //    //Debug.Log("ID: " + skeletonArray[i].EnemyID);
        //    //Debug.Log("Health: " + skeletonArray[i].Health);
        //    //Debug.Log("New ID: " + gameObjectArray[i].name);
        //    //Debug.Log("New ID: " + skeletonArray[i].Name);

        //    enemyDamage.Add(skeletonArray[i].Name, skeletonArray[i].Health);
        //    enemyObject.Add(skeletonArray[i].Name, gameObjectArray[i]);

        //}
        //isValid = false;
        //GameObject clone = Instantiate(skeletonObject, Vector3.zero, Quaternion.identity); // instantiate returns a reference to the things it creates
        //clone.name = "bob";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            enemyDamage[skeletonArray[0].Name] -= 5;
            enemyDamage[skeletonArray[1].Name] -= 4;
           // enemyDamage[skeletonArray[2].Name] -= 3;
            Debug.Log("Losing Health");
            Debug.Log(enemyDamage[skeletonArray[0].Name]);
            Debug.Log(enemyDamage[skeletonArray[1].Name]);
        }

        if (enemyDamage[skeletonArray[0].Name] <= 0 && isValid)
        {
            Debug.Log("Good bye: " + enemyObject[skeletonArray[0].Name].gameObject.name);
            enemyObject[skeletonArray[0].Name].gameObject.SetActive(false);
            isValid = false;
        }

        if (enemyDamage[skeletonArray[1].Name] <= 0)
        {
            Debug.Log("Good bye: " + enemyObject[skeletonArray[1].Name].gameObject.name);
            enemyObject[skeletonArray[1].Name].gameObject.SetActive(false);
           
        }
        //else if (enemyDamage[skeletonArray[2].Name] <= 0)
        //{
        //    enemyObject[skeletonArray[2].Name].gameObject.SetActive(false);
        //    Debug.Log("Good bye: " + skeletonArray[2].name);
        //}
    }
}
