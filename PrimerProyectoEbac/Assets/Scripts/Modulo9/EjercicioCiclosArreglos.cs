using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCiclosArreglos : MonoBehaviour
{
    int[] arreglo1 = new int[3];
    int[] arreglo2 = new int[3];
    int[] arreglo3 = new int[3];

    string[] arregloString = new string[7]{"Escuela", "britanica", "de", "artes", "creativas", "y", "tecnologia"};
    string palabraconcatenada;

    int[,] arregloEnteros = new int [2,3]{{7, 17, 27},{37, 67, 3}}; 
    int suma = 0;

    // Update is called once per frame
    void Start()
    {
        for(int i = 0; i < arreglo1.Length; i++)
        {
            arreglo1[i] = Random.Range(0, 20);
            arreglo2[i] = Random.Range(0, 20);
            arreglo3[i] = arreglo1[i] + arreglo2[i];
            Debug.Log(arreglo1[i] + "+" + arreglo2[i] + "=" + arreglo3[i]);
        }

        foreach(string palabra in arregloString)
        {
            palabraconcatenada += palabra; 
        }
        Debug.Log(palabraconcatenada);

        for(int i = 0; i < arregloEnteros.GetLength(0); i++)
        {
            for(int j = 0; j < arregloEnteros.GetLength(1); j++)
            {
                suma += arregloEnteros[i,j] * arreglo1[j];
            }
            Debug.Log(suma);
            suma = 0;
        }
    }
}
