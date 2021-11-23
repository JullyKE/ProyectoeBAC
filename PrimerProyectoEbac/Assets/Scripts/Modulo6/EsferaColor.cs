using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaColor : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value,Random.value,Random.value);
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
