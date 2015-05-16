using UnityEngine;
using System.Collections;

public class SpawnItem : MonoBehaviour {

    private Vector3 _startPosition;

    // biến dừng thả item nếu nhận được itemSupport
    public static bool stop = false;

    //khoang cach 2 lan spawn
    public float distanceTime = 3.0f;

    float _startTime = 0.0f;
    float _subTime = 0.0f;

    //vị trí min random item
    public int minRandom;

    // vị trí max random item
    public int maxRandom;

    // item 
    public GameObject item;

    

	// Use this for initialization
	void Start () {
        _startPosition = transform.position;
        GetComponent<Rigidbody2D>();
	}
	

	// Update is called once per frame
	void Update () {
        _subTime = Time.time - _startTime;

        if (_subTime > distanceTime )
        {
            // random vị trí x của spawnItem
            int newPosX = Random.Range(minRandom, maxRandom);
            // vị trí mới thả item
            Vector3 newPos = new Vector3(newPosX, transform.position.y,transform.position.z);
            
            transform.position = newPos;

            Instantiate(item, transform.position, Quaternion.identity);

            _startTime = Time.time;
        }
	}
}
