using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class convercionMoneda : MonoBehaviour
{
    public string moneda;
    int resultado;
    public int monto;

    // Start is called before the first frame update
    void Start()
    {
        if (monto >= 1000)
        {
            if (moneda == "D")
            {
                resultado = 4 * monto;
                Debug.Log(resultado);
            }
            else if (moneda == "R")
            {
                resultado = 5 * monto;
                Debug.Log(resultado);
            }
            else if (moneda == "E")
            {
                resultado = 6 * monto;
                Debug.Log(resultado);
            }
            else
            {
                Debug.Log("moenda tiene que ser {E; D; D}");
            }
        }else if (monto < 1000)
        {
            Debug.Log("monto minimo es 1000");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
