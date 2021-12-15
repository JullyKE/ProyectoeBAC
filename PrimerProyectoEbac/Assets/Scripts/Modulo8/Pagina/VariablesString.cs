using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesString : MonoBehaviour
{
    enum SeleccionarColor
    {
        rojo,
        blanco,
        negro,
        verde,
        azul, 
        amarillo
    }

    int minimo = 0;
    int maximo = 7;
    Color c;
    int color;

    float numeroF = 1.5456f;

    string nombreCompleto = "Jully Kado Mercado Elias";

    // Start is called before the first frame update
    void Start()
    {
        string numeroString = numeroF.ToString();
        Debug.Log("<color=orange>Numero: </color>" + numeroString);

        string nombre = nombreCompleto.Substring(0, 5);
        string apeidoPaterno = nombreCompleto.Substring(6, 12);
        string apeidoMaterno = nombreCompleto.Substring(18, 6);

        Debug.Log("<color=purple>Nombre: </color>" + nombre);
        Debug.Log("<color=purple>Apeido Paterno: </color>" + apeidoPaterno);
        Debug.Log("<color=purple>Apeido Materno: </color>" + apeidoMaterno);

        string[] listanombre =  nombreCompleto.Split();
        foreach(var l in listanombre)
        {
            Debug.Log("<color=pink>Lista Nombre: </color>" + l);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        color = Random.Range(minimo, maximo);
        
        switch(color)
        {
            case (int)SeleccionarColor.rojo:
                c = Color.red;
                gameObject.GetComponent<MeshRenderer>().material.color = c;
                break;
            case (int)SeleccionarColor.blanco:
                c = Color.white;
                gameObject.GetComponent<MeshRenderer>().material.color = c;
                break;
            case (int)SeleccionarColor.negro:
                c = Color.black;
                gameObject.GetComponent<MeshRenderer>().material.color = c;
                break;
            case (int)SeleccionarColor.verde:
                c = Color.green;
                gameObject.GetComponent<MeshRenderer>().material.color = c;
                break;
            case (int)SeleccionarColor.azul:
                c = Color.blue;
                gameObject.GetComponent<MeshRenderer>().material.color = c;
                break;
            case (int)SeleccionarColor.amarillo:
                c = Color.yellow;
                gameObject.GetComponent<MeshRenderer>().material.color = c;
                break;
            default : 
                c = Color.gray;
                gameObject.GetComponent<MeshRenderer>().material.color = c;
                break;
        }
    }
}
