using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineColor : MonoBehaviour
{
    public MeshRenderer rend1, rend2;
    bool canChangeColor;


    // Start is called before the first frame update
    void Start()
    {
        rend1 = transform.GetChild(0).GetComponent<MeshRenderer>();
        rend2 = transform.GetChild(1).GetComponent<MeshRenderer>();

        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            rend1.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            rend2.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)); 
            yield return new WaitForSeconds(1);
        }
        //change color every 1 sec
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
        }

    }
}
