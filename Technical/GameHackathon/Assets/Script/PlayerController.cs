using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float playerSpeed;
    float xScale;


    void Start()
    {
        xScale = transform.localScale.x;
    }

    public void FLipPlayer()
    {
        playerSpeed *= -1;
        xScale *= -1;
        transform.localScale = new Vector3(xScale, transform.localScale.y, 0f);
    }
}
