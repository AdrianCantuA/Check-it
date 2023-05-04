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
        // Crea la solicitud HTTP
        UnityWebRequest www = UnityWebRequest.Post(url, jsonData);

        // Espera la respuesta de la API
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

