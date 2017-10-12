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


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = movement * speed;

        rigidbody.position = new Vector3
            (
            Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp (rigidbody.position.y, boundary.yMin, boundary.yMax),
            0.0f




            );

    }
	
}
