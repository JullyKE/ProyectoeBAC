using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaColor : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        Color c = new Color(Random.value,Random.value,Random.value);
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
