
using UnityEngine;

public class CambiarColorPersonaje : MonoBehaviour
{
    public GameObject personaje;

    private Renderer[] renderizadores;

    private Color[] colores = {
        Color.red,
        Color.blue,
        Color.yellow,
        Color.green,
        Color.magenta,
        Color.white,
        Color.grey
    };

    private int indiceColor = 0;

    void Start()
    {
        renderizadores =
            personaje.GetComponentsInChildren<Renderer>();
    }

    public void CambiarColor()
    {
        Color nuevoColor = colores[indiceColor];

        foreach (Renderer r in renderizadores)
        {
            r.material.color = nuevoColor;
        }

        indiceColor++;

        if (indiceColor >= colores.Length)
        {
            indiceColor = 0;
        }
    }
}
