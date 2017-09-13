using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrabber : Spawner {

	public enum SpawnerState
	{
		ACTIVE,
		DORMANT
	}

	SpawnerState spawnerState;

	public List<GameObject> goSprites = new List<GameObject>();

	public Queue<GameObject> spriteQueue = new Queue<GameObject>();
	
	public KeyCode aKey;
	public KeyCode hKey;
	public KeyCode eKey;
	public KeyCode lKey;
	public KeyCode oKey;
	public KeyCode zKey;
	public KeyCode bKey;

	public int maxSprites = 100;
	private int randomInt = 0;
	public float lerpSpeed = 0f;

	private Vector3 screenWidth = new Vector3 (Screen.width, 0, 0);

	Vector3 offset = Vector3.right + (Vector3.up * 3f);
	Vector3 startingOffset;
	// Use this for initialization
	void Awake () {
		Letters.GenerateFormations();
		startingOffset = offset;
		randomInt = Random.Range(0, goSprites.Count+1);
	}
		

	// Update is called once per frame
	void Update ()
	{
		if (goSprites.Count >= maxSprites) {
			spawnerState = SpawnerState.DORMANT;
		} else {
			spawnerState = SpawnerState.ACTIVE;
		}
 
		GetOffset (aKey);
		GetOffset (bKey);
		GetOffset (hKey);
		GetOffset (eKey);
		GetOffset (lKey);
		GetOffset (oKey);
		GetOffset (zKey);

		FormLetter (aKey, offset);
		FormLetter (bKey, offset);
		FormLetter (hKey, offset);
		FormLetter (eKey, offset);
		FormLetter (lKey, offset);
		FormLetter (oKey, offset);
		FormLetter (zKey, offset);
	}

	void FormLetter (KeyCode key, Vector3 offset_)
	{
		if (Input.GetKey (key)) {
			switch (key) {
			case KeyCode.H:
				for (int i = 0; i < Letters.hFormation.Count; i++) {
					goSprites [i + randomInt].transform.position = new Vector2 (Mathf.Lerp (goSprites [i + randomInt].transform.position.x, Letters.hFormation [i].x + offset_.x, lerpSpeed), 
						Mathf.Lerp (goSprites [i + randomInt].transform.position.y, Letters.hFormation [i].y + offset_.y, lerpSpeed));

					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
 					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);

				
                }
				break;
			case KeyCode.E:
				for (int i = 0; i < Letters.eFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.eFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.eFormation[i].y + offset_.y, lerpSpeed));

					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
					
                }
                    break;
			
			case KeyCode.L:
				for (int i = 0; i < Letters.lFormation.Count; i++) {
 					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.lFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.lFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);

				}
				break;

			case KeyCode.O:
				for (int i = 0; i < Letters.oFormation.Count; i++) {
 					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.oFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.oFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;
			case KeyCode.A:
				for (int i = 0; i < Letters.aFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.aFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.aFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.B:
				for (int i = 0; i < Letters.bFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.bFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.bFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;
			default:
				break;
			}
		}
	}

	public override void MakeSprite (int num)
	{
		switch(spawnerState){
		case SpawnerState.ACTIVE:
 			GameObject goSprite_ = new GameObject ();
			SpriteRenderer sr = goSprite_.AddComponent<SpriteRenderer> ();
			sr.sprite = sprites [num];

			goSprite_.transform.position = (Vector3.down * 6f) + (Vector3.left * 3f);
			goSprite_.AddComponent<Rigidbody2D> ();
			goSprite_.AddComponent<ObjectBehavior> ();
			goSprites.Add (goSprite_); 	
 			break;
		case SpawnerState.DORMANT:
 			break;
		default:
			break;
		}
	}

	Vector3 IncreaseOffset(){
        offset += (Vector3.right * 3); 
		if (offset.x >= Camera.main.ScreenToWorldPoint(screenWidth).x - 3f)
        {
			offset = startingOffset;
        }

		return offset;
	}

	void GetOffset (KeyCode key)
	{
		if (Input.GetKeyDown (key)) {
			randomInt = Random.Range(0, goSprites.Count+1);
			IncreaseOffset ();
		}
	}  


}
