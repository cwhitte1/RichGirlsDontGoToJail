using UnityEngine;
using System.Collections;

public class JailMovement : MonoBehaviour {

    //public GameObject toFollow;

    private float cameraFocus;
    public GameObject toFollow;

    // Use this for initialization
    void Start()
    {
        toFollow = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLocation();
    }

    void UpdateLocation()
    {
        //if (toFollow.transform.position.y > cameraFocus) cameraFocus = toFollow.transform.position.y;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, toFollow.transform.position.y-5, gameObject.transform.position.z);
    }
}
