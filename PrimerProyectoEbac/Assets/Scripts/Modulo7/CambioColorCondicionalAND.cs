using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColorCondicionalAND : MonoBehaviour
{
    public CambioColorCondicionalFU cubo1Script;
    public CambioColorCondicionalFU cubo2Script;

    bool cubo1;
    bool cubo2;
    public bool cubo3;
    
    Color c;

    void FixedUpdate()
    {
        cubo1 = cubo1Script.isChange;
        cubo2 = cubo2Script.isChange;

        cubo3 = cubo1 && cubo2 ? true : false;
        c = cubo3 ? Color.white : Color.black;
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
