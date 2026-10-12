
using UnityEngine;

public class BotonSonido : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonido;

    public void ReproducirSonido()
    {
        audioSource.PlayOneShot(sonido);
    }
}
