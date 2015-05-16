using UnityEngine;
using System.Collections;

public class Itemscrips : MonoBehaviour {

    public int idOfItem = 0;
    public float decreaseHP = 0.1f;

    public EItemState itemCurr;

    // vận tốc di chuyển của item
    private float speed;
    public float speedMove = 0.0f;
	
    void Start()
    {
        speed = speedMove;
    }
	// Update is called once per frame
	void Update () {
        Vector3 newPos = transform.position;

        newPos.y += Time.deltaTime * -speed;

        transform.position = newPos;

        if(transform.position.y < -2.3f)
        {
            gameObject.SetActive(false);
        }
	}

    public void Percent(float temp)
    {
        speed += speed * temp;
    }

    public void Reset()
    {
        speed = speedMove;
    }

}
