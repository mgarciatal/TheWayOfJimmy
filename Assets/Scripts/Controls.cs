using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private bool active;
    Canvas Canvas_Controls;
    public float temps_start;
    public float temps_end;


    // Start is called before the first frame update
    void Start()
    {
        Canvas_Controls = GetComponent<Canvas>();
        Canvas_Controls.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        temps_start += Time.deltaTime;

        if (temps_start >= temps_end)
        {
            Destroy(gameObject);


        }
    }
}
