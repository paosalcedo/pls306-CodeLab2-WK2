using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Sprite[] sprites;
	
	public virtual void Start(){
		InvokeRepeating("SpriteTime", 0, 1f);
	}	

	public virtual void SpriteTime(){
		int nextNum = GetComponent<NumberGenerator>().Next();
		MakeSprite(nextNum);
	}
	
	public virtual void MakeSprite(int num){
		GameObject goSprite = new GameObject();
		SpriteRenderer sr = goSprite.AddComponent<SpriteRenderer>();
		sr.sprite = sprites[num];

		goSprite.AddComponent<Rigidbody2D>();
	}

	
}
