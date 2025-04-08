using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deQueOrientacion : MonoBehaviour
{
    public int grado;
    public string alumno;
    public string orientacion;

    void Start()
    {
        if (string.IsNullOrEmpty(alumno))
        {
            Debug.Log("Pon un alumno");
            return;
        }

        if (grado < 1 || grado > 5)
        {
            Debug.Log("Grado tiene que estar entre 1 y 5");
            return;
        }

        if (grado == 1 || grado == 2)
        {
            Debug.Log("Tienes que ser de grado 3 o mayor");
            return;
        }

        else if (orientacion != "T" && orientacion != "G" && orientacion != "M" && orientacion != "H" && orientacion != "D")
        {
            Debug.Log("no se pudo");
            return;
        }

        else
        {
            Debug.Log("¡Muchas gracias, " + alumno + "!");
        }

    }
}
