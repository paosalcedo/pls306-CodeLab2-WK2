﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrabber : Spawner {

	public List<GameObject> goSprites = new List<GameObject>();

	public KeyCode hKey;
	public KeyCode eKey;
	public KeyCode lKey;
	public KeyCode oKey;

	Vector3 offset = Vector3.zero;
	// Use this for initialization
	void Awake () {
		Letters.GenerateFormations();
	}
		
	// Update is called once per frame
	void Update () {

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
 					goSprites [i].transform.position = Letters.hFormation[i] + offset_;
 				}
				break;
			case KeyCode.E:
				for (int i = 0; i < Letters.eFormation.Count; i++) {
 					goSprites [i].transform.position = Letters.eFormation [i] + offset_;
				}
				break;
			
			case KeyCode.L:
				for (int i = 0; i < Letters.lFormation.Count; i++) {
 					goSprites [i].transform.position = Letters.lFormation [i] + offset_;
				}
				break;

			case KeyCode.O:
				for (int i = 0; i < Letters.oFormation.Count; i++) {
 					goSprites [i].transform.position = Letters.oFormation [i] + offset_;
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

		goSprite_.AddComponent<Rigidbody2D>();
		goSprites.Add (goSprite_);
	}

	Vector3 IncreaseOffset(){
		offset += (Vector3.right * 3);
		if (offset.x > 18f) {
			offset = Vector3.zero;
		}
		return offset;
	}

	void GetOffset(KeyCode key){
		if (Input.GetKeyDown (key)) {
			IncreaseOffset ();
		}
	}  


}
