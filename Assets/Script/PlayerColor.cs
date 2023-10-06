using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
   public  Material[] Playercolor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.GetComponent<Renderer>().material = Playercolor[0] ;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<Renderer>().material = Playercolor[1] ;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<Renderer>().material = Playercolor[2] ;
        }
    }
}
