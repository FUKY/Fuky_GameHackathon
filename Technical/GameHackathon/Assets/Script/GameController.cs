using UnityEngine;
using System.Collections;

public class GameController : MonoSingleton<GameController> {

    public GameObject player;
    public int score;
    public FSSystemState systemState = new FSSystemState();
    
	void Start () {
        systemState.Init();
        systemState.ChangeState(EPlayerState.MOVE);
	}
	
    public void GameInit()
    {

    }

    public void GameReset()
    {
        EnviromentController.Instance.RandomState();
        score = 0;
    }


	void Update () {        
        systemState.Update();        
	}
}
