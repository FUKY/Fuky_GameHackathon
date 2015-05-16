using UnityEngine;
using System.Collections;

public class TreeScripts : MonoBehaviour {

    // animator
    Animator anim;

    // Lượng nước hiện tại của Cây
    public float waterCurrent = 0.0f;

	// Use this for initialization
	void Start () {  
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (waterCurrent >= 1)
        {
            Debug.Log("You Win !!");
        }
	}

    public void UpdateWaterOfTree(float water)
    {
        // lượng nước mà player còn lại đê tưới cây
        float waterOfPlayer = water * 0.2f;

        waterCurrent += waterOfPlayer;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            UpdateWaterOfTree(Demo_Player.water);
            Destroy(col.gameObject);
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
    public void SetAnimationStand5()
    {
        anim.SetTrigger("stand5");
    }

    

}
