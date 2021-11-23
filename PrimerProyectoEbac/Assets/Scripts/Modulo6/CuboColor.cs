using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboColor : MonoBehaviour
{
    void Awake()
    {
        Color c = new Color(Random.value,Random.value,Random.value);
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
