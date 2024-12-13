using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject mainPanel;
    public void Comenzar()
    {
        SceneManager.LoadScene("AR", LoadSceneMode.Single);
    }

    public void Informacion()
    {
        panel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void Cerrar() {  panel.SetActive(false); mainPanel.SetActive(true); }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Additive);
    }

    public void ArInter()
    {
        SceneManager.LoadScene("XR", LoadSceneMode.Single);
    }
    
    public void Volver()
    {
        SceneManager.UnloadSceneAsync(gameObject.scene.buildIndex);
        mainPanel.SetActive(true);
    }
    
    public void Descargar(){
        SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
    }
    
    public void Configuracion(){
        SceneManager.LoadScene("Configuracion", LoadSceneMode.Single);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
