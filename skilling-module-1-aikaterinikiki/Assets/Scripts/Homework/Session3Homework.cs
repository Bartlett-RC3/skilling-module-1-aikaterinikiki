using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Session3Homework : MonoBehaviour
    {
        public GameObject cube;
        public int noCubes = 2;
        public float space = 5.5f;
        private List<GameObject> cubeCopies = new List<GameObject>();




        // Start is called before the first frame update
        private void Start()
        {
            //Instantiate 2 cubes
            for (int i = 0; i < noCubes; i++)
            {
                Vector3 cubePosition = new Vector3(1, 1, i * space);
                Quaternion cubeRotation = Quaternion.identity;
                GameObject go = Instantiate(cube, cubePosition, cubeRotation);
                cubeCopies.Add(go);

            }
        }

        // Update is called once per frame
        void Update()
        {
            ////MOVING CUBE
            for (int i = 0; i < cubeCopies.Count; i++)
            {
                GameObject cubeCopy = cubeCopies[0];
                Vector3 moveCopy = new Vector3(0, Random.Range(-2.0f, 2.0f), 0);
                cubeCopy.GetComponent<Transform>().Translate(moveCopy * Time.deltaTime);

            }


            //CUBE CHANGING COLOR

            if (Input.GetKey(KeyCode.Space))
            {
                for (int i = 0; i < cubeCopies.Count; i++)
                {
                    GameObject cubeCopy = cubeCopies[1];
                    Color cubeCopyColor = new Color(0.4f, 1, 0.5f);
                    cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
                }
            }
        }
    }