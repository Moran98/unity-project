using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // variables
    public GameObject effect;
    private Rigidbody2D rb;
    public int damage = 50;
    public Enemy enemy;
    private Vector2 screenBounds;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // on collision destroy bullet
        Destroy(gameObject);

        // if bullet is out of boundaries destroy after specific distance
        if(transform.position.x > screenBounds.x * -2)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }

    // destroy bullets after 2 seconds -- speed of bullets will mean they leave screen within 1 second
    private void Update()
    {
       Destroy(gameObject, 2.0f);
    }

}
