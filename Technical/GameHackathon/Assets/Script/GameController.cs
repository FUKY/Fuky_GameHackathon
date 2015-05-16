using UnityEngine;
using System.Collections;

public class GameController : MonoSingleton<GameController> {

    public GameObject player;
    public FSSystemState systemState = new FSSystemState();
	void Start () {
        systemState.Init();
        systemState.ChangeState(EPlayerState.MOVE);
	}
	
	void Update () {        
        systemState.Update();        
	}
}
