using UnityEngine;
using System.Collections;

public class TreeScripts : MonoSingleton<TreeScripts> {

    // animator
    Animator anim;

    // Lượng nước hiện tại của Cây
    public float waterCurrent = 0.0f;
    private int floor = 1;

	// Use this for initialization
	void Start () {  
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
    //void UpdateWater(float water) {
    //    if (waterCurrent >= (1 * 0.2f))
    //    {
    //        floor++;
    //        ChangeFloor();
    //    }
    //}

    public void UpdateWaterOfTree(float water)
    {
        // lượng nước mà player còn lại đê tưới cây
        float waterOfPlayer = water * 0.2f;

        waterCurrent += waterOfPlayer;
        if (waterCurrent >= (floor * 0.2f))
        {
            floor++;
            ChangeFloor();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //UpdateWaterOfTree(Demo_Player.water);
            //Destroy(col.gameObject);
        }
    }

    // hàm chuyển giao diện khi thắng game
    public void ChangeFloorTheWin(bool isChange)
    {
        if (isChange)
        {
            anim.SetTrigger("theWin");
        }
    }



    public  void ChangeFloor()
    {
        switch(floor)
        {
            case 1:
                {
                    anim.SetTrigger("level1");
                    break;
                }
            case 2:
                {
                    anim.SetTrigger("level2");
                    break;
                }
            case 3:
                {
                    anim.SetTrigger("level3");
                    break;
                }
            case 4:
                {
                    anim.SetTrigger("level4");
                    break;
                }
            case 5:
                {
                    anim.SetTrigger("level5");
                    break;
                }
        }
    }


    public void SetAnimationStand1()
    {
        anim.SetTrigger("stand1");
    }
    public void SetAnimationStand2()
    {
        anim.SetTrigger("stand2");
    }
    public void SetAnimationStand3()
    {
        anim.SetTrigger("stand3");
    }
    public void SetAnimationStand4()
    {
        anim.SetTrigger("stand4");
    }


    public void SetRestart()
    {
        anim.SetTrigger("restart");
    }

    public void SetTheWin()
    {
        anim.SetTrigger("theWin");
    }
    

}
