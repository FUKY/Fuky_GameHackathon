using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public void OnTap()
    {
        GameController.Instance.player.GetComponent<PlayerController>().FLipPlayer();
    }
}
