using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformBlock;
    public GameObject fastPlatformBlock;
    public GameObject player;

    private ArrayList blocks;
    private Vector3 nextVector3;
    private float growFloat;
    private ArrayList platformBlockPool;
    private ArrayList fastPlatformBlockPool;

    void Awake() {
        platformBlockPool = new ArrayList();
        fastPlatformBlockPool = new ArrayList();
        for (int i = 0; i < 50; i++) platformBlockPool.Add((GameObject)Instantiate(platformBlock, new Vector3(0,-7,0), Quaternion.identity));
        for (int i = 0; i < 5; i++) fastPlatformBlockPool.Add((GameObject)Instantiate(fastPlatformBlock, new Vector3(0, -7, 0), Quaternion.identity));
    }

	// Use this for initialization
	void Start () {
        blocks = new ArrayList();
        growFloat = 100;
        nextVector3 = gameObject.transform.position + new Vector3(0, growFloat, 0);
        InstantiateBlocks();
	}
	
    void InstantiateBlocks() {

    }

    GameObject PoolCheckout(GameObject item) {
        GameObject tmp = (GameObject)platformBlockPool[0];
        platformBlockPool.Remove(tmp);
        return tmp;
    }

    void PoolReturn(GameObject item) {
        item.transform.position = new Vector3(-100, -100, 0);
    }
}
