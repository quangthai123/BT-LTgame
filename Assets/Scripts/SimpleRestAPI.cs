using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

using SimpleJSON;

public class SimpleRestAPI : MonoBehaviour
{
    public string url = "https://my-json-server.typicode.com/typicode/demo/posts/1";
    [SerializeField]
    Project project;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(processRequest(url));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator processRequest(string url)
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
            yield return request.SendWebRequest();

            if (request.isNetworkError)
            {
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log(request.downloadHandler.text);
                string json = request.downloadHandler.text;

                JSONNode projectData = JSON.Parse(request.downloadHandler.text);
                project = JsonUtility.FromJson<Project>(json);
            }
        }
   
}
[System.Serializable]
class Project
{
    int id;
    string title;
}
