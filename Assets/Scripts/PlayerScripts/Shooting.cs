using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // variables
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public AudioSource someSound;

    // References : Brackers - https://www.youtube.com/watch?v=LNLVOjbrQj4

    void Update()
    {
        // onPress Mouse1/Fire1 shoot a bullet and make a bullet shooting sound
        if (Input.GetButtonDown("Fire1"))
        {
            someSound.Play();
            Shoot();
        }

        // alternative shooting can use "SpaceBar"
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            someSound.Play();
            Shoot();
        }
    }

    //shooting method
    void Shoot()
    {
        // bullet shoots from firepoint
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        // addifn force to the bullet so it can keep up with pace of the enemies
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }


}
