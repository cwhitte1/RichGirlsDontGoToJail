using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public float walkSpeed;
    public float jumpPower;
    public float fastJump = 15;
    public bool playerControlled;
    public GameObject splatter;
    public GameObject fastSplatter;

    private Rigidbody2D theRigidBody;

    // Use this for initialization
    void Start () {
        theRigidBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (playerControlled) {
            float inputX = Input.GetAxis("Horizontal");
            theRigidBody.velocity = new Vector2(inputX * walkSpeed, theRigidBody.velocity.y);
        } else {
            var accel = Input.acceleration;
		    accel.Normalize ();
            transform.Translate(new Vector3(accel.x*walkSpeed, 0f, 0f));
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (theRigidBody.velocity.y <= 0) {
            if (other.CompareTag("Platform")) {
                theRigidBody.velocity = new Vector2(0f, jumpPower);
                GameObject tmp = GameObject.Instantiate(splatter);
                tmp.transform.position = gameObject.transform.position;

            } else if(other.CompareTag("FastPlatform")) {
                theRigidBody.velocity = new Vector2(0f, fastJump);
                GameObject tmp = GameObject.Instantiate(fastSplatter);
                tmp.transform.position = gameObject.transform.position;
            }
        }
        if (other.CompareTag("Death")) SceneManager.LoadScene("Ending");
    }
}
