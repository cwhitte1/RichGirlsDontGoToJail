using UnityEngine;
using System.Collections;

public class BlockManager : MonoBehaviour {

    public float bounds;
    public float upwardBounds;
    public float upwardRange;

    private GameObject camera;

    void Awake() {
        camera = GameObject.Find("Main Camera");
    }

    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (gameObject.transform.position.y < (camera.transform.position.y - 7)) {
            SetNewLocation();
        }
    }

    void SetNewLocation() {
        gameObject.transform.position = new Vector3(Random.Range(-bounds, bounds - gameObject.transform.localScale.x), Random.Range(camera.transform.position.y + upwardBounds, camera.transform.position.y + upwardBounds + upwardRange), 0);
    }

    void OnTriggerEnter2D(Collider2D other) {
         if (other.tag == "Platform" || other.tag == "FastPlatform") { SetNewLocation(); }
    }
}