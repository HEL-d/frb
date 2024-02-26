using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatemask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = false;
    }


     void maskme(string fake)
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = true;
    }

     void unmaskme(string fake)
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = false;
    }




    // Update is called once per frame
    
}
