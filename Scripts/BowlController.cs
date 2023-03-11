using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlController : MonoBehaviour
{

    public float speed = 10f;
    private Vector3 _direction;
    Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() 
    {
        _direction = new Vector3(
            Input.GetAxis("Horizontal"),
            0f,
            Input.GetAxis("Vertical")
        );
        _rb.MovePosition(transform.position + (_direction * speed * Time.fixedDeltaTime));
    }
}