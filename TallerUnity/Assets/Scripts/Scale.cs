using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] public UI_HolaMundo holaMundoScript;
    [SerializeField] public Transform objectToScale;
    [SerializeField] private float ScaleSpeed = 0.1f;
    [SerializeField] private float minScale=0.005f;

    private string ScaleText="Escalado a: ";
    private string WarningText="No se puede hacer mas pequeño";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        holaMundoScript.ChangeTextHM("Empty");
    }

    public void ScaleUp()
    {
        objectToScale.localScale += Vector3.one*ScaleSpeed;
        holaMundoScript.ChangeTextHM(ScaleText+objectToScale.localScale.x.ToString("F2"));
        //Con la linea de arriba mostramos el valor de escala con dos cifras decimales
    }

    public void ScaleDown()
    {
        if (objectToScale.localScale.x >minScale)
        {
            objectToScale.localScale -= Vector3.one *ScaleSpeed;
        holaMundoScript.ChangeTextHM(ScaleText+objectToScale.localScale.x.ToString("F2"));
        }
        else 
        {
            holaMundoScript.ChangeTextHM(WarningText);
        }
    }
}
