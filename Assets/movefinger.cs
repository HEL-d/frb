using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movefinger : MonoBehaviour
{
    [SerializeField] Transform startpos;
    [SerializeField] Transform endpos;
    public GameObject ga;
    float speed;
  

    void Start()
    {

        speed = 1.2f;
        ga.transform.position = startpos.position;
      
    }

    // Update is called once per frame
    private void FixedUpdate()
    
        
    
   {
          transform.position = Vector3.MoveTowards(transform.position, endpos.position, speed);
       
            if(ga.transform.position == endpos.position)
        {
            transform.Translate(startpos.position);
        }









    }

   
}
