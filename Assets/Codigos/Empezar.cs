
using UnityEngine;
using UnityEngine.SceneManagement;

public class Empezar: MonoBehaviour
{
    public  GameObject iniciar;
    public void EmpezarJuego()
    {
        Time.timeScale = 1;
        iniciar.SetActive(false);
       
    }
    public void inicio()
    {
        iniciar.SetActive(false);
    }
   
}