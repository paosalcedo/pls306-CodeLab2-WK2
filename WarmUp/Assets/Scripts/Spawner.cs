using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Sprite[] sprites;
	
	void Start(){
		InvokeRepeating("SpriteTime", 1, 1);
	}	

	void SpriteTime(){
		int nextNum = GetComponent<NumberGenerator>().Next();
		MakeSprite(nextNum);
	}
	
	void MakeSprite(int num){
		GameObject goSprite = new GameObject();
		SpriteRenderer sr = goSprite.AddComponent<SpriteRenderer>();
		sr.sprite = sprites[num];

		goSprite.AddComponent<Rigidbody2D>();
	}
	
}
