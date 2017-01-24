using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform go;

    private float score = 0;
    private Text text;

	// Use this for initialization
	void Start () {
        text = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(go.position.y > score) {
            score = go.position.y;
        }
        text.text = "Score = " + 100*score;
	}
}
