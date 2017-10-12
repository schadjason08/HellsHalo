using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour 
{

    public float speed;

    void Start()
    {
        GetComponent<Rigidbody> ().velocity = transform.up * speed;
    }


}
