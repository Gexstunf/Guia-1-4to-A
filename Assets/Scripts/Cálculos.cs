using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cálculos : MonoBehaviour
{
    public int num1;
    public int num2;
    public int resultado;
    // Start is called before the first frame update
    void Start()
    {
        num1 = Random.Range(1, 101);
        num2 = Random.Range(1, 101);
        resultado = num2 + num1;
        Debug.Log("La suma entre " + num1 + " y " + num2 + " es " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
