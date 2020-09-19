using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DialougeText : MonoBehaviour
{

    public Text promptText;
    public Text response1Text;
    public Text response2Text;
    public Text response3Text;
    public Text response4Text;

    public Text[] textArray = new Text[4];

    StreamReader sr;
    StreamReader sr1;

    private string line;
    private string line1;

    string[,,] testArray;

    int mainInc = 0;
    int q;
    int b;

    int testori = 0;

    string[] testor;

    private void Start()
    {
        // Stream reader is created to read the dialouge in the text file
        sr = new StreamReader("C:\\Users\\Apozharsky\\Documents\\cvtcClasses\\Semester3\\GameDevelopment\\DungeonCrawler\\Assets\\TextFiles\\DialougeTextFiles\\GeneralStoreDialouge.txt");

        // Is used for incrementing through array
        q = 1;

        // string line is created to read all dialouge in text file from beginning to end
        line = sr.ReadToEnd();

        // string array seperates data in text file into individual elements by checking for tabs in-between words
        string[] splitText = line.Split('\t');


        // Text array will hold the 4 dialouge choices the player has
        textArray = new Text[4] { response1Text, response2Text, response3Text, response4Text };

        // Three dimensional array will hold all data from the text file, including dialouge and values
        testArray = new string[22, 5, 2];


        /*
        Each row of the three dimensonal array will will have 5 elements, each holding 2 elements of their own. The two elements are the dialouge itself that the player will see and 
        the value the dialouge is assigned. The value will redirect the player to the next row. For example, if the player was in the second row, and and chose an option that had the value "4" 
        assigned to it. The player would then be redirected to the 4th row of the array and if the next dialouge the player chose had the value "8" then the player would be redirected to 
        8th row.

        In each row, the first element is the NPC dialouge. The NPC dialouge is unique in which the player cannot select it as an option unlike the other four elements. The value for the NPC dialouge 
        instead of redirecting the player to another row, is what the other four panels redirect to. For example, if a player chose a dialouge with the value of 4, the array will look for the NPC 
        dialouge with the value of 4, which will then redirect the player to the 4th row.

         BREAKDOWN OF ARRAY ROW
        
        [NPC DIALOUGE] [VALUE], [1ST DIALOUGE CHOICE] [VALUE], [SECOND DIALOUGE CHOICE] [VALUE], [THIRD DIALOUGE CHOICE] [VALUE], [FOURTH DIALOUGE CHOICE], [VALUE]

        EXAMPLE OF DIMENSONAL ARRAY
        
        { { "DialougeText0", "10"}, { "ResponseText1", "0" },{ "ResponseText2", "1" }, { "ResponseText3", "0" }, { "ResponseText4", "-1" } },
        { { "DialougeText1", "1"}, { "ResponseText1", "2" },{ "ResponseText2", "3" }, { "ResponseText3", "-6" }, { "ResponseText4", "0" } },
        { { "DialougeText2", "2"}, { "ResponseText9", "0" },{ "ResponseText10", "3" }, { "ResponseText11", "1" }, { "ResponseText4", "0" } },
        { { "DialougeText3", "3"}, { "ResponseText12", "5" },{ "ResponseText2", "7" }, { "ResponseText3", "0" }, { "ResponseText4", "-1" } },
        { { "DialougeText4", "4"}, { "ResponseText13", "0" },{ "ResponseText2", "0" }, { "ResponseText3", "0" }, { "ResponseText4", "9" } },
        { { "DialougeText5", "5"}, { "ResponseText14", "0" },{ "ResponseText2", "3" }, { "ResponseText3", "0" }, { "ResponseText4", "12" } },
        { { "DialougeText6", "6"}, { "ResponseText15", "2" },{ "ResponseText2", "-1" }, { "ResponseText3", "-1" }, { "ResponseText4", "-1" } },
        { { "DialougeText7", "7"}, { "ResponseText16", "0" },{ "ResponseText2", "13" }, { "ResponseText3", "-1" }, { "ResponseText4", "-1" } },};
        */

        for (int i = 0; i < 17; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int p = 0; p < 1; p++)
                {
                    testArray[i, j, 0] = splitText[testori];
                    testori++;

                    testArray[i, j, 1] = splitText[testori];
                    testori++;

                    line = sr.ReadLine();
                }
                if (testArray[i, j, 1] == "-1")
                {
                    testArray[i, j, 0] = "";
                }
            }
        }


    // This section initally sets the first NPC dialouge and dialouge choices
        promptText.text = testArray[0, 0, 0];
        promptText.name = testArray[0, 0, 1];

        for (int i = 0; i < textArray.Length; i++)
        {
            textArray[i].text = testArray[0, q, 0];
            textArray[i].name = testArray[0, q, 1];
           q++;

        }
        // q is set back to 1 so it can be used again
        q = 1;
    }

    private void Update()
    {

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            mainInc = System.Convert.ToInt32(textArray[0].name);
            b = 1;

            promptText.text = testArray[mainInc, 0, 0];
            promptText.name = testArray[mainInc, 0, 1];

            for (int i = 0; i < textArray.Length; i++)
            {
                textArray[i].text = testArray[mainInc, q, 0];
                textArray[i].name = testArray[mainInc, q, 1];
                q++;
            }

            q = 1;
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            mainInc = System.Convert.ToInt32(textArray[1].name);
            b = 1;

            promptText.text = testArray[mainInc, 0, 0];
            promptText.name = testArray[mainInc, 0, 1];

            for (int i = 0; i < textArray.Length; i++)
            {
                textArray[i].text = testArray[mainInc, q, 0];
                textArray[i].name = testArray[mainInc, q, 1];
                q++;
            }

            q = 1;
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            mainInc = System.Convert.ToInt32(textArray[2].name);
            b = 1;

            promptText.text = testArray[mainInc, 0, 0];
            promptText.name = testArray[mainInc, 0, 1];

            for (int i = 0; i < textArray.Length; i++)
            {
                textArray[i].text = testArray[mainInc, q, 0];
                textArray[i].name = testArray[mainInc, q, 1];
                q++;
            }

            q = 1;
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
                mainInc = System.Convert.ToInt32(textArray[3].name);
                b = 1;

                promptText.text = testArray[mainInc, 0, 0];
                promptText.name = testArray[mainInc, 0, 1];

                for (int i = 0; i < textArray.Length; i++)
                {
                    textArray[i].text = testArray[mainInc, q, 0];
                    textArray[i].name = testArray[mainInc, q, 1];
                    q++;
                }

                q = 1;
        }









    // SHADOW REALM






        //   if (Input.GetKeyUp(KeyCode.Alpha2))
        //   {

        //       mainInc = System.Convert.ToInt32(textArray[1].name);
        //       test = System.Convert.ToInt32(promptText.name);
        //       b = 0;

        //       //if (mainInc < 0)
        //       //{
        //       //    promptText.text = testArray[mainInc + 10, 0, 0];
        //       //    //promptText.name = testArray[mainInc + 10, 0, 1];

        //       //    for (int i = 0; i < textArray.Length; i++)
        //       //    {
        //       //        textArray[i].text = testArray[test, b, 0];
        //       //        textArray[i].name = testArray[test, b, 1];
        //       //        b++;
        //       //    }

        //       //}
        //       //else
        //       //{
        //       //    promptText.text = testArray[mainInc, 0, 0];
        //       //    promptText.name = testArray[mainInc, 0, 1];
        //       //    for (int i = 0; i < textArray.Length; i++)
        //       //    {
        //       //        textArray[i].text = testArray[mainInc, b, 0];
        //       //        textArray[i].name = testArray[mainInc, b, 1];
        //       //        b++;
        //       //    }

        //   }

        //   // Uncomment later
        ////   promptText.text = testArray[1, 0, 0];
        // //  promptText.name = testArray[1, 0, 1];

        //   //for (int i = 0; i < textArray.Length; i++)
        //   //{
        //   //    textArray[i].text = testArray[1, q, 0];
        //   //    textArray[i].name = testArray[1, q, 1];
        //   //    q++;

        //   //}

        //   //q = 0;

        //   if (Input.GetKeyUp(KeyCode.Alpha3))
        //   {

        //       mainInc = System.Convert.ToInt32(textArray[2].name);
        //       test = System.Convert.ToInt32(promptText.name);
        //       b = 1;

        //       if (mainInc < 0)
        //       {
        //           promptText.text = testArray[mainInc + 10, 0, 0];
        //           //promptText.name = testArray[mainInc + 10, 0, 1];

        //           for (int i = 0; i < textArray.Length; i++)
        //           {
        //               textArray[i].text = testArray[test, b, 0];
        //               textArray[i].name = testArray[test, b, 1];
        //               b++;
        //           }

        //       }
        //       else
        //       {
        //           promptText.text = testArray[mainInc, 0, 0];
        //           promptText.name = testArray[mainInc, 0, 1];
        //           for (int i = 0; i < textArray.Length; i++)
        //           {
        //               textArray[i].text = testArray[mainInc, b, 0];
        //               textArray[i].name = testArray[mainInc, b, 1];
        //               b++;
        //           }

        //       }
        //   }
        //   if (Input.GetKeyUp(KeyCode.Alpha4))
        //   {

        //       mainInc = System.Convert.ToInt32(textArray[3].name);
        //       b = 1;

        //       promptText.text = testArray[mainInc, 0, 0];
        //       promptText.name = testArray[mainInc, 0, 1];
        //       for (int i = 0; i < textArray.Length - 1; i++)
        //       {
        //           textArray[i].text = testArray[mainInc, b, 0];
        //           textArray[i].name = testArray[mainInc, b, 1];
        //           b++;
        //       }
        //   }
    }


    //public void setDialouge()
    //{
    //    for (int i = 0; i < dialougeSentences.Length; i++)
    //    {
    //        dialougeList.AddLast(dialougeSentences[i]);
    //    }
    //}

    //public void setResponse()
    //{
    //    for (int i = 0; i < dialougeSentences.Length; i++)
    //    {
    //        dialougeList.AddLast(dialougeSentences[i]);
    //    }

    //}

}
