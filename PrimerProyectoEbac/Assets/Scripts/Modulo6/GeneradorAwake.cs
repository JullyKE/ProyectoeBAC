using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorAwake : MonoBehaviour
{
    public GameObject PrefabCubo;

    void Awake()
    {
        GameObject temp = Instantiate<GameObject>(PrefabCubo);
        temp.transform.position = Random.insideUnitSphere;
    }
}
