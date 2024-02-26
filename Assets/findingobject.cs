using FishNet.Object;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findingobject : NetworkBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      

        if (Input.GetKey("e"))
        {

            var bc = GameObject.Find("64ef1bfa1db75f90dcfb105b");
            var tc = GameObject.Find("64e883824a8548d9bc08573e");

            if (bc != null)
            {
                Debug.Log(bc.transform.parent.rotation.eulerAngles);

                // bc.transform.rotation = Quaternion.Euler(0f, -30f, 0f);
            }

        }








    }
}
