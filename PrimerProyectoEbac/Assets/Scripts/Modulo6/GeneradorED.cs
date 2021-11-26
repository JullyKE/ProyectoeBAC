using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorED : MonoBehaviour
{
    public GameObject PrefabCapsula;
    public List<GameObject> listaDeCapsula;
    public float factorDeEscalamiento;
    public int numCapsula = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaDeCapsula = new List<GameObject>();
    }

    void OnEnable()
    {
        numCapsula++;
        GameObject temp = Instantiate<GameObject>(PrefabCapsula);
        temp.name = "CapsulaNumero" + numCapsula;
        temp.transform.position = Random.insideUnitSphere;
        listaDeCapsula.Add(temp);
    }

    void OnDisable()
    {
        List<GameObject> objetosElimina = new List<GameObject>();
        foreach(GameObject go in listaDeCapsula)
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
            listaDeCapsula.Remove(go);
            Destroy(go);
        }
    }
}
