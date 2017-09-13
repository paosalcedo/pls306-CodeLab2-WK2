using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters {

	public static List<Vector3> aFormation = new List<Vector3>();
	public static List<Vector3> hFormation = new List<Vector3>();
	public static List<Vector3> eFormation = new List<Vector3>();
	public static List<Vector3> lFormation = new List<Vector3>();
	public static List<Vector3> oFormation = new List <Vector3>();
	public static List<Vector3> bFormation = new List<Vector3>();

	public static List<Vector3> Formation = new List<Vector3>();

	public static void GenerateFormations ()
	{
		Formation.Add (new Vector3 (0,0,0));  
		Formation.Add (new Vector3 (0,-1,0));
		Formation.Add (new Vector3 (0,-2,0));
		Formation.Add (new Vector3 (1,0,0));
		Formation.Add (new Vector3 (1,-1,0));
		Formation.Add (new Vector3 (1,-2,0));
		Formation.Add (new Vector3 (2, 0,0));
		Formation.Add (new Vector3 (2,-1,0));
		Formation.Add (new Vector3 (2,-2,0));

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

		aFormation.Add (new Vector3 (0,0,0));
		aFormation.Add (new Vector3 (0,-1,0));
		aFormation.Add (new Vector3 (0,-2,0));
		aFormation.Add (new Vector3 (1,0,0));
		aFormation.Add (new Vector3 (1,-1,0));
		aFormation.Add (new Vector3 (2, 0,0));
		aFormation.Add (new Vector3 (2,-1,0));
		aFormation.Add (new Vector3 (2,-2,0));

		bFormation.Add (new Vector3 (0,0,0));  
		bFormation.Add (new Vector3 (0,-1,0));
		bFormation.Add (new Vector3 (0,-2,0));
		bFormation.Add (new Vector3 (1,0,0));
		bFormation.Add (new Vector3 (1,-1,0));
		bFormation.Add (new Vector3 (1,-2,0));
		bFormation.Add (new Vector3 (2,-1,0));
		bFormation.Add (new Vector3 (2,-2,0));

	}

}
