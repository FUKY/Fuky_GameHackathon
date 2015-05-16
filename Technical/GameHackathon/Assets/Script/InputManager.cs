using UnityEngine;
using System.Collections;

public class InputManager : MonoSingleton<InputManager> {
    public bool isOffTap; 
    float tapDelay;
    public void OnTap()
    {
        if (!isOffTap)
        {
            GameController.Instance.player.GetComponent<PlayerController>().FLipPlayer();
        }
    }
    void Update()
    {
        if (isOffTap)
        {
            if ((tapDelay += Time.deltaTime) >= 1.3f)
            {
                tapDelay = 0f;
                isOffTap = false;
            }
        }
    }
}
