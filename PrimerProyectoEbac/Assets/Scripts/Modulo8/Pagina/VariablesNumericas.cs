using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    int incrementoFrame = 1;
    int incrementoFixed = 2;

    int sumaEntera;
    float maxLim = 10f;
    float minLim = 0.1f;
    float numeroSuma1;
    float numeroSuma2;

    Color c;

    // Update is called once per frame
    void Update()
    {
        incrementoFrame++;
        Debug.Log("<color=green>Incremento en Update: </color>" + incrementoFrame);

        numeroSuma1 = Random.Range(minLim, maxLim);
        numeroSuma2 = Random.Range(minLim, maxLim);
        sumaEntera = (int)(numeroSuma1 + numeroSuma2);
        Debug.Log("<color=blue>Suma: </color>" + sumaEntera);
    }

    void FixedUpdate()
    {
        incrementoFixed += 2;
        Debug.Log("<color=yellow>Incremento en Fixed: </color>" + incrementoFixed);

        if(sumaEntera % 2 == 0)
        {
            Debug.Log("<color=orange>El valor de la suma es par</color>");

            c = Color.red; 
            gameObject.GetComponent<MeshRenderer>().material.color = c; 
        }
        else
        {
            Debug.Log("<color=orange>El valor de la suma es impar</color>");

            c = Color.green;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
        }
    }
}
