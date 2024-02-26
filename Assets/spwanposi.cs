using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanposi : MonoBehaviour
{
    public Color gizmoColor = new Color(1, 0, 0, 0.2f);

    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawCube(transform.position, new Vector3(0.5f, 0.5f, 0.5f));
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
