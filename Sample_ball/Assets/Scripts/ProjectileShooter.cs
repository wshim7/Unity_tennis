using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {

    // Use this for initialization
    GameObject obj;
    void Start () {
        obj = Resources.Load("projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(obj) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 25;
          
        }
	}
}
