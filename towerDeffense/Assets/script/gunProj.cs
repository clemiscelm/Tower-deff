using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunProj : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        this.transform.rotation = Quaternion.Euler(0, this.transform.rotation.eulerAngles.y, 0);
        rb.velocity = Vector3.forward * speed;

    }
}
