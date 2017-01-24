using UnityEngine;
using System.Collections;

public class HillaryMovement : MonoBehaviour {

    public float desiredVector2Threshold;
    public float walkSpeed;
    public GameObject toFollow;
    public GameObject jailToFollow;

    private Vector3 desiredVector2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement() {
        //if (Random.Range(0.0f, 1.0f) < desiredVector2Threshold) { CreateNewDesiredVector2(); }
        transform.position = new Vector2(Vector2.MoveTowards(transform.position, toFollow.transform.position, walkSpeed * Time.deltaTime).x,jailToFollow.transform.position.y+0.1f);
    }
}
