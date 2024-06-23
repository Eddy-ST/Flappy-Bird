using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaAreaPuntaje : MonoBehaviour
{
    // Start is called before the first frame update
    private Puntaje puntajeScript;

    private void Start()
    {

        puntajeScript = FindObjectOfType<Puntaje>();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
            puntajeScript.IncrementarPuntaje();
        
    }
}
