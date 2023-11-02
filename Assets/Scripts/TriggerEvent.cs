using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public string status;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void updateUI()
    {
        Debug.Log("Trigger: "+ status);      
    }

    private void OnTriggerEnter(Collider other)
    {
        status = other.gameObject.name;
        updateUI();
    }
    private void OnTriggerStay(Collider other)
    {
        status = other.gameObject.tag;
        updateUI();
    }

    private void OnTriggerExit(Collider other)
    {
        status = "exit";
        updateUI();
    }
}
