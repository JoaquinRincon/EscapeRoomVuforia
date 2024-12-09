using UnityEngine;
using UnityEngine.UI;
public class ButtonSound : MonoBehaviour
{
    public AudioClip clickSound; // Sonido que se reproducirá
    private AudioSource audioSource;

    private void Awake()
    {
        // Busca el AudioSource en este objeto
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource no encontrado en " + gameObject.name);
        }

        // Agrega un evento a todos los botones
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => PlayClickSound());
        }
    }

    public void PlayClickSound()
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}