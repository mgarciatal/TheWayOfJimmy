using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometre : MonoBehaviour
{
    [Tooltip("Temps incial en segons")]
    public int tempsInicial;

    [Tooltip("Avançament del rellotge")]
    [Range(0.0f , 60.0f)]
    public float EscaladaDeTemps = 1;

    public Text Textmeu;
    private float tempsframeScale = 0f;
    private float tempsSegons = 0f;
    private float EscalaPausada, escalainicial;
    private bool pausa = false;

    // Start is called before the first frame update
    void Start()
    {

        //Escala de temps original
        escalainicial = EscaladaDeTemps;

        
        //Agafar el component text
        Textmeu = GetComponent<Text>();

        //Inicializar la variable de temps per frame
        tempsSegons = tempsInicial;

        ActualizarRellotge(tempsInicial);


    }

    // Update is called once per frame
    void Update()
    {
        //Temps de cada frame per la escala 
        tempsframeScale = Time.deltaTime * EscaladaDeTemps;
        //Acumulació del temps per mostrar-lo desprès
        tempsSegons += tempsframeScale;
        ActualizarRellotge(tempsSegons);
    }
        public void ActualizarRellotge (float tempsSegons)
        {
        int minuts = 0;
        int segonds = 0;
        string textrellotge;

        //Assegurar-nos de que mai sigui temps negatiu
        if (tempsSegons < 0) tempsSegons = 0;

        //Calcular els minuts i segons
        minuts = (int)tempsSegons / 60;
        segonds = (int)tempsSegons % 60;

        //Crear el rellotge visual passant el valor numéric a caràcter
        textrellotge = minuts.ToString("00") + ":" + segonds.ToString("00");

        //Pasar el valor al objecte UI
        Textmeu.text = textrellotge;

        }
        
    
}
