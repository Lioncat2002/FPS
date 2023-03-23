using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody rb;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        direction = Camera.main.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction*speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
