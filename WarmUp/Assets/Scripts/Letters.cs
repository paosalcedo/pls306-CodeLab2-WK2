using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters {

	public static List<Vector3> aFormation = new List<Vector3>();
	public static List<Vector3> bFormation = new List<Vector3>();
	public static List<Vector3> cFormation = new List<Vector3>();
	public static List<Vector3> dFormation = new List<Vector3>();
	public static List<Vector3> eFormation = new List<Vector3>();
	public static List<Vector3> fFormation = new List<Vector3>();
	public static List<Vector3> gFormation = new List<Vector3>();
	public static List<Vector3> hFormation = new List<Vector3>();
	public static List<Vector3> iFormation = new List<Vector3>();
	public static List<Vector3> jFormation = new List<Vector3>();
	public static List<Vector3> kFormation = new List<Vector3>();
	public static List<Vector3> lFormation = new List<Vector3>();
	public static List<Vector3> mFormation = new List<Vector3>();
	public static List<Vector3> nFormation = new List<Vector3>();
	public static List<Vector3> oFormation = new List<Vector3>();
	public static List<Vector3> pFormation = new List<Vector3>();
	public static List<Vector3> qFormation = new List<Vector3>();
	public static List<Vector3> rFormation = new List<Vector3>();
	public static List<Vector3> sFormation = new List<Vector3>();
	public static List<Vector3> tFormation = new List<Vector3>();
	public static List<Vector3> uFormation = new List<Vector3>();
	public static List<Vector3> vFormation = new List<Vector3>();
	public static List<Vector3> wFormation = new List<Vector3>();
	public static List<Vector3> xFormation = new List<Vector3>();
	public static List<Vector3> yFormation = new List<Vector3>();
	public static List<Vector3> zFormation = new List<Vector3>();

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

		cFormation.Add (new Vector3 (0,0,0));  
		cFormation.Add (new Vector3 (0,-1,0));
		cFormation.Add (new Vector3 (0,-2,0));
		cFormation.Add (new Vector3 (1,0,0));
		cFormation.Add (new Vector3 (1,-2,0));
		cFormation.Add (new Vector3 (2, 0,0));
		cFormation.Add (new Vector3 (2,-2,0));

		dFormation.Add (new Vector3 (0,0,0));  
		dFormation.Add (new Vector3 (0,-1,0));
		dFormation.Add (new Vector3 (0,-2,0));
		dFormation.Add (new Vector3 (1,0,0));
		dFormation.Add (new Vector3 (1,-2,0));
		dFormation.Add (new Vector3 (2,-1,0));

		eFormation.Add (new Vector3 (0, 0, 0));
		eFormation.Add (new Vector3 (1, 0, 0));
		eFormation.Add (new Vector3 (2, 0, 0));
		eFormation.Add (new Vector3 (0, -1, 0));
		eFormation.Add (new Vector3 (1, -1, 0));
		eFormation.Add (new Vector3 (0, -2, 0));
		eFormation.Add (new Vector3 (1, -2, 0));
		eFormation.Add (new Vector3 (2, -2, 0));

		fFormation.Add (new Vector3 (0, 0, 0));
		fFormation.Add (new Vector3 (1, 0, 0));
		fFormation.Add (new Vector3 (2, 0, 0));
		fFormation.Add (new Vector3 (0, -1, 0));
		fFormation.Add (new Vector3 (1, -1, 0));
		fFormation.Add (new Vector3 (0, -2, 0));

		gFormation.Add (new Vector3 (0,0,0));  
		gFormation.Add (new Vector3 (0,-1,0));
		gFormation.Add (new Vector3 (0,-2,0));
		gFormation.Add (new Vector3 (1,0,0));
		gFormation.Add (new Vector3 (1,-1,0));
		gFormation.Add (new Vector3 (1,-2,0));
		gFormation.Add (new Vector3 (2,-1,0));
		gFormation.Add (new Vector3 (2,-2,0));

		hFormation.Add (new Vector3 (0, 0, 0));
		hFormation.Add (new Vector3 (0, -1, 0));
		hFormation.Add (new Vector3 (0, -2, 0));
		hFormation.Add (new Vector3 (1, -1, 0));
		hFormation.Add (new Vector3 (2, 0, 0));
		hFormation.Add (new Vector3 (2, -1, 0));
		hFormation.Add (new Vector3 (2, -2, 0));
		
		iFormation.Add (new Vector3 (0,0,0));  
//		uFormation.Add (new Vector3 (0,-1,0));
		iFormation.Add (new Vector3 (0,-2,0));
		iFormation.Add (new Vector3 (1,0,0));
		iFormation.Add (new Vector3 (1,-1,0));
		iFormation.Add (new Vector3 (1,-2,0));
		iFormation.Add (new Vector3 (2, 0,0));
//		uFormation.Add (new Vector3 (2,-1,0));
		iFormation.Add (new Vector3 (2,-2,0));

  		jFormation.Add (new Vector3 (0,-2,0));
  		jFormation.Add (new Vector3 (1,-2,0));
		jFormation.Add (new Vector3 (2, 0,0));
		jFormation.Add (new Vector3 (2,-1,0));
		jFormation.Add (new Vector3 (2,-2,0));
		
		kFormation.Add (new Vector3 (0, 0, 0));
		kFormation.Add (new Vector3 (0, -1, 0));
		kFormation.Add (new Vector3 (0, -2, 0));
		kFormation.Add (new Vector3 (1, -1, 0));
		kFormation.Add (new Vector3 (2, 0, 0));
		kFormation.Add (new Vector3 (2, -2, 0));
		
		lFormation.Add (new Vector3 (0,0,0));
		lFormation.Add (new Vector3 (0,-1,0));
		lFormation.Add (new Vector3 (0,-2,0));
		lFormation.Add (new Vector3 (1, -2, 0));
		lFormation.Add (new Vector3 (2, -2, 0));

		mFormation.Add (new Vector3 (0,0,0));  
		mFormation.Add (new Vector3 (0,-1,0));
		mFormation.Add (new Vector3 (0,-2,0));
		mFormation.Add (new Vector3 (1,0,0));
		mFormation.Add (new Vector3 (1,-1,0));
		mFormation.Add (new Vector3 (1,-2,0));
		mFormation.Add (new Vector3 (2, 0,0));
		mFormation.Add (new Vector3 (2,-1,0));
		mFormation.Add (new Vector3 (2,-2,0));

		nFormation.Add (new Vector3 (0,0,0));  
		nFormation.Add (new Vector3 (0,-1,0));
		nFormation.Add (new Vector3 (0,-2,0));
		nFormation.Add (new Vector3 (1,0,0));
		nFormation.Add (new Vector3 (1,-1,0));
		nFormation.Add (new Vector3 (1,-2,0));
		nFormation.Add (new Vector3 (2, 0,0));
		nFormation.Add (new Vector3 (2,-1,0));
		nFormation.Add (new Vector3 (2,-2,0));

		oFormation.Add (new Vector3 (0,0,0));
		oFormation.Add (new Vector3 (0,-1,0));
		oFormation.Add (new Vector3 (0,-2,0));
		oFormation.Add (new Vector3 (1,0,0));
		oFormation.Add (new Vector3 (1,-2,0));
		oFormation.Add (new Vector3 (2, 0,0));
		oFormation.Add (new Vector3 (2,-1,0));
		oFormation.Add (new Vector3 (2,-2,0));

		pFormation.Add (new Vector3 (0,0,0));  
		pFormation.Add (new Vector3 (0,-1,0));
		pFormation.Add (new Vector3 (0,-2,0));
		pFormation.Add (new Vector3 (1,0,0));
		pFormation.Add (new Vector3 (1,-1,0));
		pFormation.Add (new Vector3 (2, 0,0));
		pFormation.Add (new Vector3 (2,-1,0));

		qFormation.Add (new Vector3 (0,0,0));  
		qFormation.Add (new Vector3 (0,-1,0));
		qFormation.Add (new Vector3 (0,-2,0));
		qFormation.Add (new Vector3 (1,0,0));
		qFormation.Add (new Vector3 (1,-2,0));
		qFormation.Add (new Vector3 (2, 0,0));
		qFormation.Add (new Vector3 (2,-1,0));
		qFormation.Add (new Vector3 (2,-2,0));
		qFormation.Add (new Vector3 (3,-2,0));

		rFormation.Add (new Vector3 (0,0,0));  
		rFormation.Add (new Vector3 (0,-1,0));
		rFormation.Add (new Vector3 (0,-2,0));
		rFormation.Add (new Vector3 (1,0,0));
		rFormation.Add (new Vector3 (1,-1,0));
		rFormation.Add (new Vector3 (2, 0,0));
		rFormation.Add (new Vector3 (2,-1,0));
		rFormation.Add (new Vector3 (3,-2,0));

		sFormation.Add (new Vector3 (0,0,0));  
		sFormation.Add (new Vector3 (0,-1,0));
		sFormation.Add (new Vector3 (1,-1,0));
		sFormation.Add (new Vector3 (1,-2,0));
		sFormation.Add (new Vector3 (2,-1,0));
		sFormation.Add (new Vector3 (2,-2,0));

		tFormation.Add (new Vector3 (0,0,0));  
		tFormation.Add (new Vector3 (1,0,0));
		tFormation.Add (new Vector3 (1,-1,0));
		tFormation.Add (new Vector3 (1,-2,0));
		tFormation.Add (new Vector3 (2, 0,0));

		uFormation.Add (new Vector3 (0,0,0));  
		uFormation.Add (new Vector3 (0,-1,0));
		uFormation.Add (new Vector3 (0,-2,0));
//		uFormation.Add (new Vector3 (1,0,0));
//		uFormation.Add (new Vector3 (1,-1,0));
		uFormation.Add (new Vector3 (1,-2,0));
		uFormation.Add (new Vector3 (2, 0,0));
		uFormation.Add (new Vector3 (2,-1,0));
		uFormation.Add (new Vector3 (2,-2,0));

		vFormation.Add (new Vector3 (0,0,0));  
		vFormation.Add (new Vector3 (0,-1,0));
		vFormation.Add (new Vector3 (1,-2,0));
		vFormation.Add (new Vector3 (2, 0,0));
		vFormation.Add (new Vector3 (2,-1,0));

		wFormation.Add (new Vector3 (0,0,0));  
		wFormation.Add (new Vector3 (0,-1,0));
		wFormation.Add (new Vector3 (0,-2,0));
		wFormation.Add (new Vector3 (1,0,0));
		wFormation.Add (new Vector3 (1,-1,0));
		wFormation.Add (new Vector3 (1,-2,0));
		wFormation.Add (new Vector3 (2, 0,0));
		wFormation.Add (new Vector3 (2,-1,0));
		wFormation.Add (new Vector3 (2,-2,0));

		xFormation.Add (new Vector3 (0,0,0));  
		xFormation.Add (new Vector3 (0,-1,0));
		xFormation.Add (new Vector3 (0,-2,0));
		xFormation.Add (new Vector3 (1,0,0));
		xFormation.Add (new Vector3 (1,-1,0));
		xFormation.Add (new Vector3 (1,-2,0));
		xFormation.Add (new Vector3 (2, 0,0));
		xFormation.Add (new Vector3 (2,-1,0));
		xFormation.Add (new Vector3 (2,-2,0));

		yFormation.Add (new Vector3 (0,0,0));  
		yFormation.Add (new Vector3 (0,-1,0));
		yFormation.Add (new Vector3 (0,-2,0));
		yFormation.Add (new Vector3 (1,-1,0));
		yFormation.Add (new Vector3 (1,-2,0));
		yFormation.Add (new Vector3 (2, 0,0));
		yFormation.Add (new Vector3 (2,-1,0));
		yFormation.Add (new Vector3 (2,-2,0));

		zFormation.Add (new Vector3 (0,0,0));  
		zFormation.Add (new Vector3 (0,-2,0));
		zFormation.Add (new Vector3 (1,-1,0));
		zFormation.Add (new Vector3 (1,-2,0));
		zFormation.Add (new Vector3 (2, 0,0));
		zFormation.Add (new Vector3 (2,-1,0));

		Formation.Add (new Vector3 (0,0,0));  
		Formation.Add (new Vector3 (0,-1,0));
		Formation.Add (new Vector3 (0,-2,0));
		Formation.Add (new Vector3 (1,0,0));
		Formation.Add (new Vector3 (1,-1,0));
		Formation.Add (new Vector3 (1,-2,0));
		Formation.Add (new Vector3 (2, 0,0));
		Formation.Add (new Vector3 (2,-1,0));
		Formation.Add (new Vector3 (2,-2,0));

	}

}
