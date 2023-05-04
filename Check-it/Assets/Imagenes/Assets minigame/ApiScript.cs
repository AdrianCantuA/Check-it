using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class UserData
{
    public string email;
    public string game;
    public string completed;
    public string time;

}

public class ApiScript : MonoBehaviour
{
    private string url = "http://presno2112.pythonanywhere.com/api/results/";
    private UserData userData;

    // Start is called before the first frame update
    void Start()
    {
        // Rellena los datos del usuario
        userData = new UserData();
        userData.email = "asdfghjkl@example.com";
        userData.game = "1";
        userData.completed = "true";
        userData.time = "24.0";

        // Convierte el objeto a JSON y envía la solicitud HTTP
        string jsonData = JsonUtility.ToJson(userData);
        StartCoroutine(SendUserData(jsonData));
    }

    IEnumerator SendUserData(string jsonData)
    { 
        Debug.Log(jsonData);
       WWWForm form = new WWWForm();
        form.AddField("time",32);
        form.AddField("completed","true");
        form.AddField("user",1);
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

