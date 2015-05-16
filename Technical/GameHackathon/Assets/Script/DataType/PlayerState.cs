using UnityEngine;
using System.Collections;

public class PlayerState
{
    public virtual void Do()
    {
        //Do some thing
    }

    public virtual void Change()
    {
        //Co the chuyen sang trang thai nao
    }

   
}

public class PlayerMoveState : PlayerState
{
    float speed = 10;
    GameObject player = GameController.Instance.player;
    PlayerController playerController = GameController.Instance.player.GetComponent<PlayerController>();
    Animator animatorPlayer = GameController.Instance.player.GetComponent<Animator>();
    public override void Do()
    {
    }

    public override void Change()
    {
        
    }

}

public class PlayerWaterState : PlayerState
{
    public override void Do()
    {
        
    }

    public override void Change()
    {

    }
}

public class PlayerDieState : PlayerState
{
    public override void Do()
    {
    }

    public override void Change()
    {

    }


}
