using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{
    //Variable
    public int myNumber = 8;
    public int myNumber2 = 2;
    public int myNumber3 = 3;
    public float myFloat = 2.5698f;
    public string myText = "My name is Katia";

    //Array
    public int[] myArray = { 4, 5, 6, 7, 8, 9, 10 };
    public float[] myNewArray = { 2.5f, 3.95f, 4.32f, 89.67f };

    //List
    public List<string> thisIsAList = new List<string>();

    //Function 
    //if this function was only printing and not returning anything we would declare it as void
    private float PrintAndCalculate(int _FirstNumber, int _SecondNumber, int _ThirdNumber) 
    {
        Debug.Log("My First Number equals to: " + _FirstNumber.ToString());
        Debug.Log("My Second Number equals to: " + _SecondNumber.ToString());
        Debug.Log("My Third Number equals to: " + _ThirdNumber.ToString());

        float SumResult = _FirstNumber + _SecondNumber;
        SumResult = SumResult - _ThirdNumber;
        return SumResult; 
    }

    private void PrintMyList(string _MyText, List<string> _MyList)
    {

        _MyList.Add(_MyText);
        Debug.Log(_MyList[0]);

    }


    // Start is called before the first frame update
    void Start()
    {
        float SumResult = PrintAndCalculate(myNumber, myNumber2, myNumber3);
        
        Debug.Log("By adding the first two and substracting the third my number equals to: " + SumResult.ToString());

        PrintMyList(myText, thisIsAList);
    }

    //Dictionary
    private Dictionary<string, int> myDictionary = new Dictionary<string, int>
    {
        {"George", 25},
        {"Helen", 16},
        {"Maria", 27},
        {"John", 20},
    };


    // Update is called once per frame
    void Update()
    {
        
    }
}
