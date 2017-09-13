using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour {
    Rigidbody2D rb;
    private float speed = 2f;
    private Vector2 direction;
	private Vector3 screenWidth;
	private float startY;

    void Start() {
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

    private void FixedUpdate()
    {
        if (rb.isKinematic) { 
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

	void ReturnToStream(){
		rb.isKinematic = true;
	}

	public IEnumerator DelayedFall(float delay){
		yield return new WaitForSeconds(delay);
		rb.isKinematic = false;
	}	

}
