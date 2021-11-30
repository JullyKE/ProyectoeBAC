using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColorCondicionalConbinacion : MonoBehaviour
{
    public CambioColorCondicionalAND cubo3Script;
    public CambioColorCondicionalOR cubo4Script;

    bool cubo3;
    bool cubo4;
    bool cubo5;
    
    Color c;

    void FixedUpdate()
    {
        cubo3 = cubo3Script.cubo3;
        cubo4 = cubo4Script.cubo4;

        if((cubo3 && cubo4) || cubo4)
        {
            c = Color.red;
        }
        else if((cubo3 && cubo4) || cubo3)
        {
            c = Color.green;
        }
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
