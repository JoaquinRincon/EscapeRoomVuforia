using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void Comenzar()
    {
        SceneManager.LoadScene("AR", LoadSceneMode.Single);
    }

    public void Informacion()
    {

    }

    public void Salir()
    {
        Application.Quit();
    }
}
