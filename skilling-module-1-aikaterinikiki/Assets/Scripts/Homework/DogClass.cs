using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dog_Class
{
    //Class
    public class DogClass : MonoBehaviour
    {
        //VARIABLES
        public string dogname;
        public int age;
        public string gender;

        //CONSTRUCTOR
        public DogClass(string _name, int _age, string _gender)
        {
            dogname = _name;
            age = _age;
            gender = _gender;

        }

        //BEHAVIOUR
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetGender()
        {
            return gender;
        }

    }

}