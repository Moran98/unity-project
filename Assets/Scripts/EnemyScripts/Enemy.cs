using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    //public GameObject death;
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    // Update is called once per frame
    void Die()
    {
        Destroy(gameObject);
    }

    /*    private void OnTriggerEnter2D(Collider2D whatHitMe)
        {

            var player = whatHitMe.GetComponent<PlayerMovement>();
            var bullet = whatHitMe.GetComponent<Bullet>();

            if (bullet)
            {
                Destroy(gameObject);
            }

            else if (player)
            {
                Destroy(gameObject);
            }
        }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }



}

 
