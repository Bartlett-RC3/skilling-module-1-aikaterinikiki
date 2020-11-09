using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dog_Class;


public class Session2_Homework : MonoBehaviour
{
    //VARIABLES
    public bool isSunny = true;
    public int[] myNumberArray = { 2, 4, 5, 6 };
    DogClass rex, pongo, milly;

    //START
    // Start is called before the first frame update
    void Start()
    {
        //CONDITION
            if (isSunny == true)
        {
            Debug.Log("The weather is sunny today!");
        }
        else
        {
            Debug.Log("The weather is rainny today!");
        }


        //LOOP
        // For example
        for (int i = 0; i < myNumberArray.Length; i++)
        {
            if (myNumberArray[i] == 4)
            {
                Debug.Log("There's a 4 here");
            }
            else
            {
                Debug.Log("There's no 4 here");
            }
        }

        // Foreach example
        foreach (int i in myNumberArray)
        {
            Debug.Log("it works");
        }

        //DOG CLASS
        rex = new DogClass("rex", 5, "male");
        pongo = new DogClass("pongo", 10, "male");
        milly = new DogClass("milly", 4, "female");


    }

    //UPDATE
    // Update is called once per frame
    void Update()
    {
     
        
    }
}
