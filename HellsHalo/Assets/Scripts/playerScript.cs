using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary1
{
    public float xMin, xMax, yMin, yMax;
}

public class playerScript : MonoBehaviour {

    public float speed;

    public Boundary1 boundary;

    public GameObject Shot;
    public Transform BulletSpawn;
    public float fireRate;

    private float nextFire;

    void Update(){

        if (Time.time > nextFire){

            nextFire = Time.time + fireRate;
            Instantiate(Shot, BulletSpawn.position, BulletSpawn.rotation);
        }

    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = movement * speed;

        rigidbody.position = new Vector3
            (
            Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp (rigidbody.position.y, boundary.yMin, boundary.yMax),
            0.0f




            );

    }
	
}
