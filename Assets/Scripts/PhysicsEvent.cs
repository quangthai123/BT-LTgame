using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PhysicsEvent : MonoBehaviour
{
    public string status;
    public TMP_Text statusNoti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void updateUI()
    {
        Debug.Log("Collision: " + status);
        statusNoti.text = status;
    }

    private void OnCollisionEnter(Collision collision)
    {
        status = collision.gameObject.name;
        updateUI();
    }

    private void OnCollisionStay(Collision collision)
    {
        status = collision.gameObject.tag;
        updateUI();
    }

    private void OnCollisionExit(Collision collision)
    {
        status = "exit";
        updateUI();
    }



}
