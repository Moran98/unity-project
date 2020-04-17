using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // setting enemy health
    public int health = 100;

    //public GameObject death;
    public void TakeDamage(int damage)
    {

        health -= damage;

        if (health <= 0)
        {
            // call method to destroy enemy
            Die();
        }
    }

    void Die()
    {
        // destroy enemy
        Destroy(gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // when bullet collides with enemy destroy bullet and enemy
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }



}

 
