using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour 
    
{
    public GameObject CanvasPerder;
    private void Start()
    {
        Time.timeScale = 0;
    }
    public void Perdiste()
    {
        CanvasPerder.SetActive(true);
        Time.timeScale = 0;
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        
    }

}