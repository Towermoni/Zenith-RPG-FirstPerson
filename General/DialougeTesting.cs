using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DialougeTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        StreamReader sr = new StreamReader("C:\\Users\\Apozharsky\\Documents\\cvtcClasses\\Semester3\\GameDevelopment\\DungeonCrawler\\Assets\\Text Files\\GeneralStoreDialouge.txt"); ;
        string line = sr.ReadToEnd();
        string[] splitText = line.Split(new char[] {'\t'});
        Debug.Log(line);
        Debug.Log("TESTING LENGTH: " + splitText.Length);
        for (int i = 0; i < splitText.Length; i++)
        {
            Debug.Log(splitText[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//1. Come on, these are the imperials we're talking about here, can you really trust them?
//2. How does the town feel about the take over?
//3. Imperials? Who are they?
//4. I see, let me see what you have for sale...
//1. Cleon? Tell me more about him.
//2. Why is half the town opposing the imperials?
//3. Sounds like there might be trouble; anyways, let me see what you have for sale...
//4. That's all I needed to know, farewell.
//1. That sounds all well and good, but if your town becomes dependent on the Imperials, you wouldn't be able to do much if they decide to mistreat you.
//2. I see your point: the imperials do love good business...
//3. Interesting, speaking of money, let me see what you have for sale...
//1. The town can always say no.
//2. 