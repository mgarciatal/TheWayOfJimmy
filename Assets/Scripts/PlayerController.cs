using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Cam;
    public GameObject CamPost;
    public Animator Anim;
    
    
    
    
   

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame

        
    void Update()
    
    {

        if (Input.GetKey(KeyCode.W))
        {
            Anim.Play("run");
            transform.Translate(new Vector3(0, 0, 0.04f));
        }
        else {
            if (Input.GetKey(KeyCode.S))
            {
                Anim.Play("backwards-run");
                transform.Translate(new Vector3(0, 0, -0.04f));
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            Anim.Play("run");
            CamPost.transform.SetParent(null);
            transform.Rotate(new Vector3(0, 5.0f, 0));
            CamPost.transform.SetParent(transform);
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                Anim.Play("run");
                CamPost.transform.SetParent(null);
                transform.Rotate(new Vector3(0, -5.0f, 0));
                CamPost.transform.SetParent(transform);
                
            }
        }
        
        Cam.transform.position = Vector3.Lerp(Cam.transform.position, CamPost.transform.position, 0.1f);

        if (Input.GetKeyUp(KeyCode.W))
        {
            Anim.Play("run");
            transform.Translate(new Vector3(0, 0, 0.04f));
        }

    }

   


}

