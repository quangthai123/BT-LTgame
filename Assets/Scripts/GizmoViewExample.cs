using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoViewExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Gizmos.color = Color.yellow;
        //showDebugObject();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(2, 2, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
