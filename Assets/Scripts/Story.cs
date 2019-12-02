using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour

{
    public Canvas Canvas_Item;
    public Animator clipboard;
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
        if (other.gameObject.tag == "Item")
        {
            /**clipboard.GetComponent<Animator> ().Play("pickup");**/
            Canvas_Item.enabled = true;
            Destroy(other.gameObject);

        }

        

            
    }
}
