using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public GameObject panel;
    public void Comenzar()
    {
        SceneManager.LoadScene("AR", LoadSceneMode.Single);
    }

    public void Informacion()
    {
        panel.SetActive(true);
    }

    public void Cerrar() {  panel.SetActive(false); }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
