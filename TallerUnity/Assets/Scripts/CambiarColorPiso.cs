
using UnityEngine;

public class CambiarColorPiso : MonoBehaviour
{
    public Renderer piso;

    private Color[] colores = {
        Color.red,
        Color.blue,
        Color.yellow,
        Color.green,
        Color.magenta,
        Color.white,
        new Color(0f, 0.3921f,0f)
    };

    private int indiceColor = 0;

    public void CambiarColor()
    {
        if (piso == null)
        {
            Debug.LogWarning("No se ha asignado el piso.");
            return;
        }

        piso.material.color = colores[indiceColor];

        indiceColor++;

        if (indiceColor >= colores.Length)
        {
            indiceColor = 0;
        }
    }
}
