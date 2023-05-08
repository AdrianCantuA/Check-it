using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class UserData
{
    public string email;
    public int game;
    public bool completed;
    public int time;

}

public class ApiScript : MonoBehaviour
{
    private string url = "http://presno2112.pythonanywhere.com/api/results/";
    private UserData userData;
    private GameManager gameManager;



    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        StartCoroutine(SendUserData());
    }

    IEnumerator SendUserData()
    { 
       WWWForm form = new WWWForm();
        form.AddField("time",gameManager.timer.ToString("F2"));
        form.AddField("completed","true");
        form.AddField("user",PlayerPrefs.GetInt("PlayerPreference"));
        form.AddField("game",1);
        // Crea la solicitud HTTP
       using(UnityWebRequest www = UnityWebRequest.Post(url, form)){
            //www.SetRequestHeader("Content-Type", "application/json");

            yield return www.SendWebRequest();

            // Verifica si hubo algún error
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Datos enviados correctamente a la API");
            }   
        }
        
    }
}

