using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenu : MonoBehaviour
{
    public void Cerrar()
    {
        Application.Quit();
    }

    public void Comenzar() {
        SceneManager.LoadScene("AR");
    }
}
