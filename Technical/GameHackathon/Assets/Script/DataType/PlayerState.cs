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

    //float delayWater;
    public override void Do()
    {
        rb2dPlayer.velocity = new Vector2(playerController.playerSpeed, 0f);
    }

    public override void Change()
    {
        if (playerController.touchHell == true) 
        {
            GameController.Instance.systemState.ChangeState(EPlayerState.WATER);

        }
        else
        {
            
        }
    }

  

}

public class PlayerWaterState : PlayerState
{
    GameObject player = GameController.Instance.player;
    Animator animatorPlayer = GameController.Instance.player.GetComponent<Animator>();
    Rigidbody2D rb2dPlayer = GameController.Instance.player.GetComponent<Rigidbody2D>();
    PlayerController playerController = GameController.Instance.player.GetComponent<PlayerController>();

    float delayWater;
    public override void Do()
    {
        if (playerController.touchHell == true)
        {
            animatorPlayer.SetTrigger("waterPlayer");
            rb2dPlayer.velocity = new Vector2(0f, 0f);
            playerController.touchHell = false;
        }
        else
            return;
        

    }

    public override void Change()
    {
        if (delayWater >= 2f)
        {
            GameController.Instance.systemState.ChangeState(EPlayerState.MOVE);
            delayWater = 0f;
            playerController.FLipPlayer();
        }
        else
            delayWater += Time.deltaTime;
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
