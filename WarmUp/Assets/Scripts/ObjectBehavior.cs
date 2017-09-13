using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour {
    Rigidbody2D rb;
    private float speed = 2f;
    private Vector2 direction;
	private Vector3 screenWidth;
	private float startY;
	public bool canMove;

    void Start() {
		canMove = true;
		startY = transform.position.y;
		screenWidth = new Vector3 (Screen.width, 0, 0);
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        direction = Random.insideUnitCircle;
    }

    // Update is called once per frame
    void Update ()
	{
		WrapBalls ();

		if ((transform.position.y - startY) <= Random.Range (0, 1f)) {
			ReturnToStream();
		}
    }

    void FixedUpdate()
    {
        if (canMove) { 
            MoveBalls();
        }
    }

    void WrapBalls() {
 		if (transform.position.x >= Camera.main.ScreenToWorldPoint(screenWidth).x)
        {
            transform.position = new Vector3(-3f, transform.position.y, 0f);
        }
    }

    void MoveBalls() {
        rb.velocity = Vector2.right * speed + Random.insideUnitCircle;
        rb.angularVelocity = Random.Range(-100, 100);
    }

	void ReturnToStream(){ //happens when balls fall back into the stream
		rb.isKinematic = true;
		canMove = true;
	}

	public IEnumerator DelayedFall(float delay){
		yield return new WaitForSeconds(delay);
		rb.isKinematic = false;
		rb.velocity = new Vector2 (Random.insideUnitCircle.x * 0.25f, Random.insideUnitCircle.y * 0.25f);
	}	

}
