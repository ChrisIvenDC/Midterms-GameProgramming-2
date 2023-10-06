using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSample : MonoBehaviour
{

    float x, y, z;
    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;
    public float rotSpeed;


    public Transform EnemyPos;

    public float radius;

    void Update()
    {


        float dist = Vector3.Distance(transform.position, EnemyPos.position);
        if (dist <= radius)
        {
            LookRotation();
        }
    }

    void RotateInput()
    {
        currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotSpeed;
        currentRotation.eulerAngles = currentEulerAngles;
        transform.rotation = currentRotation;
    }
    void LookRotation()
    {
        Vector3 relativePos = EnemyPos.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}

