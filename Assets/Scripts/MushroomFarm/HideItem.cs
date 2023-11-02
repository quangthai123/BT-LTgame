using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideItem : MonoBehaviour
{
    public float timeEnd = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HideItemAfter(timeEnd));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // suspend execution for waitTime seconds
    IEnumerator HideItemAfter(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}
