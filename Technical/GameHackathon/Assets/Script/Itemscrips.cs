using UnityEngine;
using System.Collections;

public class Itemscrips : MonoBehaviour {

    public int idOfItem = 0;

    // vận tốc di chuyển của item
    public float speedMove = 0.0f;
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = transform.position;

        newPos.y += Time.deltaTime *-speedMove;

        transform.position = newPos;

        if(transform.position.y < -2.3f)
        {
            gameObject.SetActive(false);
        }
	}

}
