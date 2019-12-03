﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float movementSpeed = 0.5f;
    public float rotationSpeed = 1f;

    Vector3 targetPosition;
    Vector3 towardsTarget;

    float wanderRadius = 5f;


    void RecalculateTargetPosition ()
    {
        targetPosition = transform.position + Random.insideUnitSphere * wanderRadius;
        targetPosition.y = 0;

    }
    // Start is called before the first frame update
    void Start()
    {
        RecalculateTargetPosition();
        
    }

    // Update is called once per frame
    void Update()
    {
        towardsTarget = targetPosition - transform.position;
        if (towardsTarget.magnitude < 0.50f)
        RecalculateTargetPosition();

        Quaternion towardsTargetRotation = Quaternion.LookRotation(towardsTarget, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, towardsTargetRotation, rotationSpeed * Time.deltaTime);
            
        transform.position += transform.forward * movementSpeed * Time.deltaTime;

        
        
    }
}
