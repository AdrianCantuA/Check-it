using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explotion : MonoBehaviour
{
    public GameObject objetoDeReemplazo;
    public GameObject otherGameObjectToShow;
    public Button buttonToShow;
    public AudioSource musicSource;

    public void Stop()
    {
        musicSource.Stop();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            // Guarda la posición y rotación del objeto original antes de destruirlo
            Vector3 posicionOriginal = transform.position;
            Quaternion rotacionOriginal = transform.rotation;

            // Crea un nuevo objeto usando el objeto de reemplazo
            GameObject nuevoObjeto = Instantiate(objetoDeReemplazo, posicionOriginal, rotacionOriginal);

            // Destruye el objeto original
            Destroy(gameObject);

            // Activa el nuevo objeto
            nuevoObjeto.SetActive(true);
            otherGameObjectToShow.SetActive(true);
            buttonToShow.gameObject.SetActive(true);
            
        }
    }

}

