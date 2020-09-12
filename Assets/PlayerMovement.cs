using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float _moveSpeed = 1;
    [SerializeField] private float _turnSpeed = 2;
    [SerializeField] float acceleration = 10f;
    [SerializeField] float deccleration = -8.0f;
    private Rigidbody2D rb2D;
   

    private void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        rb2D.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Time.deltaTime * _turnSpeed * Vector3.back);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Time.deltaTime * _turnSpeed * Vector3.forward);

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rb2D.AddForce( transform.up * acceleration);
        if (Input.GetKey(KeyCode.S))
            rb2D.AddForce(transform.up * deccleration);

    }
}
