using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour
{

    public GameObject[] position;
    public GameObject[] item;

    public float timeEnd= 5;

    public int randomItem;
    public int randomPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void mushroomGrow()
    {
        //StartCoroutine(timeToLive());

        print("WaitAndPrint " + Time.time);
        randomItem = Random.RandomRange(0, item.Length);
        randomPosition = Random.RandomRange(0, position.Length);

        Instantiate(item[randomItem], position[randomPosition].transform);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator timeToLive()
    {
        yield return new WaitForSeconds(timeEnd);

        print("WaitAndPrint " + Time.time);
        //randomValue = Random.RandomRange(0, item.Length );

        //Instantiate(item[0], position[randomValue].transform);

    }

    // suspend execution for waitTime seconds
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("WaitAndPrint " + Time.time);
    }
}
