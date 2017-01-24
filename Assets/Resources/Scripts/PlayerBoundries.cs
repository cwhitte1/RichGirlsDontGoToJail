using UnityEngine;
using System.Collections;

public class PlayerBoundries : MonoBehaviour {
	//private Camera cam;
	//private Plane[] planes;
	public GameObject cat;
	public Transform check;

	void Start() {
		/*cam = Camera.main;
		planes = GeometryUtility.CalculateFrustumPlanes(cam);
		int i = 0;
		while (i < planes.Length) {
			GameObject p = GameObject.CreatePrimitive(PrimitiveType.Plane);
			p.name = "Plane " + i.ToString();
			p.transform.position = -planes[i].normal * planes[i].distance;
			p.transform.rotation = Quaternion.FromToRotation(Vector3.up, planes[i].normal);
			i++;
		} */
	}
	
	// Update is called once per frame
	void Update () {
		/*
		Vector3 pos = new Vector3(transform.position.x,transform.position.y);
		if (!(planes [0].GetSide (pos))) {
			Vector3 right = planes [1].normal;
			//print (right.x);
			transform.position = new Vector3 (right.x * 2, pos.y);
		} else if (planes [1].GetSide (pos)) {
			Vector3 left = planes [0].normal;
			//transform.position = new Vector3 (left.x, pos.y);
		}
	}
	*/
		if (transform.position.x < -4) {
			print ("wow");
			transform.position = new Vector2 (4, transform.position.y);
		}
		if (transform.position.x > 4) {
			transform.position = new Vector2 (-4, transform.position.y);
		}
	}
}