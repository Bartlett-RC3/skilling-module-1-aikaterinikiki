using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{
    //VARIABLES

    public GameObject columnPrefab;
    IEnumerator createPrefabsCoroutine;


    // Start is called before the first frame update
    void Start()
    {
        createPrefabsCoroutine = DropPrefabs();
        //CALLING USING A COROUTINE
        StartCoroutine(createPrefabsCoroutine);
    }

    // Update is called once per frame
    void Update()
    {  

        Debug.Log(Time.time);
        if (Time.time > 10) 
        {
            //STOP A SPECIFIC COROUTINE
            StopCoroutine(createPrefabsCoroutine);
            //STOP ALL COROUTINES
            StopAllCoroutines();

        }
        
    }

    //COROUTINES
    IEnumerator DropPrefabs()
    {
        while (true)
        {
            // Action the coroutine (create and drop column)
            Vector3 dropPosition = new Vector3(Random.RandomRange(-5.0f, 12.0f), Random.RandomRange(3.0f, 14.0f), Random.RandomRange(-7.0f, 6.0f));
            Quaternion dropRotation = new Quaternion(Random.RandomRange(0, 90), Random.RandomRange(0, 90), Random.RandomRange(0, 90), 1);
            Instantiate(columnPrefab, dropPosition, dropRotation);
            yield return new WaitForSeconds(1);


        }
    }
}
