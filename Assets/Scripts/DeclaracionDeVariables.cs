using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos = 24;
    float magnitudTerremoto = 9.3f;
    string nombreAlumno = "Agustin";
    bool compuHabilitada = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(cantidadAlumnos);
        Debug.Log(magnitudTerremoto);
        Debug.Log(nombreAlumno);
        Debug.Log(compuHabilitada);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
