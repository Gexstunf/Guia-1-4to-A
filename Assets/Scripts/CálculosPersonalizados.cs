using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CálculosPersonalizados : MonoBehaviour
{

    public float num1 = 10f;
    public float num2 = 5f;
    float resultado;

    void Start()
    {
        resultado = num1 + num2;
        Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + resultado);
        resultado = num1 - num2;
        Debug.Log("El resultado de la resta entre " + num1 + " y " + num2 + " es: " + resultado);
        resultado = num1 * num2;
        Debug.Log("El resultado de la multiplicacion entre " + num1 + " y " + num2 + " es: " + resultado);
        resultado = num1 / num2;
        Debug.Log("El resultado de la division entre " + num1 + " y " + num2 + " es: " + resultado);

    }

}
