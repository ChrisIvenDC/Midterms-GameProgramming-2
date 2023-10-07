using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class BulletScript : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        // If the bullet collides with an object tagged "Enemy".
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Get the material of the enemy.
            Renderer enemyRenderer = collision.gameObject.GetComponent<Renderer>();
            if (enemyRenderer != null)
            {
                // Get the material of the bullet dynamically.
                Renderer bulletRenderer = GetComponent<Renderer>();

                // Compare the colors of the materials.
                if (enemyRenderer.material.color == bulletRenderer.material.color)
                {
                    // Destroy both the enemy and the bullet.
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                }
                else
                {
                    // Destroy only the bullet.
                    Destroy(gameObject);
                }
            }
            else
            {
                // If the enemy doesn't have a Renderer component, destroy only the bullet.
                Destroy(gameObject);
            }
        }
    }
}
