using UnityEngine;
using System.Collections;

public class TreeScripts : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {  
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
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
