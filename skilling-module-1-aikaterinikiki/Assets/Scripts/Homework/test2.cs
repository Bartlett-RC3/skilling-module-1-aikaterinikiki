using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class test2 : MonoBehaviour
{
    //COLOUR NAMES ARRAY

    string[] colours = { "red", "green", "blue", "fuchsia" };


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(colours[1]);

        //LOOP
        //FOR LOOP
        for (int i = 0; i < colours.Length; i++)
        {
            Debug.Log("My colour at position" + i);
            Debug.Log(colours[i]);
        }

        int sumOfOddNumbers = 0;
        for(int x=1; x<100; x = x + 2)
        {
            sumOfOddNumbers += x;
        }
        Debug.Log("All odd numbers to 100 added together is" + sumOfOddNumbers);


        //CONDITION

        for (int i=0; i<100; i++)
        {
            if(i%2 == 0)
            {
                Debug.Log("whole number is:" + i);
            }
            else
            {
                Debug.Log("odd number is:" + i);
            }

        }

        //MULTIPLE QUESTIONS

        bool quest1 = true;
        bool quest2 = true;
        bool quest3 = false;

        //2 CONDITIONS MET

        if (quest1 && quest2 == true)
        {
            Debug.Log("both are true");
        }

        if (quest1 || quest3 == true)
        {
            Debug.Log("one is true");
        }

        //MORE THAN 2 QUESTIONS

        if (quest1 || quest2 || quest3 == true)
        {
            Debug.Log("TRUE");
        }

        //QUESTION IN QUESTION
        
        if(quest1 == true)
        {
            if(quest2 == true)
            {
                if(quest3 == false)
                {
                    Debug.Log("Meets condition");
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
