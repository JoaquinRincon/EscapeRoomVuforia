using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoDisable : MonoBehaviour
{
    public GameObject video;
    // Start is called before the first frame update
    public void Mostrar()
    {
        video.SetActive(true);
    }
    public void Ocultar()
    {
        video.SetActive(false);
    }
}
