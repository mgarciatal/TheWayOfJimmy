using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    private bool active;
    Canvas Canvas_Text;
    public float temps_start;
    public float temps_end;


    // Start is called before the first frame update
    void Start()
    {
        Canvas_Text = GetComponent<Canvas>();
        Canvas_Text.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        temps_start += Time.deltaTime;

        if (temps_start >= temps_end )
        {
            Destroy(gameObject); 
            

        }
    }
}
