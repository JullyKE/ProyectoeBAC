using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorED : MonoBehaviour
{
    public GameObject PrefabCapsula;
    
    void OnEnable()
    {
        GenerarElemento();
    }

    void OnDisable()
    {
        GenerarElemento(); 
    }

    void GenerarElemento()
    {
        GameObject temp = Instantiate<GameObject>(PrefabCapsula);
        temp.transform.position = Random.insideUnitSphere;
    }
}
