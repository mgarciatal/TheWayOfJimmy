using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private bool active;
    Canvas Canvas_Lore;
    
    // Start is called before the first frame update
    void Start()
    {
        Canvas_Lore = GetComponent<Canvas>();
        Canvas_Lore.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            active = !active;
            Canvas_Lore.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;

        }
    }
}
