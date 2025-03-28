using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    string nombre = "Agustin";
    int edad = 17;
    float estatura = 1.83f;
    bool donante = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombre + ", tengo " + edad + ", mido " + estatura + " metros y es " + donante + " que soy donante de órganos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
