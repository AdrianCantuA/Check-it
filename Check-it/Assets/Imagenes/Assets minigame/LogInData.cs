using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;
using SimpleJSON;

[System.Serializable]
public class LogInData : MonoBehaviour
{
    // Variables para el correo electrónico y la contraseña
    public string email;
    public string password;

    // URL de la API Django
    private string url = "http://presno2112.pythonanywhere.com/api/users/login/";

    // Función para enviar la solicitud POST
    IEnumerator SendLogin()
    {
        // Crea un objeto JSON con los datos de inicio de sesión
        JSONObject json = new JSONObject(JSONObject.Type.OBJECT);
        json.AddField("email", email);
        json.AddField("password", password);

        // Convierte el objeto JSON en una cadena
        string jsonString = json.ToString();

        // Crea la solicitud POST con los datos de inicio de sesión
        UnityWebRequest request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonString);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        // Envía la solicitud y espera la respuesta
        yield return request.SendWebRequest();

        // Comprueba si hubo un error al enviar la solicitud
        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(request.error);
        }
        else
        {
            // Obtiene la respuesta de la API y la muestra en la consola
            string responseText = request.downloadHandler.text;
            Debug.Log(responseText);
        }
    }

    // Función que se llama cuando se presiona el botón de inicio de sesión
    public void OnLoginButtonClicked()
    {
        StartCoroutine(SendLogin());
    }
}
