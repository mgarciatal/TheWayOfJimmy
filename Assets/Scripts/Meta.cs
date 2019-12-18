using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meta : MonoBehaviour
{
    public Canvas Win;
    private int numeroEstrellas;
    public GameObject estrella;
    public GameObject panelEstrellas;
    [Header("Temps en Segons")]
    public float temps1 = 0f;
    public float temps2 = 0f;
    public float temps3 = 0f;
    [Header("Temps de Prova")]
    public float tempsSegons = 0f;

    private Cronometre cronometre;
    // Start is called before the first frame update
    void Start()
    {
        cronometre = FindObjectOfType<Cronometre>();
        Win.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            GenerarEstrelles();

            Time.timeScale = 0;
            
        }
    }
 
    public void GenerarEstrelles()
    {
        tempsSegons = cronometre.tempsSegons;
        //Activant Canvas per provar
        Win.enabled = true;
        if (tempsSegons <= temps3)
        {
            numeroEstrellas = 3;
        } else if (tempsSegons <= temps2)
        {
            numeroEstrellas = 2;
        }
        else if (tempsSegons <= temps1)
        {
            numeroEstrellas = 1;
        }
        else if (tempsSegons >= temps1)
        {
            numeroEstrellas = 0;
        }

        for (int i = 0; i < numeroEstrellas; i++)
        {
            Instantiate(estrella, panelEstrellas.transform);
        }
       
    }
 
}
