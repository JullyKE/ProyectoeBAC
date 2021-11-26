using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorAwake : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    void Awake()
    {
        listaDeCubos = new List<GameObject>();
        numCubos++;
        GameObject temp = Instantiate<GameObject>(PrefabCubo);
        temp.name = "CuboNumero" + numCubos;
        temp.transform.position = Random.insideUnitSphere;
        listaDeCubos.Add(temp);
        List<GameObject> objetosElimina = new List<GameObject>();
        foreach(GameObject go in listaDeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;
            if(escala <= 0.1)
            {
                objetosElimina.Add(go);
            }
        }
        foreach(GameObject go in objetosElimina)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }

    }
}
