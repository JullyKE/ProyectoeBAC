using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColorCondicionalFU : MonoBehaviour
{
    Color c;
    public bool isChange;

    void FixedUpdate()
    {
        isChange = !isChange;
        if(isChange)
        {
            c = Color.white; 
            gameObject.GetComponent<MeshRenderer>().material.color = c;     
        }
        else
        {
            c = Color.black;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
        }
    }
}
