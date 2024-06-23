using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public TextMeshProUGUI puntajeTexto; 
    public TextMeshProUGUI mejorPuntajeTexto; 
    public int puntaje = 0;
    public int mejorPuntaje = 0;

    private void Start()
    {
      
        CargarMejorPuntaje();
        ActualizarTextoPuntaje();
        ActualizarTextoMejorPuntaje();
    }

    public void IncrementarPuntaje()
    {
        puntaje+=1;
        ActualizarTextoPuntaje();
        if (puntaje > mejorPuntaje)
        {
            mejorPuntaje = puntaje;
            GuardarMejorPuntaje();
            ActualizarTextoMejorPuntaje();
        }
    }

    private void ActualizarTextoPuntaje()
    {
        puntajeTexto.text =  puntaje.ToString();
    }

    private void ActualizarTextoMejorPuntaje()
    {
        mejorPuntajeTexto.text = mejorPuntaje.ToString();
    }

    private void GuardarMejorPuntaje()
    {
        PlayerPrefs.SetInt("MejorPuntaje", mejorPuntaje);
        PlayerPrefs.Save();
    }

    private void CargarMejorPuntaje()
    {
        if (PlayerPrefs.HasKey("MejorPuntaje"))
        {
            mejorPuntaje = PlayerPrefs.GetInt("MejorPuntaje");
        }
    }

}

