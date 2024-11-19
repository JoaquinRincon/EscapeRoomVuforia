using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al componente AudioSource

    public void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No se ha asignado un AudioSource.");
        }
    }
}