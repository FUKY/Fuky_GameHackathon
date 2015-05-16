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
    //public float usingItemTime;
    public bool usingItemTime;
    public bool usingItemShield;
    public bool usingItemHPWater;
    public float timeUsingShield;
    public float timeUsingTime;
    public float timeExistShield =2f;
    public float timeExistTime = 2f;

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

    void Update()
    {
        if(usingItemTime)
        {
            if((timeUsingTime += Time.deltaTime) > timeExistTime)
            {
                usingItemTime = false;
            }
        }

        if (usingItemShield)
        {
            if ((timeUsingShield += Time.deltaTime) > timeExistShield)
            {
                usingItemShield = false;
            }
        }
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
            Itemscrips itemscript = gameObj.GetComponent<Itemscrips>();
            float temp = itemscript.decreaseHP;
            touchItem = true;
            switch (itemscript.itemCurr)
            {
                case EItemState.ITEM1:                             
                case EItemState.ITEM2:
                case EItemState.ITEM3:
                    {
                        if (!usingItemShield)
                        {
                            HPPlayer -= temp;
                        }
                        break;
                    }
                case EItemState.TIME:
                    {
                        usingItemTime = true;
                        timeUsingTime = 0f;
                        break;
                    }
                case EItemState.SHIELD:
                    {
                        
                        usingItemShield = true;
                        timeUsingShield = 0f;
                        break;
                    }
                case EItemState.HPWATER:
                    {
                        usingItemHPWater = true;
                        HPPlayer += temp;
                        break;
                    }
            }
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
