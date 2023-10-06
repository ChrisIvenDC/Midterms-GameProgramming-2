using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public GameObject EnemyObj;
    public GameObject PlayerObj;
    public float Enemyspeed;



        private void Update()
    { 
        EnemyObj.transform.position = Vector3.MoveTowards(EnemyObj.transform.position, PlayerObj.transform.position , Enemyspeed);
    }
}