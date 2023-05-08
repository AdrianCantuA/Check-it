using System.Diagnostics;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Login : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;

    void Start()
    {
        GameObject.Find("LogIn Button").GetComponent<Button>().onClick.AddListener(() => StartCoroutine(PostData_Coroutine()));
    }

    void PostData() => StartCoroutine(PostData_Coroutine()); 
    
    IEnumerator PostData_Coroutine(){
        string url = "http://presno2112.pythonanywhere.com/api/users/login/#post-object-form";
        WWWForm form = new WWWForm();
  
        form.AddField("password", passwordInput.text);
        form.AddField("email" , usernameInput.text);
        using(UnityWebRequest www = UnityWebRequest.Post(url, form)){
            yield return www.SendWebRequest();
            if (www.result != UnityWebRequest.Result.Success)
            {
                UnityEngine.Debug.Log(www.error);
            }
            else
            {
                UnityEngine.Debug.Log("Datos enviados correctamente a la API");
                string json = www.downloadHandler.text;
                UnityEngine.Debug.Log(json);
                MessageData message = JsonUtility.FromJson<MessageData>(json);
                UnityEngine.Debug.Log(message.message);
                
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
                
            }   
        }
    }
}
