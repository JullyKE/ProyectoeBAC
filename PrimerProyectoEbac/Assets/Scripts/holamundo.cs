using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holamundo : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("En el Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("En el Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("En el Update");
    }

    void FixedUpdate()
    {
        Debug.Log("En FixedUpdate");
    }

    void LateUpdate()
    {
        Debug.LogWarning("En LateUpdate");
    }

    void OnEnable()
    {
        Debug.LogError("En Enable");
    }
}
