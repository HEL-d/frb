using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeme : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = false;
    }






    void activatenow(string fake)
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = true;
    }

     void disablenow(string fake)
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = false;
    }


    // Update is called once per frame
   
}
