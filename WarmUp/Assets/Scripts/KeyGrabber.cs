using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrabber : Spawner {

	public List<GameObject> goSprites = new List<GameObject>();

	public KeyCode hKey;
	public KeyCode eKey;
	public KeyCode lKey;
	public KeyCode oKey;

	Vector3 offset = Vector3.right + (Vector3.up * 3f);
	Vector3 startingOffset;
	// Use this for initialization
	void Awake () {
		Letters.GenerateFormations();
		startingOffset = offset;
	}
		

	// Update is called once per frame
	void Update (){
 
		GetOffset (hKey);
		GetOffset (eKey);
		GetOffset (lKey);
		GetOffset (oKey);

		FormLetter (hKey, offset);
		FormLetter (eKey, offset);
		FormLetter (lKey, offset);
		FormLetter (oKey, offset);
	}

	void FormLetter (KeyCode key, Vector3 offset_){
		if(Input.GetKey(key)){
			switch (key) {
			case KeyCode.H:
				for (int i = 0; i < Letters.hFormation.Count; i++) {
					goSprites [i].transform.position = new Vector2 (Mathf.Lerp(goSprites[i].transform.position.x, Letters.hFormation[i].x + offset_.x, 0.25f), 
																	Mathf.Lerp(goSprites[i].transform.position.y, Letters.hFormation[i].y + offset_.y, 0.25f));

// 					goSprites [i].transform.position = Letters.hFormation[i] + offset_;
                    goSprites[i].GetComponent<Rigidbody2D>().isKinematic = false;
					goSprites[i].GetComponent<Rigidbody2D>().velocity = Vector2.zero + Random.insideUnitCircle;
				
                }
				break;
			case KeyCode.E:
				for (int i = 0; i < Letters.eFormation.Count; i++) {
 					goSprites [i+9].transform.position = Letters.eFormation [i] + offset_;
                    goSprites[i+9].GetComponent<Rigidbody2D>().isKinematic = false;
					goSprites[i+9].GetComponent<Rigidbody2D>().velocity = Vector2.zero + Random.insideUnitCircle;
                }
                    break;
			
			case KeyCode.L:
				for (int i = 0; i < Letters.lFormation.Count; i++) {
 					goSprites [i+18].transform.position = Letters.lFormation [i] + offset_;
					goSprites[i+18].GetComponent<Rigidbody2D>().isKinematic = false;
					goSprites[i+18].GetComponent<Rigidbody2D>().velocity = Vector2.zero + Random.insideUnitCircle;

				}
				break;

			case KeyCode.O:
				for (int i = 0; i < Letters.oFormation.Count; i++) {
 					goSprites [i+27].transform.position = Letters.oFormation [i] + offset_;
					goSprites[i+27].GetComponent<Rigidbody2D>().isKinematic = false;
					goSprites[i+27].GetComponent<Rigidbody2D>().velocity = Vector2.zero + Random.insideUnitCircle;
				}
				break;
			default:
				break;
			}
		}
	}

	public override void MakeSprite(int num){
		GameObject goSprite_ = new GameObject();
		SpriteRenderer sr = goSprite_.AddComponent<SpriteRenderer>();
		sr.sprite = sprites[num];

		goSprite_.transform.position = (Vector3.down * 6f) + (Vector3.left * 3f);
		goSprite_.AddComponent<Rigidbody2D>();
        goSprite_.AddComponent<ObjectBehavior>();
		goSprites.Add (goSprite_);
	}

	Vector3 IncreaseOffset(){
        offset += (Vector3.right * 3); 
        if (offset.x > 18f)
        {
			offset = startingOffset;
        }

		return offset;
	}

	void GetOffset(KeyCode key){
		if (Input.GetKeyDown (key)) {
			IncreaseOffset ();
		}
	}  


}
