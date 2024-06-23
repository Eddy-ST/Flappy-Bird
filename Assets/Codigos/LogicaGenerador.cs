using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class LogicaGenerador : MonoBehaviour
{
    public float TiempoMax = 1;
    private float TiempoInicial = 0;
    public GameObject obstaculo;
    public float altura;
    public float tiempoObstaculo = 10f;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if (TiempoInicial > TiempoMax) 
            {
                GameObject obstaculoNuevo = Instantiate(obstaculo);
                obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-altura,altura), 0);
                Destroy(obstaculoNuevo,tiempoObstaculo);
            TiempoInicial = 0;
            }
           else
            {
            TiempoInicial += Time.deltaTime;
            }
    }
}
