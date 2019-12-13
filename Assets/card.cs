using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
        private void Start()
    {
        //Assigning Clothing Objects Attributes and Methods
        Equip equip = new Equip(this.gameObject.name, true);
        //Debug.Log(equip.Name);
    }

    public class Equip
    {
        public string Name;
        public bool Safe;
        public bool Underpants = false;
        public Equip(string name, bool safe)
        {
            Name = name;
            Safe = safe;
        }
    }

    public bool checkSafe(string name)
    {
        if (this.gameObject.tag == "safe")
        {
            return true;
        } else {
            return false;
        }
    }
}
