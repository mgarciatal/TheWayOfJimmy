using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour

{
    public Canvas Canvas_Item;
    public bool colisio = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            
            Canvas_Item.enabled = true;
            Destroy(other.gameObject);
            colisio = true; 

        }

        

            
    }
}
