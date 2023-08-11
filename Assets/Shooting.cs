using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int bulletSpeed = 5;
    public GameObject bubbles;
    public Transform bulletSpawnPoint;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))  
        {
            FireBullet();
        }
        //transform.position += transform.right * Time.deltaTime * speed;       

    }

    private void FireBullet()
    {
        GameObject bullet = Instantiate(bubbles, bulletSpawnPoint.position, Quaternion.identity);
        GameObject bullet = Instantiate(bubbles, bulletSpawnPoint.position, Quaternion.identity);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.velocity = Vector2.right * bulletSpeed;
    }
}

