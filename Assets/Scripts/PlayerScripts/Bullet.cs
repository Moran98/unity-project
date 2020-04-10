using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

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
        //Instantiate(effect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        Destroy(gameObject);

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

    // delete bullets after 2 seconds
    private void Update()
    {
       Destroy(gameObject, 2.0f);
    }

}
