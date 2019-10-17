﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Cam;
    public GameObject CamPost;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 0.1f));
        }
        else {
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, 0, -0.1f));
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            CamPost.transform.SetParent(null);
            transform.Rotate(new Vector3(0, 5.0f, 0));
            CamPost.transform.SetParent(transform);
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                CamPost.transform.SetParent(null);
                transform.Rotate(new Vector3(0, -5.0f, 0));
                CamPost.transform.SetParent(transform);
            }
        }

        Cam.transform.position = Vector3.Lerp(Cam.transform.position, CamPost.transform.position, 0.1f);

       
    }
            

}

