using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    private bool active;
    Canvas Canvas_Text;

    // Start is called before the first frame update
    void Start()
    {
        Canvas_Text = GetComponent<Canvas>();
        Canvas_Text.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            active = !active;
            Canvas_Text.enabled = active;
            

        }
    }
}
