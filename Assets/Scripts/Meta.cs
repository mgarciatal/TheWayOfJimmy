using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public Canvas Win;

    
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
            AudioListener.volume = 0;
        }
    }

}
