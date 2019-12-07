using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public Canvas Win;
    public GameObject Primera_Estrella;
    public GameObject Segona_Estrella;
    public GameObject Tercer_Estrella;
    public float tempsSegons = 0f;

    
    // Start is called before the first frame update
    void Start()
    {
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

            Win.enabled = true;

            Time.timeScale = 0;
            
        }
    }
    /**
    public void Estrelles()
    {
        if (tempsSegons < 60)
        {
            Win.enabled = true;
        }

        if (tempsSegons > 60 && tempsSegons < 120)
        {
            Win.GetComponents = true;



        }
    }
    **/

}
