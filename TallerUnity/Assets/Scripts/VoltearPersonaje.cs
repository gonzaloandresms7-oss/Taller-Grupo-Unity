
using UnityEngine;

public class VoltearPersonaje : MonoBehaviour
{
    public GameObject personaje;

    private bool volteado = false;
    private Quaternion rotacionInicial;

    void Start()
    {
        rotacionInicial = personaje.transform.localRotation;
    }

    public void Voltear()
    {
        volteado = !volteado;

        if (volteado)
        {
            personaje.transform.localRotation =
                rotacionInicial * Quaternion.Euler(0, 0, 180);
        }
        else
        {
            personaje.transform.localRotation = rotacionInicial;
        }
    }
}
