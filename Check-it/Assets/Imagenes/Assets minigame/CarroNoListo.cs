using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarroNoListo : MonoBehaviour
{
    public GameObject noJala;
    
    private void Start()
    {
        // Hide the object if the value is less than 4
        if (PlayerPrefs.GetInt("LlantaArreglada", 0) < 4 || PlayerPrefs.GetInt("AceiteArreglado", 0) < 1 || PlayerPrefs.GetInt("AnticongelanteArreglado", 0) < 1 || PlayerPrefs.GetInt("BugWashArreglado", 0) < 1)
        {
            noJala.SetActive(true);

        }
        else if (PlayerPrefs.GetInt("ArreglarLlanta", 0) == 4 && PlayerPrefs.GetInt("ArreglarAceite", 0) == 1 && PlayerPrefs.GetInt("ArreglarAnticongelante", 0) == 1 && PlayerPrefs.GetInt("ArreglarBugWash", 0) == 1)
        {
            noJala.SetActive(false);
        }
    }

}
