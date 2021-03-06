﻿using UnityEngine;
using System.Collections;

public class ProjectileShooter2 : MonoBehaviour
{

    // Use this for initialization
    public Rigidbody projectile;
    public Transform shotPos;
    public float shotForce = 500f;
    public float moveSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(new Vector3(h, v, 0));

        if (Input.GetMouseButtonDown(1))
        {
            Rigidbody tennisball = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
            //projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            tennisball.AddForce(shotPos.forward * shotForce);
            //rb.velocity = Camera.main.transform.forward * 25;
        }
    }
}
