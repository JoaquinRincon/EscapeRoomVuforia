using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject panel;
    public void Comenzar()
    {
        SceneManager.LoadScene("AR", LoadSceneMode.Single);
        Destroy(this);
    }

    public void Informacion()
    {
        panel.SetActive(true);
    }

    public void Cerrar() {  panel.SetActive(false); }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
        Destroy(this);
    }

    public void Volver()
    {
        SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
        Destroy(this);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
