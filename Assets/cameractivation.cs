using FishNet.Object;
using GameKit.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameractivation : NetworkBehaviour
{

    public int jakepoint;

    public override void OnStartClient()
    {
        base.OnStartClient();
        if (!base.IsOwner)
        {
            gameObject.SetActive(false);
            gameObject.GetComponent<AudioListener>().enabled = false;
        }












    }

   
    






    // Update is called once per frame
    void Update()
    {

        /* if(Input.GetKey("g"))
        {
            var avaurl = "64ef1bfa1db75f90dcfb105b" + '_' + "65a7a6388d5515a6083f99ae";
            searchmyavatar(avaurl);
        }*/

    



      //  StartCoroutine(Example99());


        /*
                if (Input.GetKey("u"))
                {
                    transform.parent.GetChild(3).rotation = Quaternion.Euler(0f, -30f, 0f);
                }*/




/*
         if (Input.GetKey("w"))
          {
     
            var bc = GameObject.Find("64ef1bfa1db75f90dcfb105b");
               var tc = GameObject.Find("65a7a6388d5515a6083f99ae");

              if (bc != null && tc != null )
              {
                  if (bc.transform.parent.rotation.eulerAngles == Vector3.zero && transform.parent.GetChild(5).name == bc.name)
                  {


                      bc.transform.rotation = Quaternion.Euler(0f, -30f, 0f);
                      tc.transform.rotation = Quaternion.Euler(0f, 210f, 0f);
                  }
                  else
                  {
                      tc.transform.rotation = Quaternion.Euler(0f, 30f, 0f);
                      bc.transform.rotation = Quaternion.Euler(0f, -210f, 0f);

                      //  Debug.Log("not found bc");
                  }







              }

          }


          if (Input.GetKey("c"))
          {

              var bc = GameObject.Find("64ef1bfa1db75f90dcfb105b-65d3117e1bb8471ebcdc8679");

              var tc = GameObject.Find("");

              if (bc != null && tc != null)
              {
                  if (tc.transform.parent.rotation.eulerAngles == Vector3.zero && transform.parent.GetChild(3).name == tc.name)
                  {


                      tc.transform.rotation = Quaternion.Euler(0f, -30f, 0f);
                      bc.transform.rotation = Quaternion.Euler(0f, 210f, 0f);
                  }
                  else
                  {

                      bc.transform.rotation = Quaternion.Euler(0f, 30f, 0f);
                      tc.transform.rotation = Quaternion.Euler(0f, -210f, 0f);

                  }







              }

          }*/





    }

   




    void searchmyavatar(string avaurl)
    {

        var getbc = avaurl.IndexOf('_');
        var gettc = avaurl.LastIndexOf('_');
        var po = avaurl.Substring(gettc + 1);
        var go = avaurl.Substring(0, getbc);
        var bc = GameObject.Find(go);
        var tc = GameObject.Find(po);

        if (bc != null && tc != null)
        {
            if (bc.transform.parent.rotation.eulerAngles == Vector3.zero && transform.parent.GetChild(4).name == bc.name)
            {


                bc.transform.rotation = Quaternion.Euler(0f, -30f, 0f);
                tc.transform.rotation = Quaternion.Euler(0f, 210f, 0f);
            }
            else
            {
                tc.transform.rotation = Quaternion.Euler(0f, 30f, 0f);
                bc.transform.rotation = Quaternion.Euler(0f, -210f, 0f);

                //  Debug.Log("not found bc");
            }







        }


    }





}
