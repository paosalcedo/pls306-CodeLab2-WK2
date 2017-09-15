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
	public KeyCode bKey;
	public KeyCode cKey;
	public KeyCode dKey;
	public KeyCode eKey;
	public KeyCode fKey;
	public KeyCode gKey;
	public KeyCode hKey;
	public KeyCode iKey;
	public KeyCode jKey;
	public KeyCode kKey;
	public KeyCode lKey;
	public KeyCode mKey;
	public KeyCode nKey;
	public KeyCode oKey;
	public KeyCode pKey;
	public KeyCode qKey;
	public KeyCode rKey;
	public KeyCode sKey;
	public KeyCode tKey;
	public KeyCode uKey;
	public KeyCode vKey;
	public KeyCode wKey;
	public KeyCode xKey;
	public KeyCode yKey;
	public KeyCode zKey;

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
		GetOffset (cKey);
		GetOffset (dKey);
		GetOffset (eKey);
		GetOffset (fKey);
		GetOffset (gKey);
		GetOffset (hKey);
		GetOffset (iKey);
		GetOffset (jKey);
		GetOffset (kKey);
		GetOffset (lKey);
		GetOffset (mKey);	
		GetOffset (nKey);	
		GetOffset (oKey);
		GetOffset (pKey);	
		GetOffset (qKey);	
		GetOffset (rKey);			
		GetOffset (sKey);	
		GetOffset (tKey);	
		GetOffset (uKey);		
		GetOffset (vKey);		
		GetOffset (wKey);		
		GetOffset (xKey);		
		GetOffset (yKey);		
		GetOffset (zKey);

		FormLetter (aKey, offset);
		FormLetter (bKey, offset);
		FormLetter (cKey, offset);
		FormLetter (dKey, offset);
		FormLetter (eKey, offset);
		FormLetter (fKey, offset);
		FormLetter (gKey, offset);
		FormLetter (hKey, offset);
		FormLetter (iKey, offset);
		FormLetter (jKey, offset);
		FormLetter (kKey, offset);
		FormLetter (lKey, offset);
		FormLetter (mKey, offset);
		FormLetter (nKey, offset);
		FormLetter (oKey, offset);
		FormLetter (pKey, offset);
		FormLetter (qKey, offset);
		FormLetter (rKey, offset);
		FormLetter (sKey, offset);
		FormLetter (tKey, offset);
		FormLetter (uKey, offset);
		FormLetter (vKey, offset);
		FormLetter (wKey, offset);
		FormLetter (xKey, offset);
		FormLetter (yKey, offset);
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

			case KeyCode.C:
				for (int i = 0; i < Letters.cFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.cFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.cFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;
			
			case KeyCode.D:
				for (int i = 0; i < Letters.dFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.dFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.dFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.F:
				for (int i = 0; i < Letters.fFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.fFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.fFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.G:
				for (int i = 0; i < Letters.gFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.gFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.gFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.I:
				for (int i = 0; i < Letters.iFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.iFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.iFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.J:
				for (int i = 0; i < Letters.jFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.jFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.jFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.K:
				for (int i = 0; i < Letters.kFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.kFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.kFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.M:
				for (int i = 0; i < Letters.mFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.mFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.mFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.N:
				for (int i = 0; i < Letters.nFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.nFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.nFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.P:
				for (int i = 0; i < Letters.pFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.pFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.pFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.Q:
				for (int i = 0; i < Letters.qFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.qFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.qFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.R:
				for (int i = 0; i < Letters.rFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.rFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.rFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.S:
				for (int i = 0; i < Letters.sFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.sFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.sFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.T:
				for (int i = 0; i < Letters.tFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.tFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.tFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.U:
				for (int i = 0; i < Letters.uFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.uFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.uFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.V:
				for (int i = 0; i < Letters.vFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.vFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.vFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.W:
				for (int i = 0; i < Letters.wFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.wFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.wFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.X:
				for (int i = 0; i < Letters.xFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.xFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.xFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.Y:
				for (int i = 0; i < Letters.yFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.yFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.yFormation[i].y + offset_.y, lerpSpeed));
					goSprites [i + randomInt].GetComponent<Rigidbody2D> ().isKinematic = true;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().canMove = false;
					goSprites[i+randomInt].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
					goSprites [i + randomInt].GetComponent<ObjectBehavior> ().StartCoroutine ("DelayedFall", 2f);
				}
				break;

			case KeyCode.Z:
				for (int i = 0; i < Letters.zFormation.Count; i++) {
					goSprites [i+randomInt].transform.position = new Vector2 (Mathf.Lerp(goSprites[i+randomInt].transform.position.x, Letters.zFormation[i].x + offset_.x, lerpSpeed), 
																	Mathf.Lerp(goSprites[i+randomInt].transform.position.y, Letters.zFormation[i].y + offset_.y, lerpSpeed));
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
        offset += (Vector3.right * 4f); 
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
