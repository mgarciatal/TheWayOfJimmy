using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalmove;
    public float verticalmove;
    public CharacterController Player;
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxis("Horizontal");
        verticalmove = Input.GetAxis("Vertical");

    }
            private void FixedUpdate() {
        Player.Move(new Vector3(horizontalmove, 0, verticalmove)*playerSpeed*Time.deltaTime);


    }

}

