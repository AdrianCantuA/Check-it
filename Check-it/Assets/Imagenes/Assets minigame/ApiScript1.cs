using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
/*
public class ApiScript1 : MonoBehaviour {
    public string apiUrl = "http://presno2112.pythonanywhere.com/api/results/";

    IEnumerator Start () {
        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl)) {
            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success) {
                Debug.Log(request.error);
            } else {
                string json = request.downloadHandler.text;
                //ParseJson(json);
            }
        }
    }

   void ParseJson (string json) {
    Debug.Log(json); // Imprime el JSON recibido en la consola
    // Parsea el JSON y muestra el mensaje en la consola
    MessageData message = JsonUtility.FromJson<MessageData>(json);
    Debug.Log(message.message);
}

}

[System.Serializable]
public class MessageData {
    public string message;
}*/