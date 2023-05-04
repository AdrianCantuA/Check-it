using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public AudioClip sound;
    private void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}

