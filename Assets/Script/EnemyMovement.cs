using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public GameObject EnemyObj;
    public GameObject PlayerObj;
    public float Enemyspeed;



        private void Update()
    { 
        EnemyObj.transform.position = Vector3.MoveTowards(EnemyObj.transform.position, PlayerObj.transform.position , Enemyspeed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
            print("Something is inside");
        }


    }
}