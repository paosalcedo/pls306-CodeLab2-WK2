using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrabber : Spawner {

	public List<GameObject> goSprites = new List<GameObject>();

	List<Vector3> hFormation = new List<Vector3>();
	List<Vector3> eFormation = new List<Vector3>();
	List<Vector3> lFormation = new List<Vector3>();
	List<Vector3> oFormation = new List <Vector3>();

	public KeyCode hKey;
	public KeyCode eKey;
	public KeyCode lKey;
	public KeyCode oKey;

	void PopulateLists(){
		hFormation.Add (new Vector3 (0, 0, 0));
		hFormation.Add (new Vector3 (0, -1, 0));
		hFormation.Add (new Vector3 (0, -2, 0));
		hFormation.Add (new Vector3 (1, -1, 0));
		hFormation.Add (new Vector3 (2, 0, 0));
		hFormation.Add (new Vector3 (2, -1, 0));
		hFormation.Add (new Vector3 (2, -2, 0));

		eFormation.Add (new Vector3 (0, 0, 0));
		eFormation.Add (new Vector3 (1, 0, 0));
		eFormation.Add (new Vector3 (2, 0, 0));
		eFormation.Add (new Vector3 (0, -1, 0));
		eFormation.Add (new Vector3 (1, -1, 0));
		eFormation.Add (new Vector3 (0, -2, 0));
		eFormation.Add (new Vector3 (1, -2, 0));
		eFormation.Add (new Vector3 (2, -2, 0));
	
		lFormation.Add (new Vector3 (0,0,0));
		lFormation.Add (new Vector3 (0,-1,0));
		lFormation.Add (new Vector3 (0,-2,0));
		lFormation.Add (new Vector3 (1, -2, 0));
		lFormation.Add (new Vector3 (2, -2, 0));

		oFormation.Add (new Vector3 (0,0,0));
		oFormation.Add (new Vector3 (0,-1,0));
		oFormation.Add (new Vector3 (0,-2,0));
		oFormation.Add (new Vector3 (1,0,0));
		oFormation.Add (new Vector3 (1,-2,0));
		oFormation.Add (new Vector3 (2, 0,0));
		oFormation.Add (new Vector3 (2,-1,0));
		oFormation.Add (new Vector3 (2,-2,0));


	}
	// Use this for initialization
	void Awake () {
		PopulateLists ();
	}
		
	// Update is called once per frame
	void Update () {
		FormLetter (hKey);
		FormLetter (eKey);
		FormLetter (lKey);
		FormLetter (oKey);
	}

	void FormLetter (KeyCode key){
		if(Input.GetKey(key)){
			switch (key) {
			case KeyCode.H:
				for (int i = 0; i < hFormation.Count; i++) {
					goSprites [i].transform.position = hFormation [i] + (-9 * Vector3.right);
				}
				break;
			case KeyCode.E:
				for (int i = 0; i < eFormation.Count; i++) {
					goSprites [i].transform.position = eFormation [i] + (-6*Vector3.right);
				}
				break;
			
			case KeyCode.L:
				for (int i = 0; i < lFormation.Count; i++) {
					goSprites [i].transform.position = lFormation [i] + (-3*Vector3.right);
				}
				break;

			case KeyCode.O:
				for (int i = 0; i < oFormation.Count; i++) {
					goSprites [i].transform.position = oFormation [i] + (0 * Vector3.right);
				}
				break;
			default:
				break;
			}
//			if (key == KeyCode.E) {
//				for (int i = 0; i < eFormation.Count; i++) {
//					goSprites [i].transform.position = eFormation [i];
//				}
//			}
//			if (key == KeyCode.H) {
//				for (int i = 0; i < hFormation.Count; i++) {
//					goSprites [i].transform.position = eFormation [i];
//				}
//			}
		}
	}

	public override void MakeSprite(int num){
		GameObject goSprite_ = new GameObject();
		SpriteRenderer sr = goSprite_.AddComponent<SpriteRenderer>();
		sr.sprite = sprites[num];

		goSprite_.AddComponent<Rigidbody2D>();
		goSprites.Add (goSprite_);
	}
}
