using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KO : MonoBehaviour

{
    public Canvas ko;
    public float temps_start;
    public float temps_end;
    public Canvas Text;
    public Canvas Controls; 


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            ko.enabled = true;

            Time.timeScale = 0;
            AudioListener.volume = 0;
            Text.enabled = false;
            Controls.enabled = false;
            //Reiniciar();
        }
        
        
    

        
    }

    public void Reiniciar()
    {
        temps_start += Time.deltaTime;
        if (temps_start >= temps_end)
        {

            SceneManager.LoadScene("Nivell1");
            Time.timeScale = 1f;

            AudioListener.volume = 1;


        }

    }
}
