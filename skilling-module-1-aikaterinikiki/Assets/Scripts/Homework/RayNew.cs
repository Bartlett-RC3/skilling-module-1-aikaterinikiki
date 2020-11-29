using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayNew : MonoBehaviour
{
    public Camera cam;
    public GameObject[] objects = new GameObject[3];
    //Vector3 initialPosition = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        for (int x=0; x<objects.Length; x++)
        {
            GameObject newObj = Instantiate(objects[x], new Vector3 (x,x,x), Quaternion.identity);
            newObj.transform.parent = this.transform;                    
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.transform.gameObject);           
            }
        }
    }
}
