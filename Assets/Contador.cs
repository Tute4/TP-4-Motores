using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    public float tiemporestante = 60f; 
    public string escenaVictoria = "Victoria";
    public Text contador; 

    void Update()
    {
        
        tiemporestante -= Time.deltaTime;

        
        if (tiemporestante <= 0)
        {
            
            SceneManager.LoadScene(escenaVictoria);
        }

       
        ActualizarContador();
    }

    void ActualizarContador()
    {
        
        int minutes = Mathf.FloorToInt(tiemporestante / 60f);
        int seconds = Mathf.FloorToInt(tiemporestante % 60f);

        
        contador.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
