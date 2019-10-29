using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KO : MonoBehaviour

{
    public Canvas ko;

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
        }
    }
}
