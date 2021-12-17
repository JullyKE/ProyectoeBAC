using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosDeTiposBase : MonoBehaviour
{
    int numero1 = 1, numero2 = 2;
    int numero3 = 1, numero4 = 2;
    
    float var1 = 1f , var2 = 1f;
    int totalFlotantes;

    string numeroString = "3000";
    string palabra = "Hola Mundo";
    string guardarstring;

    // Update is called once per frame
    void FixedUpdate()
    {
        numero1++;
        numero2 += 2;
        if(numero1 % numero2 == 0)
        {
            Debug.Log("<color=blue>Son multiplos</color>");
        }
        else
        {
            Debug.Log("<color=blue>No son multiplos</color>");
        }

        var1 *= 2;
        var2 *= 5;
        if(var2 != 0)
        {
            totalFlotantes = (int)var1/(int)var2;
            Debug.Log(totalFlotantes);
        }
        else
        {
            Debug.Log("division en 0");
        }
        
        numero3++;
        numero4 *= 2;
        Debug.Log(numero3);
        Debug.Log(numero4);

        int stringNumero;
        
        int.TryParse(numeroString, out stringNumero);
        stringNumero += numero1;
        Debug.Log("<color=green>Numero en string</color>" + stringNumero);

        
        int pos = 0;
        foreach(char l in palabra)
        {
            if(pos % 2 == 0)
            {
                Debug.Log("<color=purple>Letras en par</color>" + l);
            }
            pos++;
        }
        
        guardarstring = palabra;
        guardarstring = palabra.Substring(5, 5);
        Debug.Log("<color=red>Palabra Cortada</color>" + guardarstring);
    }
}
