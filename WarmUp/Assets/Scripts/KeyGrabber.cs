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
	
	}
	// Use this for initialization
	void Awake () {
		PopulateLists ();
	}

	void Start () {
		InvokeRepeating("SpriteTime", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		FormLetter (hKey);
		FormLetter (eKey);
	}

	void FormLetter (KeyCode key){
		if (Input.GetKey (key)) {
			for (int i = 0; i <= eFormation.Count; i++) {
				if (key == KeyCode.H) {
					goSprites [i].transform.position = hFormation [i];
				}

				if (key == KeyCode.E) {
					goSprites [i].transform.position = eFormation [i];
				}
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
}
