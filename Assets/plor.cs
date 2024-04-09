using FishNet.Managing;
using FishNet.Transporting.Tugboat;
using PlayFlow;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plor : MonoBehaviour
{
    private NetworkManager _networkManager;
    private string clientToken;


    void Start()
    {

      // gameObject.transform.GetChild(0).gameObject.SetActive(false);
       clientToken = "5trmvY6o_EuUkWhMrTnkZJBGvCamK17XcVXYHqcOWxv5DTGvaD2KEtt6_8Uycaj7tAcw5TLtzO3I2IxYNsoV0x9NDJQAJYCcCgCPV17icXMBEMPNoIoM6zG93bYPkAKj";
        _networkManager = FindObjectOfType<NetworkManager>();
       
    

    }


        void startconn()
    {
        PlayFlowManager.GetActiveServers(clientToken, (response) =>
        {
            var activeservers = response;
            if (activeservers.total_servers > 0)
            {
                Server server = activeservers.servers[0];
                var ip = server.ip;
                _networkManager.GetComponent<Tugboat>().SetClientAddress(ip);
                StartCoroutine(startcli());

       }


        });
    }

    private IEnumerator startcli()
    {
         yield return new  WaitForSecondsRealtime(2);
        _networkManager.ClientManager.StartConnection();                                           
    }



    // Update is called once per frame

}
