using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoSingleton<GameController> {

    public GameObject player;
    public GameObject backGround;
    public Slider slideOfTree;
    public Slider slideOfWell;
    public int score;
    public Text txtScore;
    public FSSystemState systemState = new FSSystemState();
    
	void Start () {
        systemState.Init();
        //systemState.ChangeState(EPlayerState.MOVE);
        
        GameReset();
        this.UpdateScore(0);
	}
	
    public void GameInit()
    {

    }
    [ContextMenu("Background")]
    public void GameReset()
    {
        systemState.ChangeState(EPlayerState.MOVE);
        EnviromentController.Instance.SetData();
        EnviromentController.Instance.RandomState();
        backGround.GetComponent<SpriteRenderer>().sprite = EnviromentController.Instance.imageCurrent;
        score = 0;
    }


    public float timeDelay = 0f;
	void Update () {
        if (player.GetComponent<PlayerController>().isDie)
        {
            return;
        }
        slideOfTree.value = TreeScripts.Instance.waterCurrent;
        slideOfWell.value = player.GetComponent<PlayerController>().HPPlayer;
        systemState.Update();    
        if((timeDelay += Time.deltaTime) >= 1.0f)
        {
            timeDelay = 0f;
            if(player.GetComponent<PlayerController>().usingItemTime)
            {
                player.GetComponent<PlayerController>().usingItemTime = false;
                ItemController.Instance.Spawn(EnviromentController.Instance.spawner - EnviromentController.Instance.spawner * 0.5f);
            }
            else
            {
                ItemController.Instance.Spawn(EnviromentController.Instance.spawner);
            }
            
        }
	}

    public void UpdateScore(int score)
    {
        this.score += score;
        txtScore.text = "SCORE: " +  this.score.ToString();
    }
}
