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
    
    GameObject player = GameController.Instance.player;
    PlayerController playerController = GameController.Instance.player.GetComponent<PlayerController>();
    Animator animatorPlayer = GameController.Instance.player.GetComponent<Animator>();
    Rigidbody2D rb2dPlayer = GameController.Instance.player.GetComponent<Rigidbody2D>();

    float xScale = GameController.Instance.player.transform.localScale.x;
    

    public override void Do()
    {
        
        rb2dPlayer.velocity = new Vector2(playerController.playerSpeed, 0f);        
    }

    public override void Change()
    {
        //if (player.transform.position.x >= 2f) 
        //{
        //    GameController.Instance.systemState.ChangeState(EPlayerState.WATER);
        //}
    }

  

}

public class PlayerWaterState : PlayerState
{
    Animator animatorPlayer = GameController.Instance.player.GetComponent<Animator>();
    PlayerController playerController = GameController.Instance.player.GetComponent<PlayerController>();
    public override void Do()
    {
        //animatorPlayer.SetTrigger("waterPlayer");
        //playerController.playerSpeed = 0f;
    }

    public override void Change()
    {
        //GameController.Instance.systemState.ChangeState(EPlayerState.MOVE);
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
