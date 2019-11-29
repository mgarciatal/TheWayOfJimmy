﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CargarNivel()
    {
        
        SceneManager.LoadScene("Nivell1");
        Time.timeScale = 1f;
        AudioListener.volume = 1;
    }

   

    public void quit()
    {
        Debug.Log("El joc s'està tancant");
        Application.Quit();
    }

    public void so()
    {
      AudioListener.volume = 0;
    }

}
