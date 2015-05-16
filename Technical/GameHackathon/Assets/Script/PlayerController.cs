using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float playerSpeed;
    public float HPPlayer = 1f;
    
    float xScale;

    public bool touchHell;
    public bool touchTree;
    public bool touchItem;

    public bool back;

    public bool passive;


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
            //HPPlayer = 1f;


        }
        if (col.tag == "Item")
        {
            GameObject gameObj = col.gameObject;
            float temp = gameObj.GetComponent<Itemscrips>().decreaseHP;
            HPPlayer -= temp;
            touchItem = true;
        }
        if (col.tag == "Tree")
        {

            touchTree = true;
            TreeScripts.Instance.UpdateWaterOfTree(HPPlayer);
            //HPPlayer = 0f;

        }
    }

    public void PassivePlayer()
    {
        passive = true;
    }


}
