using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    private bool active;
    Canvas canvas;
    private bool musica;
    
    

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
           
        }

        if (Input.GetKeyDown("p"))

            musica = !musica;
        AudioListener.volume = (musica) ? 0 : 1f;
            
     }
        
        
            
      
    
}
