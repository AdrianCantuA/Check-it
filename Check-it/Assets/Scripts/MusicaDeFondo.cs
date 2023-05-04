using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaDeFondo : MonoBehaviour
{
static MusicaDeFondo instance;

void Awake()
{
if (instance == null)
{
instance = this;
DontDestroyOnLoad(gameObject);
}
else
{
Destroy(gameObject);
}
}
}