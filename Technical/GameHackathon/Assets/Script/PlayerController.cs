using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float playerSpeed;
    
    float xScale;
    public bool touchHell;

    public bool back;

    void Start()
    {
        xScale = transform.localScale.x;
    }

    public void TurnBack()
    {
        back = true;
    }
    public void TurnBackOff()
    {

        back = false;
    }

    public void FLipPlayer()
    {
        playerSpeed *= -1;
        xScale *= -1;
        transform.localScale = new Vector3(xScale, transform.localScale.y, 0f);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Hell") 
        {
            touchHell = true;            
        }

    }


}
