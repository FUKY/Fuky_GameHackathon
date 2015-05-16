using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSSystemState{

    public PlayerState stateCurrent;
    public Dictionary<EPlayerState, PlayerState> fsSystemState;

	public void Init()
    {
        //Khoi tao state
        PlayerMoveState moveState = new PlayerMoveState();
        PlayerWaterState waterState = new PlayerWaterState();
        PlayerDieState dieState = new PlayerDieState();

        //Add trang thai vao may chuyen doi state
        fsSystemState = new Dictionary<EPlayerState, PlayerState>();
        fsSystemState.Add(EPlayerState.MOVE, moveState);
        fsSystemState.Add(EPlayerState.WATER, waterState);
        fsSystemState.Add(EPlayerState.DIE, dieState);

        
    }

    public void ChangeState(EPlayerState state)
    {
        if(fsSystemState.ContainsKey(state))
        {
            this.stateCurrent = fsSystemState[state];
        }
        else
        {
#if UNITY_EDITOR
            Debug.LogError("Khong the chuyen doi trang thai");
#endif
        }
    }

    public void Update()
    {
        if(stateCurrent != null)
        {
            stateCurrent.Do();
            stateCurrent.Change();
        }
        else
        {
#if UNITY_EDITOR
            Debug.LogError("Khong ton tai trang thai nay");
#endif
        }
    }
}
