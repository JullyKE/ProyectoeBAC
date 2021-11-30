using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColorCondicionalOR : MonoBehaviour
{
    public CambioColorCondicionalFU cubo1Script;
    public CambioColorCondicionalFU cubo2Script;

    bool cubo1;
    bool cubo2;
    public bool cubo4;
    
    Color c;

    void FixedUpdate()
    {
        cubo1 = cubo1Script.isChange;
        cubo2 = cubo2Script.isChange;

        cubo4 = cubo1 || cubo2 ? true : false;
        c = cubo4 ? Color.white : Color.black;
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
