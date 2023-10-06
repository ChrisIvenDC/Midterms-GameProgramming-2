using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class BulletScript : MonoBehaviour
{
    public GameObject BulletforCol;
    public float life = 3;
    void Awake()
    {
        Destroy(gameObject, life);
    }


    
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {   
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
