using FishNet.Object;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class famer : NetworkBehaviour
{


    public override void OnStartClient()
    {
        base.OnStartClient();
        if (!base.IsOwner)
            gameObject.SetActive(false);
}






    // Update is called once per frame
    void Update()
    {
        
    }
}
