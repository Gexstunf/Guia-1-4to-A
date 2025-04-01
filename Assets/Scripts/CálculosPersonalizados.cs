using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CálculosPersonalizados : MonoBehaviour
{
    public enum TipoOperacion { Suma, Resta, Multiplicacion, Division }
    public TipoOperacion operacionSeleccionada;

    public float num1 = 10f;
    public float num2 = 5f;

    void Start()
    {
        float resultado = RealizarOperacion(num1, num2, operacionSeleccionada);
        Debug.Log("El resultado de la " + operacionSeleccionada + " entre " + num1 + " y " + num2 + " es: " + resultado);
    }

    float RealizarOperacion(float a, float b, TipoOperacion operacion)
    {
        switch (operacion)
        {
            case TipoOperacion.Suma:
                return a + b;
            case TipoOperacion.Resta:
                return a - b;
            case TipoOperacion.Multiplicacion:
                return a * b;
            case TipoOperacion.Division:
                return b != 0 ? a / b : 0;
            default:
                return 0;
        }
    }
}
