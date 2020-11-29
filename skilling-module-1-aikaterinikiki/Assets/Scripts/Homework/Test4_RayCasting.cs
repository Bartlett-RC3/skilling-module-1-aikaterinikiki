using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4_RayCasting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MOVE OBLECT UP
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(Vector3.up * 0.1f);      
        }
        //MOVE OBJECT DOWN
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(Vector3.down * 0.1f);
        }

        //CHECK IF AN OBJECT IS SEEING ANOTHER OBJECT USING RC
        //FIRST LETS GET THE POSITION FROM WHERE WE ARE CASTING RAY 
        Vector3 rayCastPosition = this.gameObject.transform.position;


        //THEN CREATE A RAY IN THE DIRECTION WE WANT TO CAST
        Vector3 rayCastDirection = this.gameObject.transform.TransformDirection(Vector3.back);


        //CREATE VARIABLE THAT STORES INFO ABOUT WHAT WE ARE HITTING 
        RaycastHit objectSeenByRay;


        //CAST THE RAY
        if (Physics.Raycast(rayCastPosition, rayCastDirection, out objectSeenByRay))
        {
            Debug.Log("Object seen:" + objectSeenByRay.transform.name);
            Debug.Log("Object position:" + objectSeenByRay.transform.ToString());
            Debug.Log("Point where ray is hitting the object:" + objectSeenByRay.point);
            Destroy(objectSeenByRay.transform.gameObject);
        }

    }
}
