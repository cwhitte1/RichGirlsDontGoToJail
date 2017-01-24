
using UnityEngine;

using System.Collections;



public class CameraMovement : MonoBehaviour
{

    public GameObject toFollow;

    private float cameraFocus;

    // Use this for initialization
    void Start() {
        //cameraFocus;
    }

    // Update is called once per frame
    void Update() {
        UpdateLocation();
    }

    void UpdateLocation() {
        if (toFollow.transform.position.y > cameraFocus) cameraFocus = toFollow.transform.position.y;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,cameraFocus,gameObject.transform.position.z);
    }
}