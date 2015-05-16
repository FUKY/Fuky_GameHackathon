using UnityEngine;
using System.Collections;

public class GameController : MonoSingleton<GameController> {

    public GameObject player;
    public GameObject backGround;
    public int score;
    public FSSystemState systemState = new FSSystemState();
    
	void Start () {
        systemState.Init();
        systemState.ChangeState(EPlayerState.MOVE);
        
        GameReset();
	}
	
    public void GameInit()
    {

    }
    [ContextMenu("Background")]
    public void GameReset()
    {
        EnviromentController.Instance.SetData();
        EnviromentController.Instance.RandomState();
        backGround.GetComponent<SpriteRenderer>().sprite = EnviromentController.Instance.imageCurrent;
        score = 0;
    }

    public float timeDelay = 0f;
	void Update () {        
        systemState.Update();    
        if((timeDelay += Time.deltaTime) >= 1.0f)
        {
            timeDelay = 0f;
            ItemController.Instance.Spawn(EnviromentController.Instance.spawner);
        }
	}
}
