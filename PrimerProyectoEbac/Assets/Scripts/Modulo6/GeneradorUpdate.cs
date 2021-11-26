using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorUpdate : MonoBehaviour
{
    public GameObject PrefabEsfera;
    public List<GameObject> listaDeEsferas;
    public float factorDeEscalamiento;
    public int numEsfera = 0;
    // Start is called before the first frame update
    void Start()
    {
        listaDeEsferas = new List<GameObject>();
    }

    void Update()
    {
        
        numEsfera++;
        GameObject temp = Instantiate<GameObject>(PrefabEsfera);
        temp.name = "EsferaNumero" + numEsfera;
        temp.transform.position = Random.insideUnitSphere;
        listaDeEsferas.Add(temp);
        List<GameObject> objetosElimina = new List<GameObject>();
        foreach(GameObject go in listaDeEsferas)
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
            listaDeEsferas.Remove(go);
            Destroy(go);
        }

    }
}
