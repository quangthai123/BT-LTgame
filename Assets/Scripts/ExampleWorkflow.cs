using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleWorkflow : MonoBehaviour
{

    
    public GameObject targetObject;

    public Rigidbody rigidbody;

    public float speed = 2.0f;

    public Camera mainCamera;

    public float driveForce = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * distance);

        Time.timeScale = 3;

        transform.Translate(Vector3.right * 3 );

        /*
         * float rotationSpeed = 50f;
         * transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
         * 
         */
    }

    private void FixedUpdate()
    {
        Vector3 force = transform.forward * driveForce * Input.GetAxis("Vertical");
        rigidbody.AddForce(force);
    }

    private void LateUpdate()
    {
        //mainCamera.transform.LookAt(targetObject.transform);
    }
}
