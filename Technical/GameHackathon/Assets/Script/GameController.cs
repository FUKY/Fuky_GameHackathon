using UnityEngine;
using System.Collections;

public class GameController : MonoSingleton<GameController> {

	// Use this for initialization
    public GameObject player;
    public FSSystemState systemState = new FSSystemState();
	void Start () {
        //systemState = GameController.Instance.systemState;
        systemState.Init();
        systemState.ChangeState(EPlayerState.MOVE);
	}
	
	// Update is called once per frame
	void Update () {

        systemState.Update();
        
	}
}
