using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapObject : MonoBehaviour {
    Rigidbody2D rb;
    private float speed = 2f;
    private Vector2 direction;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        direction = Random.insideUnitCircle;
    }

    // Update is called once per frame
    void Update() {
        //WrapBalls();
    }

    private void FixedUpdate()
    {
        if (rb.isKinematic) { 
            MoveBalls();
        }
    }

    void WrapBalls() {
        if (transform.position.y <= -3f) {
            transform.position = new Vector3(transform.position.x, transform.position.y + 9f, 0f);
        }

        if (transform.position.x >= 60f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 9f, 0f);
        }

        if (transform.position.x <= -9f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 9f, 0f);
        }
    }

    void MoveBalls() {
        rb.velocity = Vector2.right * speed + Random.insideUnitCircle;
        rb.angularVelocity = Random.Range(-50, 50);
    }
}
